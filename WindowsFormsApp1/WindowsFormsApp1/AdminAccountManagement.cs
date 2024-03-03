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
    public partial class AdminAccountManagement : Form
    {
        public AdminAccountManagement()
        {
            InitializeComponent();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            CreateAccount form = new CreateAccount();
            form.ShowDialog();
        }
    }
}
