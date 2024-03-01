namespace WindowsFormsApp1
{
    partial class AdminActivityLog
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
            this.adminActivityPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.adminActivityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminActivityPanel
            // 
            this.adminActivityPanel.Controls.Add(this.label1);
            this.adminActivityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminActivityPanel.Location = new System.Drawing.Point(0, 0);
            this.adminActivityPanel.Name = "adminActivityPanel";
            this.adminActivityPanel.Size = new System.Drawing.Size(1585, 655);
            this.adminActivityPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1199, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table from database  Admin Activity Log ";
            // 
            // AdminActivityLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 655);
            this.Controls.Add(this.adminActivityPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminActivityLog";
            this.Text = "AdminActivityLog";
            this.adminActivityPanel.ResumeLayout(false);
            this.adminActivityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminActivityPanel;
        private System.Windows.Forms.Label label1;
    }
}