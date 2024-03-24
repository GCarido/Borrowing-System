using MySql.Data.MySqlClient;
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
    public partial class StaffInventory : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6690575";
        public string mySqlServerPassword = "WzrG9YgeeE";
        public string mySqlDatabaseName = "sql6690575";

        public StaffInventory()
        {
            InitializeComponent();
        }

        private void StaffInventory_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM inventory_form", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            inventoryData.DataSource = dt;
            connection.Close();
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                    try
                    {
                        string MyConnection2 = "datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";";
                        string Query = "delete from sql6690575.inventory_form where equipment_ID='" + 4 +  "';";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                        MyConn2.Close();
                    }

                     }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }

           
        }
    }
}
