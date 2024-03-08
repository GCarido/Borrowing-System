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
        Image initialImage = Properties.Resources.settings1;
        Image clickedImage = Properties.Resources.return1;

        private bool sidebarExpand;
        private bool isImageChanged;

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

        private void adminFormPanel_Paint(object sender, PaintEventArgs e)
        {
            loadform(new DashBoard());
        }

        private void dashBoard_Click(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }

        private void borrowingPage_Click(object sender, EventArgs e)
        {
            loadform(new BorrowingPage());
        }

        private void inventoryAdmin_Click(object sender, EventArgs e)
        {
            loadform(new AdminInventory());
        }

        private void activityLogAdmin_Click(object sender, EventArgs e)
        {
           loadform(new AdminActivityLog());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void accManagement_Click(object sender, EventArgs e)
        {
            loadform(new AdminAccountManagement());
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sidebarAnim_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarAnim.Stop();
                }
            }
            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarAnim.Stop();
                }
            }
        }

        private void props2_Click(object sender, EventArgs e)
        {
            sidebarAnim.Start();

            if (isImageChanged)
            {
                props2.BackColor = SystemColors.Control;
                props2.Image = initialImage;
            }
            else
            {
                props2.BackColor = Color.FromArgb(0, 3, 71);
                props2.Image = clickedImage;
            }

            isImageChanged = !isImageChanged;
        }
    }
}
