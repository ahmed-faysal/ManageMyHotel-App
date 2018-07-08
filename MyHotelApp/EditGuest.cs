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
    public partial class EditGuest : MetroFramework.Forms.MetroForm
    {
        Form form;
        SqlConnection conn;

        int selectedRow;

        public EditGuest(Form f, SqlConnection c)
        {
            InitializeComponent();
            form = f;
            conn = c;
        }

        private void RefreshAll()
        {
            string sql = "SELECT * FROM Guests;";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                guestDataGrid.DataSource = dt;
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

        private void EditGuest_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void guestDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            DataGridViewRow cRow = guestDataGrid.Rows[selectedRow];

            ugNameTxt.Text = cRow.Cells[1].Value.ToString();
            dobDateTxt.Text = cRow.Cells[2].Value.ToString();
            ugGenderTxt.Text = cRow.Cells[3].Value.ToString();
            ugNationalityTxt.Text = cRow.Cells[4].Value.ToString();            
            ugNIDtxt.Text = cRow.Cells[5].Value.ToString();
            ugMailTxt.Text = cRow.Cells[6].Value.ToString();
            ugPhoneTxt.Text = cRow.Cells[7].Value.ToString();
            ugCinTxt.Text = cRow.Cells[8].Value.ToString();
            ugCoutTxt.Text = cRow.Cells[9].Value.ToString();
            ugAddressTxt.Text = cRow.Cells[10].Value.ToString();
            ugRoomTxt.Text = cRow.Cells[11].Value.ToString();
        }

        private void ugHomeBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void ugUpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow cRow = guestDataGrid.Rows[selectedRow];

            string sql = "UPDATE Guests SET name ='" + ugNameTxt.Text + "', dateofbirth ='"+ dobDateTxt.Text + "', gender ='" + ugGenderTxt.Text + "', nationality ='" + ugNationalityTxt.Text + "', nid ='" + ugNIDtxt.Text + "', email ='" + ugMailTxt.Text + "', phone ='" + ugPhoneTxt.Text + "', checkin ='" + ugCinTxt.Text + "', checkout ='" + ugCoutTxt.Text + "', address ='" + ugAddressTxt.Text + "', room ='" + ugRoomTxt.Text + "' WHERE id = '" + cRow.Cells[0].Value + "';";

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
                RefreshAll();
                conn.Close();
            }
        }

        private void EditGuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guestDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow cRow = guestDataGrid.Rows[selectedRow];
                string id = cRow.Cells[0].Value.ToString();
                int rid = Convert.ToInt32(id);

                string sql = "DELETE FROM Guests WHERE id = " + rid + ";";

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
