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
namespace PadaviyaShop.UC
{
    public partial class Report : UserControl
    {
        string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";


        DataSet ds;
        
        public Report()
        {
            InitializeComponent();
        }

        

        void ShowD()
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {

                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT SaleItemCode, SaleItemName, SaleItemRental, SaleItemQuntity, SaleItemTotalPrice,SaleItemWhole, SaleItemWholeTotal, SaleDate FROM damayanthistoredb.tblsaleitem ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReport.DataSource = dt;
            

            }
        }

     
        

        private void btnSerchCode_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand();

            string query = "SELECT SaleItemCode, SaleItemName, SaleItemRental, SaleItemQuntity, SaleItemTotalPrice,SaleItemWhole, SaleItemWholeTotal, SaleDate FROM damayanthistoredb.tblsaleitem WHERE SaleItemCode= @ItemCode";
            cmd.CommandText = query;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);

            DataTable dl = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dl);
            con.Close();
            dgvReport.DataSource = dl;

            CountGrandTotolSerachCode();
            CountWholeTotoalSerachCode();
            CountTotalProfitSerachCode();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowD();
            txtItemCode.Text = "";

            CountGrandTotoal();
            CountWholeTotoal();
            CountTotalProfit();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlDataAdapter sdf = new MySqlDataAdapter(
                "SELECT SaleItemCode, SaleItemName, SaleItemRental, SaleItemQuntity, SaleItemTotalPrice,SaleItemWhole, SaleItemWholeTotal, SaleDate FROM damayanthistoredb.tblsaleitem WHERE SaleDate BETWEEN '" + DateForm.Value.ToString() +
                "' AND '" + DateTo.Value.ToString() + "' ", con);
            DataTable dt = new DataTable();
            sdf.Fill(dt);
            dgvReport.DataSource = dt;

            CountGrandTotolSerachDate();
            CountTotalProfitSerachDate();
            CountWholeTotoalSerachDate();
            
        }

        
        private void Report_Load(object sender, EventArgs e)
        {
            ShowD();
            CountGrandTotoal();
            CountWholeTotoal();
            CountTotalProfit();
        }
        

        // ***************** Default **********************//
        void CountGrandTotoal()
            {
                string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select sum(SaleItemTotalPrice) from damayanthistoredb.tblsaleitem", con);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int data = reader.GetInt32(0);
                    lblGRandTotal.Text = data.ToString();
                }
                con.Close();
            }

        void CountWholeTotoal()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemWholeTotal) from damayanthistoredb.tblsaleitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int data = reader.GetInt32(0);
                lblWholeTotal.Text = data.ToString();
            }
            con.Close();
        }

        void CountTotalProfit()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemTotalPrice - SaleItemWholeTotal) from damayanthistoredb.tblsaleitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int data = reader.GetInt32(0);
                lblTotalProfit.Text = data.ToString();
            }
            con.Close();

            
        }

        // ***************** Serach From TextBox **********************//
        void CountGrandTotolSerachCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemTotalPrice) from damayanthistoredb.tblsaleitem WHERE SaleItemCode = '"+ txtItemCode.Text +"'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblGRandTotal.Text = data.ToString();


            }
            con.Close();
        }

        
        void CountTotalProfitSerachCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemTotalPrice - SaleItemWholeTotal) from damayanthistoredb.tblsaleitem WHERE SaleItemCode = '" + txtItemCode.Text + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblWholeTotal.Text = data.ToString();
            }
            con.Close();


        }
        void CountWholeTotoalSerachCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemWholeTotal) from damayanthistoredb.tblsaleitem WHERE SaleItemCode = '" + txtItemCode.Text + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblTotalProfit.Text = data.ToString();
            }
            con.Close();
        }


        // ***************** Serach From Date To Date **********************//
        void CountGrandTotolSerachDate()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemTotalPrice) from damayanthistoredb.tblsaleitem WHERE SaleDate BETWEEN '" + DateForm.Value.ToString() +
                                                "' AND '" + DateTo.Value.ToString() + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblGRandTotal.Text = data.ToString();
            }
            con.Close();
        }


        void CountTotalProfitSerachDate()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemTotalPrice - SaleItemWholeTotal) from damayanthistoredb.tblsaleitem WHERE SaleDate BETWEEN '" + DateForm.Value.ToString() +
                                                "' AND '" + DateTo.Value.ToString() + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblWholeTotal.Text = data.ToString();
            }
            con.Close();


        }
        void CountWholeTotoalSerachDate()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(SaleItemWholeTotal) from damayanthistoredb.tblsaleitem WHERE SaleDate BETWEEN '" + DateForm.Value.ToString() +
                                                "' AND '" + DateTo.Value.ToString() + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblTotalProfit.Text = data.ToString();
            }
            con.Close();
        }

       
    }

    
}
