using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHotelApp
{
    public partial class RoomInfo : MetroFramework.Forms.MetroForm
    {
        Form form;
        SqlConnection conn;
        int selectedRow;
        DataTable dt;

        public RoomInfo(Form f, SqlConnection c)
        {
            InitializeComponent();
            form = f;
            conn = c;
        }

        private void RefreshGrid()
        {
            string sql = "SELECT * FROM Rooms;";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                dt = new DataTable();
                ad.Fill(dt);

                roomGrid.DataSource = dt;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Something Went Wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            UpdatePanel.Hide();
            AddPanel.Show();    
        }

        private void updateRoomBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Hide();
            UpdatePanel.Show();
        }

        private void roomHomeBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            roomGrid.Refresh();
            RefreshGrid();
            AddPanel.Hide();
            UpdatePanel.Hide();
        }

        private void roomAddBtn_Click(object sender, EventArgs e)
        {
            string number = roomNumbertxt.Text;
            string type = roomTypeCombo.Text;

            string sql = "INSERT INTO Rooms (Number, Status, Class) Values ('"+number+"','Available','"+type+"');";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand rs = new SqlCommand(sql, conn);

                SqlDataReader r1 = rs.ExecuteReader();
                r1.Close();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Something Went Wrong");
            }
            finally
            {               
                conn.Close();
            }
        }

        private void roomUpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow cRow = roomGrid.Rows[selectedRow];
            string cNum = cRow.Cells[1].Value.ToString();

            string status = roomStatusCombo.Text;
            string sql = "UPDATE Rooms SET Status ='" + status + "' WHERE Number = '"+cNum+"';";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand rs = new SqlCommand(sql, conn);

                SqlDataReader r1 = rs.ExecuteReader();
                r1.Close();

                cRow.Cells[1].Value = status;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Something Went Wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        private void roomGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void RoomInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roomGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow cRow = roomGrid.Rows[selectedRow];
                string id = cRow.Cells[0].Value.ToString();
                int rid = Convert.ToInt32(id);

                string sql = "DELETE FROM Rooms WHERE id = " + rid + ";";

                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    SqlCommand rs = new SqlCommand(sql, conn);

                    SqlDataReader r1 = rs.ExecuteReader();
                    r1.Close();
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Something Went Wrong");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
