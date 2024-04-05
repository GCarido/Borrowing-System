using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class BorrowingPage : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6690575";
        public string mySqlServerPassword = "WzrG9YgeeE";
        public string mySqlDatabaseName = "sql6690575";

        public BorrowingPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void borrowerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepandYL_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjetCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void profName_TextChanged(object sender, EventArgs e)
        {

        }

        private void equipment_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool CheckTextboxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (employeeName.Text == "" || borrowerName.Text == "" || IDNumber.Text == "" || crsandyear.Text == "" || subjetCode.Text == "" || equipment.Text == "" || quantity.Text == "" || condition.Text == "")
            {
                MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to borrow this equipment?", "Borrow Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sql6690575.borrowing_form (employee_name, id_number, borrower_name, subject_code, course_and_year, borrowed_equipment, quantity, condition_, borrowed_date, borrowed_time) VALUES (@employee_name, @id_number, @borrower_name, @subject_code, @course_and_year, @equipment, @quantity, @condition_, @borrowed_date, @borrowed_time)", connection);

                if (!CheckTextboxes())
                {
                    MessageBox.Show("Please fill-in all required info!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime borrowed_date = DateTime.Now;
                DateTime borrowed_time = DateTime.Now;
                cmd.Parameters.AddWithValue("@employee_name", employeeName.Text);
                cmd.Parameters.AddWithValue("@borrower_name", borrowerName.Text);
                cmd.Parameters.AddWithValue("@id_number", IDNumber.Text);
                cmd.Parameters.AddWithValue("@course_and_year", crsandyear.Text);
                cmd.Parameters.AddWithValue("@subject_code", subjetCode.Text);
                cmd.Parameters.AddWithValue("@equipment", equipment.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.Parameters.AddWithValue("@condition_", condition.Text);
                cmd.Parameters.AddWithValue("@borrowed_date", borrowed_date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@borrowed_time", borrowed_time.ToString("hh:mm:ss:tt"));

                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfully Borrowed Equipment!", "Borrowed Equipment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    foreach (Control c in panel1.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                        }

                    }
                }
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to clear all fields?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (Control c in panel1.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Clear();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BorrowingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
