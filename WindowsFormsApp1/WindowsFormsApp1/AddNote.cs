using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddNote : Form
    {

        public static string Note { get; set; }

        public AddNote()
        {
            InitializeComponent();
        }

        private void submitNote_Click(object sender, EventArgs e)
        {
            if (noteTxtbox.Text == "")
            {
                if (MessageBox.Show("You have not added a note. Do you want to proceed?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Note = "No Note Added";
                    this.Hide();
                }
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to submit this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Note = noteTxtbox.Text;
                    this.Hide();
                }
            }
        }

        private void clearNote_Click(object sender, EventArgs e)
        {
            noteTxtbox.Text = "";
        }
    }
}
