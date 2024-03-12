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
            this.loginAdmin = new System.Windows.Forms.Button();
            this.linkStaff = new System.Windows.Forms.LinkLabel();
            this.adminpasstxtbox = new System.Windows.Forms.TextBox();
            this.passwordadmin = new System.Windows.Forms.Label();
            this.usernameadmin = new System.Windows.Forms.Label();
            this.adminusertxtbox = new System.Windows.Forms.TextBox();
            this.logintext = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(469, 360);
            this.panel1.TabIndex = 0;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_221948;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.adminpasstxtbox);
            this.loginpanel.Controls.Add(this.adminusertxtbox);
            this.loginpanel.Controls.Add(this.loginAdmin);
            this.loginpanel.Controls.Add(this.linkStaff);
            this.loginpanel.Controls.Add(this.passwordadmin);
            this.loginpanel.Controls.Add(this.usernameadmin);
            this.loginpanel.Controls.Add(this.logintext);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(469, 360);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginAdmin
            // 
            this.loginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(187, 250);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(90, 33);
            this.loginAdmin.TabIndex = 5;
            this.loginAdmin.Text = "LOGIN";
            this.loginAdmin.UseVisualStyleBackColor = true;
            this.loginAdmin.Click += new System.EventHandler(this.loginAdmin_Click);
            // 
            // linkStaff
            // 
            this.linkStaff.AutoSize = true;
            this.linkStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStaff.Location = new System.Drawing.Point(183, 302);
            this.linkStaff.Name = "linkStaff";
            this.linkStaff.Size = new System.Drawing.Size(106, 18);
            this.linkStaff.TabIndex = 6;
            this.linkStaff.TabStop = true;
            this.linkStaff.Text = "Login as Staff?";
            this.linkStaff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStaff_LinkClicked);
            // 
            // adminpasstxtbox
            // 
            this.adminpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpasstxtbox.Location = new System.Drawing.Point(82, 196);
            this.adminpasstxtbox.Multiline = true;
            this.adminpasstxtbox.Name = "adminpasstxtbox";
            this.adminpasstxtbox.PasswordChar = '*';
            this.adminpasstxtbox.Size = new System.Drawing.Size(306, 30);
            this.adminpasstxtbox.TabIndex = 4;
            // 
            // passwordadmin
            // 
            this.passwordadmin.AutoSize = true;
            this.passwordadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordadmin.Location = new System.Drawing.Point(79, 177);
            this.passwordadmin.Name = "passwordadmin";
            this.passwordadmin.Size = new System.Drawing.Size(67, 16);
            this.passwordadmin.TabIndex = 2;
            this.passwordadmin.Text = "Password";
            // 
            // usernameadmin
            // 
            this.usernameadmin.AutoSize = true;
            this.usernameadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameadmin.Location = new System.Drawing.Point(79, 105);
            this.usernameadmin.Name = "usernameadmin";
            this.usernameadmin.Size = new System.Drawing.Size(70, 16);
            this.usernameadmin.TabIndex = 1;
            this.usernameadmin.Text = "Username";
            // 
            // adminusertxtbox
            // 
            this.adminusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminusertxtbox.Location = new System.Drawing.Point(82, 124);
            this.adminusertxtbox.Multiline = true;
            this.adminusertxtbox.Name = "adminusertxtbox";
            this.adminusertxtbox.Size = new System.Drawing.Size(306, 30);
            this.adminusertxtbox.TabIndex = 3;
            // 
            // logintext
            // 
            this.logintext.AutoSize = true;
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintext.ForeColor = System.Drawing.Color.MediumBlue;
            this.logintext.Location = new System.Drawing.Point(159, 25);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(142, 55);
            this.logintext.TabIndex = 0;
            this.logintext.Text = "Login";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 360);
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
        private System.Windows.Forms.Label passwordadmin;
        private System.Windows.Forms.Label usernameadmin;
        private System.Windows.Forms.TextBox adminusertxtbox;
        private System.Windows.Forms.Label logintext;
    }
}