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
    public partial class DashBoard : Form
    {
        public string mySqlServerName = "sql6.freemysqlhosting.net";
        public string mySqlServerUserId = "sql6690575";
        public string mySqlServerPassword = "WzrG9YgeeE";
        public string mySqlDatabaseName = "sql6690575";

        public DashBoard()
        {
            InitializeComponent();
            this.dashboardTable.MouseWheel += new MouseEventHandler(dashboardTable_MouseWheel);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sql6690575.borrowing_form", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dashboardTable.DataSource = dt;
            connection.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            int visibleRows = dashboardTable.DisplayedRowCount(false);
            int maxFirstRow = Math.Max(0, dashboardTable.Rows.Count - visibleRows);
            int desiredFirstRow = Math.Max(0, Math.Min(maxFirstRow, e.NewValue));

            dashboardTable.FirstDisplayedScrollingRowIndex = desiredFirstRow;


        }

        private void dashboardTable_MouseWheel(object sender, MouseEventArgs e)
        {

            int currentIndex = this.dashboardTable.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (e.Delta > 0)
            {
                this.dashboardTable.FirstDisplayedScrollingRowIndex
                    = Math.Max(0, currentIndex - scrollLines);
            }
            else if (e.Delta < 0)
            {
                this.dashboardTable.FirstDisplayedScrollingRowIndex
                    = currentIndex + scrollLines;
            }

        }

        private void vScrollBar1_MouseHover(object sender, EventArgs e)
        {

        }

        private void dashboardTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dashboardTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                dashboardTable.Cursor = Cursors.Hand;
            }

        }

        private void dashboardTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dashboardTable.Cursor = Cursors.Default;
        }
    }
}
