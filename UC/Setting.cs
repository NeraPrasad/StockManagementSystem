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
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
             
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string file = "E:\\backup\\backup.sql";
            string cs = "server=localhost;userid=root;password=;database=damayanthistoredb;";

            using (MySqlConnection con = new MySqlConnection(cs))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = con;
                        con.Open();
                        mb.ExportToFile(file);
                        con.Close();
                        MessageBox.Show("Backup Completed..!");
                    }
                }
                
            }
        }
    }
}
