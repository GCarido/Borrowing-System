namespace WindowsFormsApp1
{
    partial class AdminAccountManagement
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
            this.accountManagementPanel = new System.Windows.Forms.Panel();
            this.createAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountManagementPanel
            // 
            this.accountManagementPanel.Location = new System.Drawing.Point(-1, -1);
            this.accountManagementPanel.Name = "accountManagementPanel";
            this.accountManagementPanel.Size = new System.Drawing.Size(1571, 513);
            this.accountManagementPanel.TabIndex = 0;
            // 
            // createAccount
            // 
            this.createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.Location = new System.Drawing.Point(724, 542);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(127, 37);
            this.createAccount.TabIndex = 1;
            this.createAccount.Text = "Create";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // AdminAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 616);
            this.Controls.Add(this.createAccount);
            this.Controls.Add(this.accountManagementPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAccountManagement";
            this.Text = "AdminAccountManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel accountManagementPanel;
        private System.Windows.Forms.Button createAccount;
    }
}