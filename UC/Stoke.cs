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
    public partial class Stoke : UserControl
    {
        string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
        public Stoke()
        {
            InitializeComponent();
        }

        private void Stoke_Load(object sender, EventArgs e)
        {
            ShowD();
            CountWholeTotoal();
            CountItem();

        }

     

        void ShowD()
        {
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT ItemCode, ItemName, ItemWholePrice, ItemRentalPrice, ItemQuntity FROM damayanthistoredb.tblitem ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dvgStokes.DataSource = dt;
            }
        }

        
     

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(cs);
            MySqlCommand cmd = new MySqlCommand();

            string query = "SELECT * FROM damayanthistoredb.tblitem  WHERE ItemCode= @ItemCode";
            cmd.CommandText = query;
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@ItemCode", txtItemCode.Text);

            DataTable dl = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dl);
            con.Close();
            dvgStokes.DataSource = dl;

            CountWholeTotolCode();
            CountItemCode();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowD();
            txtItemCode.Text = "";
            CountWholeTotoal();
            CountItemCode();
        }

        //***************** Default ***************//
        void CountWholeTotoal()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(ItemWholePrice * ItemQuntity) from damayanthistoredb.tblitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int data = reader.GetInt32(0);
                lblStokeTotal.Text = data.ToString();
            }
            con.Close();
        }

        void CountItem()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count(ItemCode) from damayanthistoredb.tblitem", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblNoItems.Text = reader.GetString(0);
            }
            con.Close();
        }


        //***************** Code ***************//
        void CountWholeTotolCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select sum(ItemWholePrice * ItemQuntity) from damayanthistoredb.tblitem WHERE ItemCode= '"+ txtItemCode.Text+"'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int data = reader.GetInt32(0);
                lblStokeTotal.Text = data.ToString();
            }
            con.Close();
        }

        void CountItemCode()
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb";
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count( ItemCode) from damayanthistoredb.tblitem WHERE ItemCode= '" + txtItemCode.Text + "'", con);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblNoItems.Text = reader.GetString(0);
            }
            con.Close();
        }
    }
}
