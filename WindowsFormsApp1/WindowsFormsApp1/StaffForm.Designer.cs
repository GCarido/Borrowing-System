namespace WindowsFormsApp1
{
    partial class StaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.dashBoard = new System.Windows.Forms.Button();
            this.inventoryStaff = new System.Windows.Forms.Button();
            this.borrowingPage = new System.Windows.Forms.Button();
            this.activityLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.props1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.navbottom = new System.Windows.Forms.Panel();
            this.staffFormPanel = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.profilebtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebarAnim = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashBoard
            // 
            this.dashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard.Location = new System.Drawing.Point(0, 0);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(337, 72);
            this.dashBoard.TabIndex = 0;
            this.dashBoard.Text = "DashBoard";
            this.dashBoard.UseVisualStyleBackColor = true;
            this.dashBoard.Click += new System.EventHandler(this.dashBoard_Click);
            // 
            // inventoryStaff
            // 
            this.inventoryStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryStaff.Location = new System.Drawing.Point(0, 0);
            this.inventoryStaff.Name = "inventoryStaff";
            this.inventoryStaff.Size = new System.Drawing.Size(337, 72);
            this.inventoryStaff.TabIndex = 2;
            this.inventoryStaff.Text = "Inventory";
            this.inventoryStaff.UseVisualStyleBackColor = true;
            this.inventoryStaff.Click += new System.EventHandler(this.inventoryStaff_Click);
            // 
            // borrowingPage
            // 
            this.borrowingPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowingPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingPage.Location = new System.Drawing.Point(0, 0);
            this.borrowingPage.Name = "borrowingPage";
            this.borrowingPage.Size = new System.Drawing.Size(337, 72);
            this.borrowingPage.TabIndex = 1;
            this.borrowingPage.Text = "Borrowing Page";
            this.borrowingPage.UseVisualStyleBackColor = true;
            this.borrowingPage.Click += new System.EventHandler(this.borrowingPage_Click);
            // 
            // activityLog
            // 
            this.activityLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activityLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLog.Location = new System.Drawing.Point(0, 0);
            this.activityLog.Name = "activityLog";
            this.activityLog.Size = new System.Drawing.Size(337, 72);
            this.activityLog.TabIndex = 3;
            this.activityLog.Text = "Activity Log";
            this.activityLog.UseVisualStyleBackColor = true;
            this.activityLog.Click += new System.EventHandler(this.activityLog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.props1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(1348, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 72);
            this.panel6.TabIndex = 1;
            // 
            // props1
            // 
            this.props1.BackColor = System.Drawing.SystemColors.Window;
            this.props1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_user_icon_3296_thumb;
            this.props1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.props1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.props1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.props1.FlatAppearance.BorderSize = 0;
            this.props1.Location = new System.Drawing.Point(10, 6);
            this.props1.Margin = new System.Windows.Forms.Padding(0);
            this.props1.Name = "props1";
            this.props1.Size = new System.Drawing.Size(75, 61);
            this.props1.TabIndex = 4;
            this.props1.UseVisualStyleBackColor = false;
            this.props1.Click += new System.EventHandler(this.props1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.activityLog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(1011, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 72);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inventoryStaff);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(674, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 72);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.borrowingPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(337, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 72);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 72);
            this.panel2.TabIndex = 0;
            // 
            // navbottom
            // 
            this.navbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.navbottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbottom.Location = new System.Drawing.Point(0, 202);
            this.navbottom.Name = "navbottom";
            this.navbottom.Size = new System.Drawing.Size(1443, 2);
            this.navbottom.TabIndex = 1;
            // 
            // staffFormPanel
            // 
            this.staffFormPanel.BackColor = System.Drawing.SystemColors.Control;
            this.staffFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffFormPanel.Location = new System.Drawing.Point(0, 204);
            this.staffFormPanel.Name = "staffFormPanel";
            this.staffFormPanel.Size = new System.Drawing.Size(1443, 653);
            this.staffFormPanel.TabIndex = 2;
            this.staffFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.staffFormPanel_Paint);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Location = new System.Drawing.Point(1443, 204);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(161, 653);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(0, 653);
            this.sidebar.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(2, 2);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(161, 653);
            this.panel10.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.logoutbtn);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 563);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(161, 70);
            this.panel14.TabIndex = 7;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutbtn.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(0, 0);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.logoutbtn.Size = new System.Drawing.Size(161, 70);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 633);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(161, 20);
            this.panel13.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.aboutbtn);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 147);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(161, 70);
            this.panel12.TabIndex = 5;
            // 
            // aboutbtn
            // 
            this.aboutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutbtn.FlatAppearance.BorderSize = 0;
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutbtn.Image = global::WindowsFormsApp1.Properties.Resources.about1;
            this.aboutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbtn.Location = new System.Drawing.Point(0, 0);
            this.aboutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.aboutbtn.Size = new System.Drawing.Size(161, 70);
            this.aboutbtn.TabIndex = 1;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 139);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(161, 8);
            this.panel11.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.profilebtn);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 69);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(161, 70);
            this.panel9.TabIndex = 4;
            // 
            // profilebtn
            // 
            this.profilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilebtn.FlatAppearance.BorderSize = 0;
            this.profilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilebtn.Image = global::WindowsFormsApp1.Properties.Resources.profile;
            this.profilebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profilebtn.Location = new System.Drawing.Point(0, 0);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.profilebtn.Size = new System.Drawing.Size(161, 70);
            this.profilebtn.TabIndex = 1;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 61);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(161, 8);
            this.panel8.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.settingsbtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(161, 61);
            this.panel7.TabIndex = 2;
            // 
            // settingsbtn
            // 
            this.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsbtn.Image = global::WindowsFormsApp1.Properties.Resources.settings1s;
            this.settingsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbtn.Location = new System.Drawing.Point(0, 0);
            this.settingsbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.settingsbtn.Size = new System.Drawing.Size(161, 61);
            this.settingsbtn.TabIndex = 1;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_220032;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1443, 130);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebarAnim
            // 
            this.sidebarAnim.Enabled = true;
            this.sidebarAnim.Interval = 10;
            this.sidebarAnim.Tick += new System.EventHandler(this.sidebarAnim_Tick);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.staffFormPanel);
            this.Controls.Add(this.navbottom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing System for CPE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashBoard;
        private System.Windows.Forms.Button inventoryStaff;
        private System.Windows.Forms.Button borrowingPage;
        private System.Windows.Forms.Button activityLog;
        private System.Windows.Forms.Button props1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navbottom;
        private System.Windows.Forms.Panel staffFormPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Timer sidebarAnim;
    }
}