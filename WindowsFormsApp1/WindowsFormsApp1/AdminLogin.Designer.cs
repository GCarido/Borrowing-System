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
            this.textBoxadmin2 = new System.Windows.Forms.TextBox();
            this.passwordadmin = new System.Windows.Forms.Label();
            this.usernameadmin = new System.Windows.Forms.Label();
            this.textBoxAdmin1 = new System.Windows.Forms.TextBox();
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
            this.loginpanel.Controls.Add(this.loginAdmin);
            this.loginpanel.Controls.Add(this.linkStaff);
            this.loginpanel.Controls.Add(this.textBoxadmin2);
            this.loginpanel.Controls.Add(this.passwordadmin);
            this.loginpanel.Controls.Add(this.usernameadmin);
            this.loginpanel.Controls.Add(this.textBoxAdmin1);
            this.loginpanel.Controls.Add(this.logintext);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(469, 360);
            this.loginpanel.TabIndex = 2;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginAdmin
            // 
            this.loginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAdmin.Location = new System.Drawing.Point(187, 250);
            this.loginAdmin.Name = "loginAdmin";
            this.loginAdmin.Size = new System.Drawing.Size(90, 33);
            this.loginAdmin.TabIndex = 7;
            this.loginAdmin.Text = "LOGIN";
            this.loginAdmin.UseVisualStyleBackColor = true;
            // 
            // linkStaff
            // 
            this.linkStaff.AutoSize = true;
            this.linkStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStaff.Location = new System.Drawing.Point(183, 302);
            this.linkStaff.Name = "linkStaff";
            this.linkStaff.Size = new System.Drawing.Size(106, 18);
            this.linkStaff.TabIndex = 6;
            this.linkStaff.TabStop = true;
            this.linkStaff.Text = "Login as Staff?";
            this.linkStaff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStaff_LinkClicked);
            // 
            // textBoxadmin2
            // 
            this.textBoxadmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxadmin2.Location = new System.Drawing.Point(82, 196);
            this.textBoxadmin2.Multiline = true;
            this.textBoxadmin2.Name = "textBoxadmin2";
            this.textBoxadmin2.Size = new System.Drawing.Size(306, 30);
            this.textBoxadmin2.TabIndex = 3;
            // 
            // passwordadmin
            // 
            this.passwordadmin.AutoSize = true;
            this.passwordadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordadmin.Location = new System.Drawing.Point(79, 177);
            this.passwordadmin.Name = "passwordadmin";
            this.passwordadmin.Size = new System.Drawing.Size(67, 16);
            this.passwordadmin.TabIndex = 4;
            this.passwordadmin.Text = "Password";
            // 
            // usernameadmin
            // 
            this.usernameadmin.AutoSize = true;
            this.usernameadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameadmin.Location = new System.Drawing.Point(79, 105);
            this.usernameadmin.Name = "usernameadmin";
            this.usernameadmin.Size = new System.Drawing.Size(70, 16);
            this.usernameadmin.TabIndex = 5;
            this.usernameadmin.Text = "Username";
            // 
            // textBoxAdmin1
            // 
            this.textBoxAdmin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdmin1.Location = new System.Drawing.Point(82, 124);
            this.textBoxAdmin1.Multiline = true;
            this.textBoxAdmin1.Name = "textBoxAdmin1";
            this.textBoxAdmin1.Size = new System.Drawing.Size(306, 30);
            this.textBoxAdmin1.TabIndex = 3;
            // 
            // logintext
            // 
            this.logintext.AutoSize = true;
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintext.ForeColor = System.Drawing.Color.MediumBlue;
            this.logintext.Location = new System.Drawing.Point(159, 25);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(142, 55);
            this.logintext.TabIndex = 4;
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
        private System.Windows.Forms.TextBox textBoxadmin2;
        private System.Windows.Forms.Label passwordadmin;
        private System.Windows.Forms.Label usernameadmin;
        private System.Windows.Forms.TextBox textBoxAdmin1;
        private System.Windows.Forms.Label logintext;
    }
}