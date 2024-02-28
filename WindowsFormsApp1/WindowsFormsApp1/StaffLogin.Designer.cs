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
            this.textBoxstaff2 = new System.Windows.Forms.TextBox();
            this.passwordstaff = new System.Windows.Forms.Label();
            this.usernamestaff = new System.Windows.Forms.Label();
            this.textBoxstaff1 = new System.Windows.Forms.TextBox();
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
            this.loginpanel.Controls.Add(this.textBoxstaff2);
            this.loginpanel.Controls.Add(this.passwordstaff);
            this.loginpanel.Controls.Add(this.usernamestaff);
            this.loginpanel.Controls.Add(this.textBoxstaff1);
            this.loginpanel.Controls.Add(this.logintext);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(625, 443);
            this.loginpanel.TabIndex = 2;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginStaff
            // 
            this.loginStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStaff.Location = new System.Drawing.Point(249, 308);
            this.loginStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginStaff.Name = "loginStaff";
            this.loginStaff.Size = new System.Drawing.Size(120, 41);
            this.loginStaff.TabIndex = 7;
            this.loginStaff.Text = "LOGIN";
            this.loginStaff.UseVisualStyleBackColor = true;
            this.loginStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdmin.Location = new System.Drawing.Point(236, 372);
            this.linkAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(151, 24);
            this.linkAdmin.TabIndex = 6;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Login as Admin?";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmin_LinkClicked);
            // 
            // textBoxstaff2
            // 
            this.textBoxstaff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstaff2.Location = new System.Drawing.Point(109, 241);
            this.textBoxstaff2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxstaff2.Multiline = true;
            this.textBoxstaff2.Name = "textBoxstaff2";
            this.textBoxstaff2.Size = new System.Drawing.Size(407, 36);
            this.textBoxstaff2.TabIndex = 3;
            // 
            // passwordstaff
            // 
            this.passwordstaff.AutoSize = true;
            this.passwordstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordstaff.Location = new System.Drawing.Point(105, 218);
            this.passwordstaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordstaff.Name = "passwordstaff";
            this.passwordstaff.Size = new System.Drawing.Size(83, 20);
            this.passwordstaff.TabIndex = 4;
            this.passwordstaff.Text = "Password";
            // 
            // usernamestaff
            // 
            this.usernamestaff.AutoSize = true;
            this.usernamestaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamestaff.Location = new System.Drawing.Point(105, 129);
            this.usernamestaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamestaff.Name = "usernamestaff";
            this.usernamestaff.Size = new System.Drawing.Size(86, 20);
            this.usernamestaff.TabIndex = 5;
            this.usernamestaff.Text = "Username";
            // 
            // textBoxstaff1
            // 
            this.textBoxstaff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstaff1.Location = new System.Drawing.Point(109, 153);
            this.textBoxstaff1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxstaff1.Multiline = true;
            this.textBoxstaff1.Name = "textBoxstaff1";
            this.textBoxstaff1.Size = new System.Drawing.Size(407, 36);
            this.textBoxstaff1.TabIndex = 3;
            // 
            // logintext
            // 
            this.logintext.AutoSize = true;
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintext.ForeColor = System.Drawing.Color.MediumBlue;
            this.logintext.Location = new System.Drawing.Point(212, 31);
            this.logintext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(176, 69);
            this.logintext.TabIndex = 4;
            this.logintext.Text = "Login";
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffLogin";
            this.Text = "StaffLogin";
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Button loginStaff;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.TextBox textBoxstaff2;
        private System.Windows.Forms.Label passwordstaff;
        private System.Windows.Forms.Label usernamestaff;
        private System.Windows.Forms.TextBox textBoxstaff1;
        private System.Windows.Forms.Label logintext;
    }
}