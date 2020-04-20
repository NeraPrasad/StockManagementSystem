using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PadaviyaShop.UC
{
    public partial class ManageItem : UserControl
    {
        string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
        
        
        public ManageItem()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkItemCode() == true)
            {
                lblalreademsg.Text = "* Your Item Code Already Entered";
                txtItemCode.BackColor = System.Drawing.Color.PaleGreen;


            }
            else
            {


                if (txtItemCode.Text != "" && txtItemName.Text != "" &&
                    txtQuntity.Text != "" && txtRentalPrice.Text != "" && txtwholeprice.Text != "")
                {
                    try
                    {

                        string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";

                        string query = "INSERT INTO damayanthistoredb.tblitem (ItemCode, ItemName, ItemWholePrice, ItemRentalPrice, ItemQuntity) VALUES ('" + txtItemCode.Text + "', '" + txtItemName.Text + "', '" + txtwholeprice.Text + "','" + txtRentalPrice.Text + "','" + txtQuntity.Text + "' )";

                        MySqlConnection con = new MySqlConnection(cs);
                        con.Open();

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        con.Close();

                        txtItemCode.Text = "";
                        txtItemName.Text = "";
                        txtQuntity.Text = "";
                        txtRentalPrice.Text = "";
                        txtwholeprice.Text = "";
                        lblalreademsg.Text = "";

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    finally
                    {
                        MessageBox.Show("Insert Successful");
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All Field", ("TextBox Validation"), MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private Boolean checkItemCode()
        {
            Boolean checkItemCode = false;
            String mycon = "server=localhost;userid=root;password=;database=damayanthistoredb";
            String myquery = "Select * from damayanthistoredb.tblitem where ItemCode ='" + txtItemCode.Text + "' ";
            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                checkItemCode = true;

            }
            con.Close();

            return checkItemCode;
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                btnInsert.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnWeast.Visible = true;

                txtDisableQuntity.Visible = true;
                txtNewquntity.Visible = true;

                txtQuntity.Visible = false;

                listBoxItemName.Visible = false;

                MySqlConnection con = new MySqlConnection(cs);
                con.Open();

                string query = "SELECT * FROM damayanthistoredb.tblitem WHERE ItemName = '" + txtItemName.Text + "' ";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    txtItemCode.Text = dr.GetString("ItemCode");
                    txtwholeprice.Text = dr.GetFloat("ItemWholePrice").ToString();
                    txtRentalPrice.Text = dr.GetFloat("ItemRentalPrice").ToString();
                    txtDisableQuntity.Text = dr.GetFloat("ItemQuntity").ToString();
                }
                else
                {
                    MessageBox.Show("No Item For This Item Code");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ManageItem_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnInsert.Visible = true;
            btnWeast.Visible = false;
            txtDisableQuntity.Visible = false;
            txtNewquntity.Visible = false;

            txtQuntity.Visible = true;

            listBoxItemName.Visible = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    con.Open();

                    float pre = float.Parse(txtDisableQuntity.Text, CultureInfo.InvariantCulture);
                    float now = float.Parse(txtNewquntity.Text, CultureInfo.InvariantCulture);

                    float current = pre + now;

                    MySqlCommand cmd = new MySqlCommand("UPDATE damayanthistoredb.tblitem SET  ItemName='" + txtItemName.Text + "' , ItemWholePrice='" + txtwholeprice.Text + "', ItemRentalPrice='" + txtRentalPrice.Text + "', ItemQuntity  ='" + current + "' WHERE ItemCode='" + txtItemCode.Text + "' ", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Is Update");

                    txtItemCode.Text = "";
                    txtItemName.Text = "";
                    txtDisableQuntity.Text = "";
                    txtRentalPrice.Text = "";
                    txtwholeprice.Text = "";

                    btnUpdate.Visible = false;
                    btnInsert.Visible = true;
                    btnDelete.Visible = false;
                    btnWeast.Visible = false;
                    txtDisableQuntity.Visible = false;
                    txtNewquntity.Visible = false;

                    txtQuntity.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnInsert.Visible = true;

            txtDisableQuntity.Visible = false;
            txtNewquntity.Visible = false;

            txtQuntity.Visible = true;

            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtDisableQuntity.Text = "";
            txtRentalPrice.Text = "";
            txtwholeprice.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
                string Query = "delete from damayanthistoredb.tblitem where ItemCode='" + this.txtItemCode.Text + "';";
                MySqlConnection con = new MySqlConnection(cs);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");

                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnInsert.Visible = true;

                txtDisableQuntity.Visible = false;
                txtNewquntity.Visible = false;

                txtQuntity.Visible = true;

                txtItemCode.Text = "";
                txtItemName.Text = "";
                txtDisableQuntity.Text = "";
                txtRentalPrice.Text = "";
                txtwholeprice.Text = "";

                while (MyReader2.Read())
                {
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnWeast_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    con.Open();
                    float nowQuntity = float.Parse(txtNewquntity.Text, CultureInfo.InvariantCulture);

                    MySqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "INSERT INTO damayanthistoredb.tblweastitem (ItemCode, ItemName, ItemWhole, ItemRental, ItemQuntity, Time) VALUES ('" + txtItemCode.Text + "', '" + txtItemName.Text + "', '" + txtwholeprice.Text + "','" + txtRentalPrice.Text + "','" + nowQuntity + "', '" + DateTime.Today.ToString("M/d/yyyy") + "')";
                    cmd1.ExecuteNonQuery();

                    float pre = float.Parse(txtDisableQuntity.Text, CultureInfo.InvariantCulture);
                    float now = float.Parse(txtNewquntity.Text, CultureInfo.InvariantCulture);

                    float current = pre - now;

                    MySqlCommand cmd = new MySqlCommand("UPDATE damayanthistoredb.tblitem SET  ItemName='" + txtItemName.Text + "' , ItemWholePrice='" + txtwholeprice.Text + "', ItemRentalPrice='" + txtRentalPrice.Text + "', ItemQuntity  ='" + current + "' WHERE ItemCode= '" + txtItemCode.Text + "' ", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Is Update");

                    txtItemCode.Text = "";
                    txtItemName.Text = "";
                    txtDisableQuntity.Text = "";
                    txtRentalPrice.Text = "";
                    txtwholeprice.Text = "";

                    btnUpdate.Visible = false;
                    btnInsert.Visible = true;
                    btnDelete.Visible = false;
                    btnWeast.Visible = false;

                    txtDisableQuntity.Visible = false;
                    txtNewquntity.Visible = false;

                    txtQuntity.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;userid=root;password=;database=damayanthistoredb");

            con.Open();
            listBoxItemName.Visible = true;
            listBoxItemName.Items.Clear();

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM damayanthistoredb.tblitem WHERE ItemName like('" + txtItemName.Text + "%')";
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBoxItemName.Items.Add(dr["ItemName"].ToString());

            }
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxItemName.Focus();
                listBoxItemName.SelectedIndex = 0;
            }
        }

        private void listBoxItemName_KeyDown(object sender, KeyEventArgs e)
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
                   
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
