namespace WindowsFormsApp1
{
    partial class StaffLogin
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.loginStaff = new System.Windows.Forms.Button();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.staffpasstxtbox = new System.Windows.Forms.TextBox();
            this.passwordstaff = new System.Windows.Forms.Label();
            this.usernamestaff = new System.Windows.Forms.Label();
            this.staffusertxtbox = new System.Windows.Forms.TextBox();
            this.logintext = new System.Windows.Forms.Label();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_221948;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.loginStaff);
            this.loginpanel.Controls.Add(this.linkAdmin);
            this.loginpanel.Controls.Add(this.staffpasstxtbox);
            this.loginpanel.Controls.Add(this.passwordstaff);
            this.loginpanel.Controls.Add(this.usernamestaff);
            this.loginpanel.Controls.Add(this.staffusertxtbox);
            this.loginpanel.Controls.Add(this.logintext);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(469, 360);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginStaff
            // 
            this.loginStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStaff.Location = new System.Drawing.Point(187, 250);
            this.loginStaff.Name = "loginStaff";
            this.loginStaff.Size = new System.Drawing.Size(90, 33);
            this.loginStaff.TabIndex = 5;
            this.loginStaff.Text = "LOGIN";
            this.loginStaff.UseVisualStyleBackColor = true;
            this.loginStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdmin.Location = new System.Drawing.Point(177, 302);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(117, 18);
            this.linkAdmin.TabIndex = 6;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Login as Admin?";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmin_LinkClicked);
            // 
            // staffpasstxtbox
            // 
            this.staffpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpasstxtbox.Location = new System.Drawing.Point(82, 196);
            this.staffpasstxtbox.Multiline = true;
            this.staffpasstxtbox.Name = "staffpasstxtbox";
            this.staffpasstxtbox.PasswordChar = '*';
            this.staffpasstxtbox.Size = new System.Drawing.Size(306, 30);
            this.staffpasstxtbox.TabIndex = 4;
            // 
            // passwordstaff
            // 
            this.passwordstaff.AutoSize = true;
            this.passwordstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordstaff.Location = new System.Drawing.Point(79, 177);
            this.passwordstaff.Name = "passwordstaff";
            this.passwordstaff.Size = new System.Drawing.Size(67, 16);
            this.passwordstaff.TabIndex = 2;
            this.passwordstaff.Text = "Password";
            // 
            // usernamestaff
            // 
            this.usernamestaff.AutoSize = true;
            this.usernamestaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamestaff.Location = new System.Drawing.Point(79, 105);
            this.usernamestaff.Name = "usernamestaff";
            this.usernamestaff.Size = new System.Drawing.Size(70, 16);
            this.usernamestaff.TabIndex = 1;
            this.usernamestaff.Text = "Username";
            // 
            // staffusertxtbox
            // 
            this.staffusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffusertxtbox.Location = new System.Drawing.Point(82, 124);
            this.staffusertxtbox.Multiline = true;
            this.staffusertxtbox.Name = "staffusertxtbox";
            this.staffusertxtbox.Size = new System.Drawing.Size(306, 30);
            this.staffusertxtbox.TabIndex = 3;
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
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 360);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffLogin";
            this.Text = "StaffLogin";
            this.Load += new System.EventHandler(this.StaffLogin_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button loginStaff;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.TextBox staffpasstxtbox;
        private System.Windows.Forms.Label passwordstaff;
        private System.Windows.Forms.Label usernamestaff;
        private System.Windows.Forms.TextBox staffusertxtbox;
        private System.Windows.Forms.Label logintext;
    }
}