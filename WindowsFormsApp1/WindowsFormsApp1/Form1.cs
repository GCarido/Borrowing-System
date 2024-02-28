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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 1)
            {
                this.loginpanel.Controls.RemoveAt(1);
            }

            Form f  = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.loginpanel.Controls.Add(f);
            this.loginpanel.Tag = f;
            f.Show();
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }   

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new AdminLogin());
        }
    }
}
