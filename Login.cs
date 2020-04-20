using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PadaviyaShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forget = new ForgetPass();
            forget.Show();
            this.Hide();
        }

        private void btnPrintSave_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb;";

            int i = 0;

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM damayanthistoredb.tbladmin WHERE userId='" + txtUserID.Text + "' and userPass='" + txtPassword.Text + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Does Not match");
            }
            else
            {
                Home a = new Home();
                a.Show();
                this.Hide();
            }
        }
    }
}
