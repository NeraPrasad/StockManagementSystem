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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountItem();
            CountTotalProfit();
            CountWholeTotoal();
           
        }

        
            
        

        void CountItem()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count( ItemCode) from damayanthistoredb.tblitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblNoItems.Text = reader.GetString(0);
            }
            con.Close();
        }

        void CountWholeTotoal()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(ItemWholePrice * ItemQuntity) from damayanthistoredb.tblitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
   
                int profit = reader.GetInt32(0);
                lblWholeTotal.Text = profit.ToString();
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
                int profit = reader.GetInt32(0);
                lblTotalProfit.Text = profit.ToString();
            }
            con.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lbtime.Text = dateTime.ToString();
        }
    }
}
