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
    public partial class Search : MetroFramework.Forms.MetroForm
    {
        Form form;
        SqlConnection conn;

        public Search(Form f, SqlConnection c)
        {
            InitializeComponent();
            form = f;
            conn = c;
        }

        private void searchHomeBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            string term = searchtermTxt.Text;
            string type = typeCombo.Text;
            string field = fieldCombo.Text.ToLower();

            string sql = "SELECT * FROM "+type+" WHERE "+field+" LIKE '%"+term+"%';";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                searchResultGrid.DataSource = dt;
                searchResultGrid.Show();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Inputs. Choose all options.");
            }
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}