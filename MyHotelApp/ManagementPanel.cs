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
    public partial class ManagementPanel : MetroFramework.Forms.MetroForm
    {
        Form form;
        SqlConnection conn;

        public ManagementPanel(Form f, SqlConnection c)
        {
            InitializeComponent();
            form = f;
            conn = c;
        }

        private void manLogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void admAddBtn_Click(object sender, EventArgs e)
        {
            GuestRegister gr = new GuestRegister(this, conn);
            this.Hide();
            gr.Show();
        }

        private void manSearchBtn_Click(object sender, EventArgs e)
        {
            Search s = new Search(this, conn);
            this.Hide();
            s.Show();
        }

        private void admStaffsBtn_Click(object sender, EventArgs e)
        {
            EditGuest eg = new EditGuest(this, conn);
            this.Hide();
            eg.Show();
        }

        private void admManageBtn_Click(object sender, EventArgs e)
        {
            RoomInfo rm = new RoomInfo(this, conn);
            this.Hide();
            rm.Show();
        }

        private void ManagementPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
