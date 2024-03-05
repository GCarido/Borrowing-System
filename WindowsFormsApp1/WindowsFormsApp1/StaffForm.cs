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
    public partial class StaffForm : Form
    {
        Image initialImage = Properties.Resources.settings1;
        Image clickedImage = Properties.Resources.return1;

        private bool sidebarExpand;
        private bool isImageChanged;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
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

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dashBoard_Click(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }

        private void borrowingPage_Click(object sender, EventArgs e)
        {
            loadform(new BorrowingPage());
        }

        private void activityLog_Click(object sender, EventArgs e)
        {
            loadform(new StaffActiivityLog());
        }

        private void inventoryStaff_Click(object sender, EventArgs e)
        {
            loadform(new StaffInventory());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void staffFormPanel_Paint(object sender, PaintEventArgs e)
        {
            loadform(new DashBoard());
        }

        private void sidebarAnim_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarAnim.Stop();
                }
            }
            else
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarAnim.Stop();
                }
            }
        }

        private void props1_Click(object sender, EventArgs e)
        {
            sidebarAnim.Start();

            if (isImageChanged)
            {
                props1.BackColor = SystemColors.Control;
                props1.Image = initialImage;
            }
            else
            {
                props1.BackColor = Color.FromArgb(0, 3, 71);
                props1.Image = clickedImage;
            }

            isImageChanged = !isImageChanged; 
        }
    }
}
