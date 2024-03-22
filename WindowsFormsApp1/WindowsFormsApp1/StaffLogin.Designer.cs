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
            this.staffusertxtbox = new System.Windows.Forms.TextBox();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Login_Layer_3;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.loginStaff);
            this.loginpanel.Controls.Add(this.linkAdmin);
            this.loginpanel.Controls.Add(this.staffpasstxtbox);
            this.loginpanel.Controls.Add(this.staffusertxtbox);
            this.loginpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(560, 426);
            this.loginpanel.TabIndex = 0;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // loginStaff
            // 
            this.loginStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginStaff.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._431_1__1_;
            this.loginStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginStaff.FlatAppearance.BorderSize = 0;
            this.loginStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginStaff.ForeColor = System.Drawing.Color.Black;
            this.loginStaff.Location = new System.Drawing.Point(73, 282);
            this.loginStaff.Name = "loginStaff";
            this.loginStaff.Size = new System.Drawing.Size(431, 60);
            this.loginStaff.TabIndex = 5;
            this.loginStaff.Text = "LOGIN";
            this.loginStaff.UseVisualStyleBackColor = false;
            this.loginStaff.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.linkAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdmin.Location = new System.Drawing.Point(199, 371);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(172, 25);
            this.linkAdmin.TabIndex = 6;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Login as Admin?";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdmin_LinkClicked);
            // 
            // staffpasstxtbox
            // 
            this.staffpasstxtbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staffpasstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffpasstxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpasstxtbox.Location = new System.Drawing.Point(146, 223);
            this.staffpasstxtbox.Multiline = true;
            this.staffpasstxtbox.Name = "staffpasstxtbox";
            this.staffpasstxtbox.PasswordChar = '*';
            this.staffpasstxtbox.Size = new System.Drawing.Size(324, 26);
            this.staffpasstxtbox.TabIndex = 4;
            // 
            // staffusertxtbox
            // 
            this.staffusertxtbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staffusertxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffusertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffusertxtbox.Location = new System.Drawing.Point(139, 131);
            this.staffusertxtbox.Multiline = true;
            this.staffusertxtbox.Name = "staffusertxtbox";
            this.staffusertxtbox.Size = new System.Drawing.Size(324, 26);
            this.staffusertxtbox.TabIndex = 3;
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
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
        private System.Windows.Forms.TextBox staffusertxtbox;
    }
}