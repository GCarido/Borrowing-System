using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class AdminLogin : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6690575";
        public string mySqlServerPassword = "WzrG9YgeeE";
        public string mySqlDatabaseName = "sql6690575";

        public static AdminLogin instance;
        public Button login;

        public AdminLogin()
        {
            InitializeComponent();
            instance = this;
            login = loginAdmin;
        }


        public void loadform(object Form)
        {
            if (this.loginpanel.Controls.Count > 1)
            {
                this.loginpanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.loginpanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.loginpanel.Tag = f;
            f.Show();
        }

        private void linkStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadform(new StaffLogin());
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminusertxtbox.Text == "" || adminpasstxtbox.Text == "")
                {
                    MessageBox.Show("Please input Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");
                string query = $"SELECT * FROM employee_account WHERE username_ = '{adminusertxtbox.Text}' AND password_ = '{adminpasstxtbox.Text}'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (table.Rows[0]["position_"].ToString() != "Admin")
                    {
                        MessageBox.Show("The account you tried to login is an admin account. Please sign in as admin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    LoginPage.instance.Hide();
                    AdminForm form2 = new AdminForm();
                    form2.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = loginAdmin;
        }
    }
}
