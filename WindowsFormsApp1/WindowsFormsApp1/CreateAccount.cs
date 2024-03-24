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
    public partial class CreateAccount : Form
    {

        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6690575";
        public string mySqlServerPassword = "WzrG9YgeeE";
        public string mySqlDatabaseName = "sql6690575";

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (FName.Text == "" || LName.Text == "" || Username.Text == "" || Position.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                MySqlConnection connection = new MySqlConnection($"datasource={mySqlServerName};port=3306;username={mySqlServerUserId};password={mySqlServerPassword};database={mySqlDatabaseName}");

                
                connection.Open();

                
                string query = $"INSERT INTO employee_account (first_name, last_name, username_, position_, password_, date_created) VALUES (@FirstName, @LastName, @Username, @Position, @Password, NOW())";

                
                MySqlCommand command = new MySqlCommand(query, connection);

                
                command.Parameters.AddWithValue("@FirstName", FName.Text);
                command.Parameters.AddWithValue("@LastName", LName.Text);
                command.Parameters.AddWithValue("@Username", Username.Text);
                command.Parameters.AddWithValue("@Position", Position.Text);
                command.Parameters.AddWithValue("@Password", Password.Text);

               
                int rowsAffected = command.ExecuteNonQuery();

                
                connection.Close();

                
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        

        

        

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
