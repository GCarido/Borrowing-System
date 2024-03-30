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

        private DataGridViewCell selectedCell = null;

        Image normalImage = Properties.Resources.return3;
        Image hoverImage = Properties.Resources.return2;

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

        private void dashboardTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dashboardTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                dashboardTable.Cursor = Cursors.Hand;
            }
        }

        private void dashboardTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                dashboardTable.Cursor = Cursors.Default;
            }
        }


        private void dashboardTable_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }



        private void dashboardTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 11)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void dashboardTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 11)
            {

                //Change Image when selected
                selectedCell = dashboardTable[e.ColumnIndex, e.RowIndex];
                dashboardTable.InvalidateCell(e.ColumnIndex, e.RowIndex); 
                dashboardTable.Refresh();

                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //PARTIAL CODE FOR DELETION
                    MySqlConnection connection = new MySqlConnection("datasource=" + mySqlServerName + ";port=3306;username=" + mySqlServerUserId + ";password=" + mySqlServerPassword + ";database=" + mySqlDatabaseName + ";");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM sql6690575.borrowing_form WHERE borrowed_id = " + dashboardTable.Rows[e.RowIndex].Cells[0].Value.ToString(), connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //REFRESH DATAGRIDVIEW
                    connection.Open();
                    cmd = new MySqlCommand("SELECT * FROM sql6690575.borrowing_form", connection);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dashboardTable.DataSource = dt;
                    connection.Close();
                }
                else
                {
                    // If the user clicked "No", set selectedCell to null and refresh the DataGridView
                    selectedCell = null;
                    dashboardTable.Refresh();
                }
            }
                
        }

    }
}
