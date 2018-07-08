namespace MyHotelApp
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stListGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resigndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mHotelDataSet = new MyHotelApp.mHotelDataSet();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.staffsCloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.admManageBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.admSearchBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.admStaffsBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.admAddBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admLogoutBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.staffTableAdapter = new MyHotelApp.mHotelDataSetTableAdapters.StaffTableAdapter();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admManageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admSearchBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admStaffsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admAddBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admLogoutBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.admManageBtn);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.admSearchBtn);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.admStaffsBtn);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.admAddBtn);
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 320);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stListGrid);
            this.panel3.Controls.Add(this.refreshBtn);
            this.panel3.Controls.Add(this.staffsCloseBtn);
            this.panel3.Location = new System.Drawing.Point(11, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 302);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // stListGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stListGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.stListGrid.AutoGenerateColumns = false;
            this.stListGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.stListGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stListGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stListGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nidDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.resigndateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.stListGrid.DataSource = this.staffBindingSource;
            this.stListGrid.DoubleBuffered = true;
            this.stListGrid.EnableHeadersVisualStyles = false;
            this.stListGrid.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.stListGrid.HeaderForeColor = System.Drawing.Color.AliceBlue;
            this.stListGrid.Location = new System.Drawing.Point(13, 53);
            this.stListGrid.Name = "stListGrid";
            this.stListGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stListGrid.Size = new System.Drawing.Size(554, 235);
            this.stListGrid.TabIndex = 18;
            this.stListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stListGrid_CellClick);
            this.stListGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stListGrid_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "dateofbirth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "dateofbirth";
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // nidDataGridViewTextBoxColumn
            // 
            this.nidDataGridViewTextBoxColumn.DataPropertyName = "nid";
            this.nidDataGridViewTextBoxColumn.HeaderText = "nid";
            this.nidDataGridViewTextBoxColumn.Name = "nidDataGridViewTextBoxColumn";
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "joindate";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "joindate";
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            // 
            // resigndateDataGridViewTextBoxColumn
            // 
            this.resigndateDataGridViewTextBoxColumn.DataPropertyName = "resigndate";
            this.resigndateDataGridViewTextBoxColumn.HeaderText = "resigndate";
            this.resigndateDataGridViewTextBoxColumn.Name = "resigndateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.mHotelDataSet;
            // 
            // mHotelDataSet
            // 
            this.mHotelDataSet.DataSetName = "mHotelDataSet";
            this.mHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(243, 16);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(88, 23);
            this.refreshBtn.TabIndex = 17;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // staffsCloseBtn
            // 
            this.staffsCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.staffsCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("staffsCloseBtn.Image")));
            this.staffsCloseBtn.ImageActive = null;
            this.staffsCloseBtn.Location = new System.Drawing.Point(540, 3);
            this.staffsCloseBtn.Name = "staffsCloseBtn";
            this.staffsCloseBtn.Size = new System.Drawing.Size(34, 36);
            this.staffsCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staffsCloseBtn.TabIndex = 16;
            this.staffsCloseBtn.TabStop = false;
            this.staffsCloseBtn.Zoom = 10;
            this.staffsCloseBtn.Click += new System.EventHandler(this.staffsCloseBtn_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(445, 134);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(111, 19);
            this.bunifuCustomLabel5.TabIndex = 7;
            this.bunifuCustomLabel5.Text = "Management";
            // 
            // admManageBtn
            // 
            this.admManageBtn.BackColor = System.Drawing.Color.Transparent;
            this.admManageBtn.Image = global::MyHotelApp.Properties.Resources.manage;
            this.admManageBtn.ImageActive = null;
            this.admManageBtn.Location = new System.Drawing.Point(453, 44);
            this.admManageBtn.Name = "admManageBtn";
            this.admManageBtn.Size = new System.Drawing.Size(90, 87);
            this.admManageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admManageBtn.TabIndex = 6;
            this.admManageBtn.TabStop = false;
            this.admManageBtn.Zoom = 10;
            this.admManageBtn.Click += new System.EventHandler(this.admManageBtn_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(338, 134);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(60, 19);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Search";
            // 
            // admSearchBtn
            // 
            this.admSearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.admSearchBtn.Image = global::MyHotelApp.Properties.Resources.search;
            this.admSearchBtn.ImageActive = null;
            this.admSearchBtn.Location = new System.Drawing.Point(324, 44);
            this.admSearchBtn.Name = "admSearchBtn";
            this.admSearchBtn.Size = new System.Drawing.Size(90, 87);
            this.admSearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admSearchBtn.TabIndex = 4;
            this.admSearchBtn.TabStop = false;
            this.admSearchBtn.Zoom = 10;
            this.admSearchBtn.Click += new System.EventHandler(this.admSearchBtn_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(183, 134);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(96, 19);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "View Staffs";
            // 
            // admStaffsBtn
            // 
            this.admStaffsBtn.BackColor = System.Drawing.Color.Transparent;
            this.admStaffsBtn.Image = global::MyHotelApp.Properties.Resources.alluser;
            this.admStaffsBtn.ImageActive = null;
            this.admStaffsBtn.Location = new System.Drawing.Point(187, 44);
            this.admStaffsBtn.Name = "admStaffsBtn";
            this.admStaffsBtn.Size = new System.Drawing.Size(90, 87);
            this.admStaffsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admStaffsBtn.TabIndex = 2;
            this.admStaffsBtn.TabStop = false;
            this.admStaffsBtn.Zoom = 10;
            this.admStaffsBtn.Click += new System.EventHandler(this.admStaffsBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(51, 134);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(82, 19);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Add Staff";
            // 
            // admAddBtn
            // 
            this.admAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.admAddBtn.Image = global::MyHotelApp.Properties.Resources.adduser;
            this.admAddBtn.ImageActive = null;
            this.admAddBtn.Location = new System.Drawing.Point(47, 44);
            this.admAddBtn.Name = "admAddBtn";
            this.admAddBtn.Size = new System.Drawing.Size(90, 87);
            this.admAddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admAddBtn.TabIndex = 0;
            this.admAddBtn.TabStop = false;
            this.admAddBtn.Zoom = 10;
            this.admAddBtn.Click += new System.EventHandler(this.admAddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.admLogoutBtn);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 105);
            this.panel1.TabIndex = 2;
            // 
            // admLogoutBtn
            // 
            this.admLogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.admLogoutBtn.Image = global::MyHotelApp.Properties.Resources.signout;
            this.admLogoutBtn.ImageActive = null;
            this.admLogoutBtn.Location = new System.Drawing.Point(524, 25);
            this.admLogoutBtn.Name = "admLogoutBtn";
            this.admLogoutBtn.Size = new System.Drawing.Size(53, 53);
            this.admLogoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.admLogoutBtn.TabIndex = 3;
            this.admLogoutBtn.TabStop = false;
            this.admLogoutBtn.Zoom = 10;
            this.admLogoutBtn.Click += new System.EventHandler(this.admLogoutBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Moire", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(190, 34);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(226, 39);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Admin Panel";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffsCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admManageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admSearchBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admStaffsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admAddBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admLogoutBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuImageButton admManageBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton admSearchBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton admStaffsBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton admAddBtn;
        private Bunifu.Framework.UI.BunifuImageButton admLogoutBtn;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton staffsCloseBtn;
        private MetroFramework.Controls.MetroButton refreshBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid stListGrid;
        private mHotelDataSet mHotelDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private mHotelDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resigndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}