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
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        ManagementPanel mPan;
        StaffRegister sr;
        Form form;
        SqlConnection conn;
        int selectedRow;

        public AdminPanel(Form f, SqlConnection c)
        {
            InitializeComponent();
            form = f;
            conn = c;
        }

        private void admLogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void admAddBtn_Click(object sender, EventArgs e)
        {
            sr = new StaffRegister(this, conn);
            this.Hide();
            sr.Show();
        }

        private void admStaffsBtn_Click(object sender, EventArgs e)
        {
            RefreshAll();
            panel3.Show();
        }

        private void admManageBtn_Click(object sender, EventArgs e)
        {
            mPan = new ManagementPanel(form, conn);
            mPan.Show();
            this.Hide();         
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mHotelDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.mHotelDataSet.Staff);

        }

        private void staffsCloseBtn_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            stListGrid.Refresh();
            RefreshAll();
        }

        private void admSearchBtn_Click(object sender, EventArgs e)
        {
            Search s = new Search(this, conn);
            this.Hide();
            s.Show();
        }

        private void RefreshAll()
        {
            string sql = "SELECT * FROM Staff";
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                stListGrid.DataSource = dt;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Something Went Wrong. Sorry About That.");
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void stListGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow cRow = stListGrid.Rows[selectedRow];
                string id = cRow.Cells[0].Value.ToString();
                int rid = Convert.ToInt32(id);

                string sql = "DELETE FROM Staff WHERE id = " + rid + ";";

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

        private void stListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }
    }
}
