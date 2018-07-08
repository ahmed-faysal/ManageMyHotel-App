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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=STORMBREAKER;Initial Catalog=mHotel;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dataReader;
        string user, pass;

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            user = usernameTxt.Text;
            pass = passwordTxt.Text;

            if (user == "" || pass == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please provide UserName and Password");
                return;
            }

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                string sql = "SELECT * FROM Login";
                cmd = new SqlCommand(sql, conn);
                dataReader = cmd.ExecuteReader();
                Boolean valid = false;

                while (dataReader.Read())
                {
                    if (dataReader.GetString(0) == user && dataReader.GetString(1) == pass)
                    {
                        this.Hide();
                        valid = true;
                        if (dataReader.GetString(2) == "Admin")
                        {
                            AdminPanel ap = new AdminPanel(this, conn);
                            ap.Show();
                        }
                        else if (dataReader.GetString(2) == "Management")
                        {
                            ManagementPanel mp = new ManagementPanel(this, conn);
                            mp.Show();
                        }else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "You Don't Have Access to System");
                            this.Show();
                        }
                    }
                }

                if (!valid)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Incorrect Login Details. Try Again");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
