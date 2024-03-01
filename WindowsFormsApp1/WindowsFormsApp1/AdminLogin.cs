using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminLogin : Form
    {
        public static AdminLogin instance;
        public Button login;

        public AdminLogin()
        {
            InitializeComponent();
            instance = this;
            login = loginAdmin;
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
            this.loginpanel.Tag = f;
            f.Show();
        }

        private void linkStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new StaffLogin());
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            LoginPage.instance.Hide();
            AdminForm form2 = new AdminForm();
            form2.Show();
        }
    }
}
