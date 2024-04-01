namespace WindowsFormsApp1
{
    partial class AddNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.submitNote = new System.Windows.Forms.Button();
            this.noteTxtbox = new System.Windows.Forms.TextBox();
            this.clearNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a Note (You may leave it blank)";
            // 
            // submitNote
            // 
            this.submitNote.Location = new System.Drawing.Point(41, 189);
            this.submitNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitNote.Name = "submitNote";
            this.submitNote.Size = new System.Drawing.Size(83, 26);
            this.submitNote.TabIndex = 1;
            this.submitNote.Text = "Submit";
            this.submitNote.UseVisualStyleBackColor = true;
            this.submitNote.Click += new System.EventHandler(this.submitNote_Click);
            // 
            // noteTxtbox
            // 
            this.noteTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTxtbox.Location = new System.Drawing.Point(41, 92);
            this.noteTxtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noteTxtbox.MaxLength = 250;
            this.noteTxtbox.Multiline = true;
            this.noteTxtbox.Name = "noteTxtbox";
            this.noteTxtbox.Size = new System.Drawing.Size(415, 82);
            this.noteTxtbox.TabIndex = 2;
            // 
            // clearNote
            // 
            this.clearNote.Location = new System.Drawing.Point(140, 189);
            this.clearNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearNote.Name = "clearNote";
            this.clearNote.Size = new System.Drawing.Size(83, 26);
            this.clearNote.TabIndex = 3;
            this.clearNote.Text = "Clear";
            this.clearNote.UseVisualStyleBackColor = true;
            this.clearNote.Click += new System.EventHandler(this.clearNote_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 263);
            this.Controls.Add(this.clearNote);
            this.Controls.Add(this.noteTxtbox);
            this.Controls.Add(this.submitNote);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitNote;
        private System.Windows.Forms.TextBox noteTxtbox;
        private System.Windows.Forms.Button clearNote;
    }
}