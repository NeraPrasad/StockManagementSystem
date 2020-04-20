using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PadaviyaShop
{
    public partial class WeastItem : UserControl
    {
        string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";


        DataSet ds;

        public WeastItem()
        {
            InitializeComponent();
        }

        private void WeastItem_Load(object sender, EventArgs e)
        {
            ShowD();

            CountItem();
            CountWholeTotoal();
            
        }

        void ShowD()
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {

                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT ItemCode, ItemName, ItemWhole, ItemRental, ItemQuntity, Time FROM damayanthistoredb.tblweastitem ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReport.DataSource = dt;
               

            }
        }

        private void btnSerchCode_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand();

            string query = "SELECT * FROM damayanthistoredb.tblweastitem WHERE ItemCode= @ItemCode";
            cmd.CommandText = query;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);

            DataTable dl = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dl);
            con.Close();
            dgvReport.DataSource = dl;

            CountWholeTotoalCode();
            CountItemCode();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowD();
            txtItemCode.Text = "";
            CountItem();
            CountWholeTotoal();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlDataAdapter sdf = new MySqlDataAdapter(
                "SELECT * FROM damayanthistoredb.tblweastitem WHERE Time BETWEEN '" + DateForm.Value.ToString() +
                "' AND '" + DateTo.Value.ToString() + "' ", con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            dgvReport.DataSource = dt;

            CountWholeTotoalDate();
            CountItemDate();
        }

       

        
        //***************** Default ***************//
        void CountWholeTotoal()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(ItemWhole * ItemQuntity) from damayanthistoredb.tblweastitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int data = reader.GetInt32(0);
                lblWholeTotal.Text = data.ToString();
            }
            con.Close();
        }

        void CountItem()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count( ItemCode) from damayanthistoredb.tblweastitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblNoItems.Text = reader.GetString(0);
            }
            con.Close();
        }

        //***************** Serach Form Textbox ***************//
        void CountWholeTotoalCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(ItemWhole * ItemQuntity) from damayanthistoredb.tblweastitem WHERE ItemCode= '"+ txtItemCode.Text +"'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblWholeTotal.Text = data.ToString();
            }
            con.Close();
        }

        void CountItemCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count( ItemCode) from damayanthistoredb.tblweastitem WHERE ItemCode='"+ txtItemCode.Text+"' ", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblNoItems.Text = reader.GetString(0);
            }
            con.Close();
        }

        //***************** Serach Form Date ***************//
        void CountWholeTotoalDate()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(ItemWhole * ItemQuntity) from damayanthistoredb.tblweastitem WHERE Time BETWEEN '" + DateForm.Value.ToString() +
                                                "' AND '" + DateTo.Value.ToString() + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblWholeTotal.Text = data.ToString();
            }
            con.Close();
        }

        void CountItemDate()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count( ItemCode) from damayanthistoredb.tblweastitem WHERE Time BETWEEN '" + DateForm.Value.ToString() +
                                                "' AND '" + DateTo.Value.ToString() + "' ", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblNoItems.Text = reader.GetString(0);
            }
            con.Close();
        }
        
    }
}
