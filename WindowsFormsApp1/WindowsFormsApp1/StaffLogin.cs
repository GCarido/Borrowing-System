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

namespace WindowsFormsApp1
{
    public partial class StaffLogin : Form
    {
        public string mySqlServerName = "localhost";
        public string mySqlServerUserId = "root";
        public string mySqlServerPassword = "Admin1234-";
        public string mySqlDatabaseName = "borrowsystem";

        public static StaffLogin instance;
        public Button login;

        public StaffLogin()
        {
            InitializeComponent();
            instance = this;
            login = loginStaff;
        }
        public void loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 1)
            {
                this.loginpanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.loginpanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           loadform(new AdminLogin());
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage.instance.Hide();
            StaffForm form2 = new StaffForm();
            form2.Show();
            
        }
    }
}
