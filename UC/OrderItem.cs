using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PadaviyaShop.UC
{
    public partial class load : UserControl
    {
        MySqlConnection con = new MySqlConnection("server=localhost;userid=root;password=;database=damayanthistoredb");

        DataTable dt = new DataTable();
        float tot = 0;
        int item = 0;

        
        public load()
        {
            InitializeComponent();
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            dt.Clear();
            dt.Columns.Add("ItemCode");
            dt.Columns.Add("ItemName");
            dt.Columns.Add("WholePrice");
            dt.Columns.Add("WholePriceTotal");
            dt.Columns.Add("RentalPrice");
            dt.Columns.Add("Quntity");
            dt.Columns.Add("Total");

            lblTotalWhole.Visible = false;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            float stoke = 0;
            MySqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM damayanthistoredb.tblitem WHERE ItemName = '" + txtItemName.Text + "' ";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                stoke = float.Parse(dr1["ItemQuntity"].ToString());
            }

            if (float.Parse(txtQuntity.Text) > stoke)
            {
                MessageBox.Show("This much value is not available");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["ItemCode"] = txtItemCode.Text;
                dr["ItemName"] =  txtItemName.Text;
                dr["WholePrice"] = lblWholePrice.Text;
                dr["WholePriceTotal"] = lblTotalWhole.Text;
                dr["RentalPrice"] = txtPrice.Text;
                
                dr["Quntity"] = txtQuntity.Text;
                dr["Total"] = txtTotal.Text;

             
                dt.Rows.Add(dr);


                dgvBill.DataSource = dt;

                tot = tot + float.Parse(dr["Total"].ToString());

                lblTotal.Text = tot.ToString();

                
                
                

            }

            txtItemName.Text = "";
            txtItemCode.Text = "";
            txtPrice.Text = "";
            txtQuntity.Text = "";
            txtTotal.Text = "";
            lblWholePrice.Text = "";
            label10.Text = "";
        }

        private void txtItemCode_KeyUp(object sender, KeyEventArgs e)
        {
            listBoxItemName.Visible = true;
            listBoxItemName.Items.Clear();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM damayanthistoredb.tblitem WHERE ItemName like('" + txtItemName.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBoxItemName.Items.Add(dr["ItemName"].ToString());
                
            }
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxItemName.Focus();
                listBoxItemName.SelectedIndex = 0;
            }
        }

        private void listBoxItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBoxItemName.SelectedIndex = this.listBoxItemName.SelectedIndex + 1;
                }

                if (e.KeyCode == Keys.Up)
                {
                    this.listBoxItemName.SelectedIndex = this.listBoxItemName.SelectedIndex - 1;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    txtItemName.Text = listBoxItemName.SelectedItem.ToString();
                    listBoxItemName.Visible = false;
                    txtItemCode.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtItemName_Enter(object sender, EventArgs e)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM damayanthistoredb.tblitem WHERE ItemName ='" + txtItemName.Text + "' order by ID ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                txtItemCode.Text = dr["ItemCode"].ToString();
                label10.Text = dr["ItemQuntity"].ToString();
                lblWholePrice.Text = dr["ItemWholePrice"].ToString();
                txtPrice.Text = dr["ItemRentalPrice"].ToString();
                
            }
        }

        private void txtQuntity_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = Convert.ToString(Convert.ToInt32(txtPrice.Text) * float.Parse(txtQuntity.Text));

                lblTotalWhole.Text = Convert.ToString(Convert.ToInt32(lblWholePrice.Text) * float.Parse(txtQuntity.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(dgvBill.CurrentCell.RowIndex.ToString()));
                foreach (DataRow dr1 in dt.Rows)
                {
                    tot = tot + Convert.ToInt32(dr1["Total"].ToString());
                    lblTotal.Text = tot.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPrintSave_Click(object sender, EventArgs e)
        {
            foreach(DataRow dr in dt.Rows)
            {
                float qty = 0;
                string pname = "";

                MySqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "INSERT INTO damayanthistoredb.tblsaleitem (SaleItemName, SaleItemCode, SaleItemWhole, SaleItemRental, SaleItemQuntity, SaleItemTotalPrice, SaleItemWholeTotal, SaleDate) VALUES ('" + dr["ItemName"].ToString() + "','" + dr["ItemCode"].ToString() + "','" + dr["WholePrice"].ToString() + "','" + dr["RentalPrice"].ToString() + "','" + dr["Quntity"].ToString() + "','" + dr["Total"].ToString() + "', '" + dr["WholePriceTotal"].ToString() + "' ,'" + DateTime.Today.ToString("M/d/yyyy") + "')";
                cmd1.ExecuteNonQuery();


                qty = float.Parse(dr["Quntity"].ToString());
                pname = dr["ItemName"].ToString();


                MySqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "Update damayanthistoredb.tblitem SET ItemQuntity= ItemQuntity-" + qty + " WHERE ItemName = '" + pname.ToString() + "' ";
                cmd2.ExecuteNonQuery();

            }

            txtItemName.Text = "";
            txtItemCode.Text = "";
            txtPrice.Text = "";
            txtQuntity.Text = "";
            txtTotal.Text = "";
            lblWholePrice.Text = "";
            lblTotal.Text = "";
            label10.Text = "";
           

            dt.Clear();
            dgvBill.DataSource = dt;


            MessageBox.Show("Record Inserted Successfully ");

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtItemCode.Text = "";
            txtPrice.Text = "";
            txtQuntity.Text = "";
            txtTotal.Text = "";
            lblWholePrice.Text = "";
            lblTotal.Text = "";
            label10.Text = "";

            dt.Clear();
        }

        

        
    }
}
