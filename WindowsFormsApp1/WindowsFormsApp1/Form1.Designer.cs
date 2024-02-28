namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.linkAdmin = new System.Windows.Forms.LinkLabel();
            this.textBoxstaff2 = new System.Windows.Forms.TextBox();
            this.passwordstaff = new System.Windows.Forms.Label();
            this.usernamestaff = new System.Windows.Forms.Label();
            this.textBoxstaff1 = new System.Windows.Forms.TextBox();
            this.logintext = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_220032;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1587, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginpanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_02_19_221948;
            this.loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginpanel.Controls.Add(this.button1);
            this.loginpanel.Controls.Add(this.linkAdmin);
            this.loginpanel.Controls.Add(this.textBoxstaff2);
            this.loginpanel.Controls.Add(this.passwordstaff);
            this.loginpanel.Controls.Add(this.usernamestaff);
            this.loginpanel.Controls.Add(this.textBoxstaff1);
            this.loginpanel.Controls.Add(this.logintext);
            this.loginpanel.Location = new System.Drawing.Point(578, 275);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(469, 360);
            this.loginpanel.TabIndex = 1;
            this.loginpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginpanel_Paint);
            // 
            // linkAdmin
            // 
            this.linkAdmin.AutoSize = true;
            this.linkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdmin.Location = new System.Drawing.Point(177, 302);
            this.linkAdmin.Name = "linkAdmin";
            this.linkAdmin.Size = new System.Drawing.Size(117, 18);
            this.linkAdmin.TabIndex = 6;
            this.linkAdmin.TabStop = true;
            this.linkAdmin.Text = "Login as Admin?";
            this.linkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxstaff2
            // 
            this.textBoxstaff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstaff2.Location = new System.Drawing.Point(82, 196);
            this.textBoxstaff2.Multiline = true;
            this.textBoxstaff2.Name = "textBoxstaff2";
            this.textBoxstaff2.Size = new System.Drawing.Size(306, 30);
            this.textBoxstaff2.TabIndex = 3;
            // 
            // passwordstaff
            // 
            this.passwordstaff.AutoSize = true;
            this.passwordstaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordstaff.Location = new System.Drawing.Point(79, 177);
            this.passwordstaff.Name = "passwordstaff";
            this.passwordstaff.Size = new System.Drawing.Size(67, 16);
            this.passwordstaff.TabIndex = 4;
            this.passwordstaff.Text = "Password";
            // 
            // usernamestaff
            // 
            this.usernamestaff.AutoSize = true;
            this.usernamestaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamestaff.Location = new System.Drawing.Point(79, 105);
            this.usernamestaff.Name = "usernamestaff";
            this.usernamestaff.Size = new System.Drawing.Size(70, 16);
            this.usernamestaff.TabIndex = 5;
            this.usernamestaff.Text = "Username";
            // 
            // textBoxstaff1
            // 
            this.textBoxstaff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstaff1.Location = new System.Drawing.Point(82, 124);
            this.textBoxstaff1.Multiline = true;
            this.textBoxstaff1.Name = "textBoxstaff1";
            this.textBoxstaff1.Size = new System.Drawing.Size(306, 30);
            this.textBoxstaff1.TabIndex = 3;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxstaff1;
        private System.Windows.Forms.Label logintext;
        private System.Windows.Forms.TextBox textBoxstaff2;
        private System.Windows.Forms.Label usernamestaff;
        private System.Windows.Forms.Label passwordstaff;
        private System.Windows.Forms.LinkLabel linkAdmin;
        private System.Windows.Forms.Button button1;
    }
}

