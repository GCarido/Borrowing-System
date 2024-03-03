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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashBoard = new System.Windows.Forms.Button();
            this.inventoryStaff = new System.Windows.Forms.Button();
            this.borrowingPage = new System.Windows.Forms.Button();
            this.activityLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navbottom = new System.Windows.Forms.Panel();
            this.staffFormPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_220032;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dashBoard
            // 
            this.dashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard.Location = new System.Drawing.Point(0, 0);
            this.dashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(449, 88);
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
            this.inventoryStaff.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryStaff.Name = "inventoryStaff";
            this.inventoryStaff.Size = new System.Drawing.Size(449, 88);
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
            this.borrowingPage.Margin = new System.Windows.Forms.Padding(4);
            this.borrowingPage.Name = "borrowingPage";
            this.borrowingPage.Size = new System.Drawing.Size(449, 88);
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
            this.activityLog.Margin = new System.Windows.Forms.Padding(4);
            this.activityLog.Name = "activityLog";
            this.activityLog.Size = new System.Drawing.Size(449, 88);
            this.activityLog.TabIndex = 3;
            this.activityLog.Text = "Activity Log";
            this.activityLog.UseVisualStyleBackColor = true;
            this.activityLog.Click += new System.EventHandler(this.activityLog_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_user_icon_3296_thumb;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(14, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 75);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 88);
            this.panel1.TabIndex = 0;
            // 
            // navbottom
            // 
            this.navbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(64)))));
            this.navbottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbottom.Location = new System.Drawing.Point(0, 248);
            this.navbottom.Margin = new System.Windows.Forms.Padding(4);
            this.navbottom.Name = "navbottom";
            this.navbottom.Size = new System.Drawing.Size(1924, 3);
            this.navbottom.TabIndex = 1;
            // 
            // staffFormPanel
            // 
            this.staffFormPanel.BackColor = System.Drawing.SystemColors.Control;
            this.staffFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffFormPanel.Location = new System.Drawing.Point(0, 251);
            this.staffFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.staffFormPanel.Name = "staffFormPanel";
            this.staffFormPanel.Size = new System.Drawing.Size(1924, 804);
            this.staffFormPanel.TabIndex = 2;
            this.staffFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.staffFormPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 88);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.borrowingPage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(449, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 88);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inventoryStaff);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(898, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 88);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.activityLog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(1347, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 88);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(1796, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(128, 88);
            this.panel6.TabIndex = 1;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.staffFormPanel);
            this.Controls.Add(this.navbottom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing System for CPE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashBoard;
        private System.Windows.Forms.Button inventoryStaff;
        private System.Windows.Forms.Button borrowingPage;
        private System.Windows.Forms.Button activityLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navbottom;
        private System.Windows.Forms.Panel staffFormPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}