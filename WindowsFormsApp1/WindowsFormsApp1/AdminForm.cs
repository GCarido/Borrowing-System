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
    public partial class AdminForm : Form
    {

        private bool sidebarExpand;
        private bool _dragging = false;
        private Point _start_point = new Point(1, 0);

        public AdminForm()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.adminFormPanel.Controls.Count > 1)
            {
                this.adminFormPanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.adminFormPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.adminFormPanel.Tag = f;
            f.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            userlbl.Text = AdminLogin.Username;
            idlbl.Text = AdminLogin.EmployeeID;
            poslbl.Text = AdminLogin.Position;
        }


        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void accManagement_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminAccountManagement());
        }
       
        private void sidebarContainer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarContainer.Stop();
                }
            }
            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarContainer.Stop();
                }
            }
        }
        private void menu_Click(object sender, EventArgs e)
        {
            sidebarContainer.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashBoard_Click_1(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }

        private void borrowingPage_Click_1(object sender, EventArgs e)
        {
            loadform(new BorrowingPage());
        }

        private void inventoryAdmin_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminInventory());
        }

        private void activityLogAdmin_Click_1(object sender, EventArgs e)
        {
            loadform(new AdminActivityLog());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void AdminForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}
