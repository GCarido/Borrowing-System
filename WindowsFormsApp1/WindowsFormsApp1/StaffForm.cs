using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class StaffForm : Form
    {
        private bool sidebarExpand;
        private bool _dragging = false;
        private Point _start_point = new Point(1, 0);

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            userlbl.Text = StaffLogin.Username;
            idlbl.Text = StaffLogin.EmployeeID;
            poslbl.Text = StaffLogin.Position;
        }


        private void staffFormPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void loadform(object Form)
        {
            if (this.staffFormPanel.Controls.Count > 1)
            {
                this.staffFormPanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.staffFormPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.staffFormPanel.Tag = f;
            f.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void dashBoard_Click_1(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }

        private void borrowingForm_Click(object sender, EventArgs e)
        {

        }

        private void staffInventory_Click(object sender, EventArgs e)
        {

        }

        private void staffTransaction_Click(object sender, EventArgs e)
        {

        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dashBoard_Click(object sender, EventArgs e)
        {
           loadform(new DashBoard());
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarContainer.Start();
        }

        private void StaffForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void StaffForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void StaffForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
