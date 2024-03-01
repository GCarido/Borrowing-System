namespace WindowsFormsApp1
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.button1 = new System.Windows.Forms.Button();
            this.activityLogAdmin = new System.Windows.Forms.Button();
            this.dashBoard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accManagement = new System.Windows.Forms.Button();
            this.borrowingPage = new System.Windows.Forms.Button();
            this.inventoryAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.free_user_icon_3296_thumb;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1489, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // activityLogAdmin
            // 
            this.activityLogAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activityLogAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLogAdmin.Location = new System.Drawing.Point(864, 28);
            this.activityLogAdmin.Name = "activityLogAdmin";
            this.activityLogAdmin.Size = new System.Drawing.Size(141, 33);
            this.activityLogAdmin.TabIndex = 3;
            this.activityLogAdmin.Text = "Activity Log";
            this.activityLogAdmin.UseVisualStyleBackColor = true;
            this.activityLogAdmin.Click += new System.EventHandler(this.activityLogAdmin_Click);
            // 
            // dashBoard
            // 
            this.dashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard.Location = new System.Drawing.Point(63, 28);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(137, 33);
            this.dashBoard.TabIndex = 0;
            this.dashBoard.Text = "DashBoard";
            this.dashBoard.UseVisualStyleBackColor = true;
            this.dashBoard.Click += new System.EventHandler(this.dashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_01_115444;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.accManagement);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.activityLogAdmin);
            this.panel1.Controls.Add(this.borrowingPage);
            this.panel1.Controls.Add(this.inventoryAdmin);
            this.panel1.Controls.Add(this.dashBoard);
            this.panel1.Location = new System.Drawing.Point(-3, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1591, 92);
            this.panel1.TabIndex = 4;
            // 
            // accManagement
            // 
            this.accManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accManagement.Location = new System.Drawing.Point(1109, 28);
            this.accManagement.Name = "accManagement";
            this.accManagement.Size = new System.Drawing.Size(234, 33);
            this.accManagement.TabIndex = 5;
            this.accManagement.Text = "Account Management";
            this.accManagement.UseVisualStyleBackColor = true;
            // 
            // borrowingPage
            // 
            this.borrowingPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowingPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingPage.Location = new System.Drawing.Point(316, 28);
            this.borrowingPage.Name = "borrowingPage";
            this.borrowingPage.Size = new System.Drawing.Size(172, 33);
            this.borrowingPage.TabIndex = 1;
            this.borrowingPage.Text = "Borrowing Page";
            this.borrowingPage.UseVisualStyleBackColor = true;
            this.borrowingPage.Click += new System.EventHandler(this.borrowingPage_Click);
            // 
            // inventoryAdmin
            // 
            this.inventoryAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryAdmin.Location = new System.Drawing.Point(609, 28);
            this.inventoryAdmin.Name = "inventoryAdmin";
            this.inventoryAdmin.Size = new System.Drawing.Size(121, 33);
            this.inventoryAdmin.TabIndex = 2;
            this.inventoryAdmin.Text = "Inventory";
            this.inventoryAdmin.UseVisualStyleBackColor = true;
            this.inventoryAdmin.Click += new System.EventHandler(this.inventoryAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_220032;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1587, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // adminFormPanel
            // 
            this.adminFormPanel.BackColor = System.Drawing.SystemColors.Control;
            this.adminFormPanel.Location = new System.Drawing.Point(0, 209);
            this.adminFormPanel.Name = "adminFormPanel";
            this.adminFormPanel.Size = new System.Drawing.Size(1585, 655);
            this.adminFormPanel.TabIndex = 5;
            this.adminFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminFormPanel_Paint);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminFormPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowing System for CPE [ADMIN]";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button activityLogAdmin;
        private System.Windows.Forms.Button dashBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button borrowingPage;
        private System.Windows.Forms.Button inventoryAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel adminFormPanel;
        private System.Windows.Forms.Button accManagement;
    }
}