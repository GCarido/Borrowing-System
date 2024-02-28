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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 1)
            {
                this.loginpanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.loginpanel.Controls.Add(f);
            this.loginpanel.Tag = f;
            f.Show();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new AdminLogin());
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
