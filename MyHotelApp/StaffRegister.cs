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
    public partial class StaffRegister : MetroFramework.Forms.MetroForm
    {
        Form form;
        SqlConnection conn;
        SqlCommand cmd, cmd2;

        string name, gender, phone, mail, address, role, nid;
        string dob, join, resign;

        private void StaffRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StaffRegister_Load(object sender, EventArgs e)
        {

        }

        public StaffRegister(Form f, SqlConnection c)
        {
            InitializeComponent();
            form = f;
            conn = c;
        }

        private void rsSaveBtn_Click(object sender, EventArgs e)
        {
            name = rsNameTxt.Text;
            gender = rsGenderCombo.Text;
            mail = rsMailTxt.Text;
            address = rsAddressTxt.Text;
            phone = rsPhoneTxt.Text;

            nid = rsNIDtxt.Text;

            dob = rsDOBdate.Value.ToShortDateString();
            join = rsJoinDate.Value.ToShortDateString();
            resign = rsResignDate.Value.ToShortDateString();

            role = rsRoleCombo.Text;

            string sql = "INSERT INTO Staff (name, dateofbirth, gender, phone, email, nid, joindate, address, role) VALUES ('" + name + "','" + dob + "','" + gender + "','" + phone + "','" + mail + "','" + nid + "','" + join + "','" + address + "','" + role + "');";
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlDataReader r1 = cmd.ExecuteReader();
                r1.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }

            if (rsRoleCombo.Text == "Management")
            {
                rsPanel2.Show();
            }
            else
            {
                form.Show();
                this.Hide();
            }
        }

        private void rsResetBtn_Click(object sender, EventArgs e)
        {
            rsNameTxt.ResetText();
            rsGenderCombo.ResetText();
            rsMailTxt.ResetText();
            rsPhoneTxt.ResetText();
            rsAddressTxt.ResetText();
            rsNIDtxt.ResetText();
            rsDOBdate.ResetText();
            rsJoinDate.ResetText();
            rsResignDate.ResetText();
        }

        private void rsRegBtn_Click(object sender, EventArgs e)
        {
            string user, pass;

            if (rsPassTxt.Text == rsPassConfTxt.Text)
            {
                user = rsUserTxt.Text;
                pass = rsPassTxt.Text;

                string sql2 = "INSERT INTO Login (username, password, role) VALUES ('" + rsUserTxt.Text + "','" + rsPassTxt.Text + "','"+role+"');";
                cmd2 = new SqlCommand(sql2, conn);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    cmd2.ExecuteReader();
                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Passwords don't match. Check again");
            }

        }

        private void rsRegCloseBtn_Click(object sender, EventArgs e)
        {
            rsPanel2.Hide();
        }

        private void rgHomeBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
