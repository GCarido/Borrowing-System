namespace WindowsFormsApp1
{
    partial class AdminLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.unhideButton = new System.Windows.Forms.Button();
            this.adminpasstxtbox = new System.Windows.Forms.TextBox();
            this.adminusertxtbox = new System.Windows.Forms.TextBox();
            this.loginAdmin = new System.Windows.Forms.Button();
            this.linkStaff = new System.Windows.Forms.LinkLabel();
            this.hideButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 426);
            this.panel1.TabIndex = 0;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login_Layer_3__1_;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.unhideButton);
            this.loginpanel.Controls.Add(this.adminpasstxtbox);
            this.loginpanel.Controls.Add(this.adminusertxtbox);
            this.loginpanel.Controls.Add(this.loginAdmin);
            this.loginpanel.Controls.Add(this.linkStaff);
            this.loginpanel.Controls.Add(this.hideButton);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(560, 426);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // unhideButton
            // 
            this.unhideButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.eye;
            this.unhideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unhideButton.FlatAppearance.BorderSize = 0;
            this.unhideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unhideButton.Location = new System.Drawing.Point(441, 218);
            this.unhideButton.Name = "unhideButton";
            this.unhideButton.Size = new System.Drawing.Size(47, 35);
            this.unhideButton.TabIndex = 4;
            this.unhideButton.UseVisualStyleBackColor = true;
            this.unhideButton.Click += new System.EventHandler(this.unhideButton_Click);
            // 
            // adminpasstxtbox
            // 
            this.adminpasstxtbox.AcceptsReturn = true;
            this.adminpasstxtbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminpasstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasstxtbox.Location = new System.Drawing.Point(146, 223);
            this.adminpasstxtbox.Name = "adminpasstxtbox";
            this.adminpasstxtbox.Size = new System.Drawing.Size(306, 28);
            this.adminpasstxtbox.TabIndex = 1;
            this.adminpasstxtbox.TextChanged += new System.EventHandler(this.adminpasstxtbox_TextChanged);
            this.adminpasstxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminpasstxtbox_KeyDown);
            // 
            // adminusertxtbox
            // 
            this.adminusertxtbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminusertxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusertxtbox.Location = new System.Drawing.Point(139, 131);
            this.adminusertxtbox.Name = "adminusertxtbox";
            this.adminusertxtbox.Size = new System.Drawing.Size(324, 28);
            this.adminusertxtbox.TabIndex = 0;
            this.adminusertxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminusertxtbox_KeyDown);
            // 
            // loginAdmin
            // 
            this.loginAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginAdmin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_24_131009;
            this.loginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAdmin.FlatAppearance.BorderSize = 0;
            this.loginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(73, 282);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(431, 60);
            this.loginAdmin.TabIndex = 2;
            this.loginAdmin.Text = "LOGIN";
            this.loginAdmin.UseVisualStyleBackColor = false;
            this.loginAdmin.Click += new System.EventHandler(this.loginAdmin_Click);
            // 
            // linkStaff
            // 
            this.linkStaff.AutoSize = true;
            this.linkStaff.BackColor = System.Drawing.Color.Transparent;
            this.linkStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStaff.LinkColor = System.Drawing.Color.White;
            this.linkStaff.Location = new System.Drawing.Point(215, 371);
            this.linkStaff.Name = "linkStaff";
            this.linkStaff.Size = new System.Drawing.Size(156, 25);
            this.linkStaff.TabIndex = 3;
            this.linkStaff.TabStop = true;
            this.linkStaff.Text = "Login as Staff?";
            this.linkStaff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStaff_LinkClicked);
            // 
            // hideButton
            // 
            this.hideButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_22_204237;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Location = new System.Drawing.Point(441, 218);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(47, 35);
            this.hideButton.TabIndex = 7;
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.Text = "AdmiLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.panel1.ResumeLayout(false);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button loginAdmin;
        private System.Windows.Forms.LinkLabel linkStaff;
        private System.Windows.Forms.TextBox adminpasstxtbox;
        private System.Windows.Forms.TextBox adminusertxtbox;
        private System.Windows.Forms.Button unhideButton;
        private System.Windows.Forms.Button hideButton;
    }
}