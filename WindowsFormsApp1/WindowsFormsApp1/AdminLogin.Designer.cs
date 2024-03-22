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
            this.adminpasstxtbox = new System.Windows.Forms.TextBox();
            this.adminusertxtbox = new System.Windows.Forms.TextBox();
            this.loginAdmin = new System.Windows.Forms.Button();
            this.linkStaff = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loginpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 524);
            this.panel1.TabIndex = 0;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login_Layer_3;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.adminpasstxtbox);
            this.loginpanel.Controls.Add(this.adminusertxtbox);
            this.loginpanel.Controls.Add(this.loginAdmin);
            this.loginpanel.Controls.Add(this.linkStaff);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(747, 524);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // adminpasstxtbox
            // 
            this.adminpasstxtbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminpasstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasstxtbox.Location = new System.Drawing.Point(195, 274);
            this.adminpasstxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminpasstxtbox.Name = "adminpasstxtbox";
            this.adminpasstxtbox.PasswordChar = '*';
            this.adminpasstxtbox.Size = new System.Drawing.Size(408, 34);
            this.adminpasstxtbox.TabIndex = 1;
            this.adminpasstxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminpasstxtbox_KeyDown);
            // 
            // adminusertxtbox
            // 
            this.adminusertxtbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminusertxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusertxtbox.Location = new System.Drawing.Point(185, 161);
            this.adminusertxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminusertxtbox.Name = "adminusertxtbox";
            this.adminusertxtbox.Size = new System.Drawing.Size(432, 34);
            this.adminusertxtbox.TabIndex = 0;
            this.adminusertxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminusertxtbox_KeyDown);
            // 
            // loginAdmin
            // 
            this.loginAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginAdmin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._431_1__1_;
            this.loginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAdmin.FlatAppearance.BorderSize = 0;
            this.loginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(97, 347);
            this.loginAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(575, 74);
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
            this.linkStaff.Location = new System.Drawing.Point(265, 457);
            this.linkStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkStaff.Name = "linkStaff";
            this.linkStaff.Size = new System.Drawing.Size(195, 31);
            this.linkStaff.TabIndex = 3;
            this.linkStaff.TabStop = true;
            this.linkStaff.Text = "Login as Staff?";
            this.linkStaff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStaff_LinkClicked);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}