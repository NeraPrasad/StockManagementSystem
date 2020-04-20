using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadaviyaShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

           
        }
        private void Home_Load(object sender, EventArgs e)
        {
            manageItem1.Visible = false;
            orderItem1.Visible = false;
            stoke1.Visible = false;
            weastItem1.Visible = false;
            report1.Visible = false;
            setting1.Visible = false;
            dashboard1.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnHome.Height;
            pnlLeft.Top = btnHome.Top;

            manageItem1.Visible = false;
            orderItem1.Visible = false;
            stoke1.Visible = false;
            report1.Visible = false;
            weastItem1.Visible = false;
            dashboard1.Visible = true;
            setting1.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlLeft.Top = btnOrder.Top;
            pnlLeft.Height = btnOrder.Height;

            manageItem1.Visible = false;
            orderItem1.Visible = true;
            stoke1.Visible = false;
            weastItem1.Visible = false;
            report1.Visible = false;
            setting1.Visible = false;
            dashboard1.Visible = false;
        }

        private void btnStoke_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnStoke.Height;
            pnlLeft.Top = btnStoke.Top;

            manageItem1.Visible = false;
            orderItem1.Visible = false;
            stoke1.Visible = true;
            report1.Visible = false;
            weastItem1.Visible = false;
            dashboard1.Visible = false;
            setting1.Visible = false;
            
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnReport.Height;
            pnlLeft.Top = btnReport.Top;

            manageItem1.Visible = false;
            orderItem1.Visible = false;
            stoke1.Visible = false;
            report1.Visible = true;
            weastItem1.Visible = false;
            dashboard1.Visible = false;
            setting1.Visible = false;
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlLeft.Height = btnweast.Height;
            pnlLeft.Top = btnweast.Top;

            manageItem1.Visible = false;
            orderItem1.Visible = false;
            stoke1.Visible = false;
            report1.Visible = false;
            weastItem1.Visible = true;
            dashboard1.Visible = false;
            setting1.Visible = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            pnlLeft.Top = btnAddItem.Top;
            pnlLeft.Height = btnAddItem.Height;


            manageItem1.Visible = true;
            orderItem1.Visible = false;
            stoke1.Visible = false;
            report1.Visible = false;
            weastItem1.Visible = false;
            dashboard1.Visible = false;
            setting1.Visible = false;
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            manageItem1.Visible = false;
            orderItem1.Visible = false;
            stoke1.Visible = false;
            report1.Visible = false;
            weastItem1.Visible = false;
            dashboard1.Visible = false;
            setting1.Visible = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void report1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void lbtime_Click(object sender, EventArgs e)
        {

        }

        

        

        

        

      
    }
}
