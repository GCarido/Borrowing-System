namespace WindowsFormsApp1
{
    partial class AdminInventory
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
            this.adminInventoryPanel = new System.Windows.Forms.Panel();
            this.addEquip = new System.Windows.Forms.Button();
            this.deleteEquip = new System.Windows.Forms.Button();
            this.updateEquip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adminInventoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminInventoryPanel
            // 
            this.adminInventoryPanel.Controls.Add(this.label1);
            this.adminInventoryPanel.Location = new System.Drawing.Point(0, -1);
            this.adminInventoryPanel.Name = "adminInventoryPanel";
            this.adminInventoryPanel.Size = new System.Drawing.Size(1586, 550);
            this.adminInventoryPanel.TabIndex = 0;
            // 
            // addEquip
            // 
            this.addEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEquip.Location = new System.Drawing.Point(591, 568);
            this.addEquip.Name = "addEquip";
            this.addEquip.Size = new System.Drawing.Size(118, 48);
            this.addEquip.TabIndex = 1;
            this.addEquip.Text = "Add";
            this.addEquip.UseVisualStyleBackColor = true;
            // 
            // deleteEquip
            // 
            this.deleteEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEquip.Location = new System.Drawing.Point(736, 568);
            this.deleteEquip.Name = "deleteEquip";
            this.deleteEquip.Size = new System.Drawing.Size(118, 48);
            this.deleteEquip.TabIndex = 2;
            this.deleteEquip.Text = "Delete";
            this.deleteEquip.UseVisualStyleBackColor = true;
            // 
            // updateEquip
            // 
            this.updateEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEquip.Location = new System.Drawing.Point(882, 567);
            this.updateEquip.Name = "updateEquip";
            this.updateEquip.Size = new System.Drawing.Size(118, 48);
            this.updateEquip.TabIndex = 3;
            this.updateEquip.Text = "Update";
            this.updateEquip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1135, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table at the database Admin Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 655);
            this.Controls.Add(this.updateEquip);
            this.Controls.Add(this.addEquip);
            this.Controls.Add(this.deleteEquip);
            this.Controls.Add(this.adminInventoryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInventory";
            this.Text = "AdminInventory";
            this.adminInventoryPanel.ResumeLayout(false);
            this.adminInventoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminInventoryPanel;
        private System.Windows.Forms.Button addEquip;
        private System.Windows.Forms.Button deleteEquip;
        private System.Windows.Forms.Button updateEquip;
        private System.Windows.Forms.Label label1;
    }
}