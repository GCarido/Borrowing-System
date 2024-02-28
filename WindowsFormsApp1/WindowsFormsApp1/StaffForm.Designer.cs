﻿namespace WindowsFormsApp1
{
    partial class StaffForm
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
            this.dashBoard = new System.Windows.Forms.Button();
            this.borrowingPage = new System.Windows.Forms.Button();
            this.inventoryStaff = new System.Windows.Forms.Button();
            this.activityLog = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.activityLog);
            this.panel1.Controls.Add(this.inventoryStaff);
            this.panel1.Controls.Add(this.borrowingPage);
            this.panel1.Controls.Add(this.dashBoard);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 99);
            this.panel1.TabIndex = 0;
            // 
            // dashBoard
            // 
            this.dashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoard.Location = new System.Drawing.Point(49, 32);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(137, 33);
            this.dashBoard.TabIndex = 0;
            this.dashBoard.Text = "DashBoard";
            this.dashBoard.UseVisualStyleBackColor = true;
            // 
            // borrowingPage
            // 
            this.borrowingPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowingPage.Location = new System.Drawing.Point(360, 32);
            this.borrowingPage.Name = "borrowingPage";
            this.borrowingPage.Size = new System.Drawing.Size(120, 33);
            this.borrowingPage.TabIndex = 1;
            this.borrowingPage.Text = "Borrowing Page";
            this.borrowingPage.UseVisualStyleBackColor = true;
            // 
            // inventoryStaff
            // 
            this.inventoryStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryStaff.Location = new System.Drawing.Point(648, 33);
            this.inventoryStaff.Name = "inventoryStaff";
            this.inventoryStaff.Size = new System.Drawing.Size(121, 33);
            this.inventoryStaff.TabIndex = 2;
            this.inventoryStaff.Text = "Inventory";
            this.inventoryStaff.UseVisualStyleBackColor = true;
            // 
            // activityLog
            // 
            this.activityLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLog.Location = new System.Drawing.Point(903, 32);
            this.activityLog.Name = "activityLog";
            this.activityLog.Size = new System.Drawing.Size(183, 33);
            this.activityLog.TabIndex = 3;
            this.activityLog.Text = "Activity Log";
            this.activityLog.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 735);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inventoryStaff;
        private System.Windows.Forms.Button borrowingPage;
        private System.Windows.Forms.Button dashBoard;
        private System.Windows.Forms.Button activityLog;
        private System.Windows.Forms.Panel panel2;
    }
}