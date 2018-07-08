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
    public partial class GuestRegister : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn;
        Form form;

        string name, gender, phone, mail, address, nationality, nid, dob, cin, cout, room;

        private void GuestRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        int selectedRow;

        public GuestRegister(Form f, SqlConnection c)
        {
            InitializeComponent();
            this.form = f;
            this.conn = c;
        }

        private void rgFindBtn_Click(object sender, EventArgs e)
        {
            string type = rgRoomTypeCombo.Text;

            string sql = "SELECT * FROM Rooms WHERE Class = '" + type + "' AND Status = 'Available';";

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand rs = new SqlCommand(sql, conn);
                SqlDataAdapter ad = new SqlDataAdapter(rs);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                roomStateGrid.DataSource = dt;
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

        private void roomStateGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            DataGridViewRow cRow = roomStateGrid.Rows[selectedRow];

            rgRoomNumTxt.Text = cRow.Cells[1].Value.ToString();
        }

        private void rgConfirmBtn_Click(object sender, EventArgs e)
        {
            room = rgRoomNumTxt.Text;

            string sql = "UPDATE Rooms SET Status = 'Booked' WHERE Number = '"+room+"';";

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

            rgPanelChoose.Hide();
        }

        private void GuestRegister_Load(object sender, EventArgs e)
        {
            rgGenderCombo.Items.Add("Male");
            rgGenderCombo.Items.Add("Female");
        }

        private void rgHomeBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void rgSaveBtn_Click(object sender, EventArgs e)
        {
            name = rgNameTxt.Text;
            gender = rgGenderCombo.Text;
            phone = rgPhoneTxt.Text;
            mail = rgMailTxt.Text;
            address = rgAddressTxt.Text;
            nationality = rgNationalityTxt.Text;

            nid = rgNIDtxt.Text;

            dob = dobDate.Value.ToShortDateString();
            cin = cinDate.Value.ToShortDateString();
            cout = coutDate.Value.ToShortDateString();

            string sql = "INSERT INTO Guests (name, dateofbirth, gender, nationality, nid, email, phone, checkin, checkout, address, room) VALUES ('" + name + "','" + dob + "','" + gender + "','" + nationality + "','" + nid + "','" + mail + "','" + phone + "','" + cin + "','" + cout + "','" + address + "','" + room + "');";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteReader();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            this.Hide();
            form.Show();
        }

        private void rgResetBtn_Click(object sender, EventArgs e)
        {
            rgNameTxt.ResetText();
            rgGenderCombo.ResetText();
            rgPhoneTxt.ResetText();
            rgMailTxt.ResetText();
            rgAddressTxt.ResetText();
            rgNationalityTxt.ResetText();
            rgNIDtxt.ResetText();
            dobDate.ResetText();
            cinDate.ResetText();
            coutDate.ResetText();
        }
    }
}
