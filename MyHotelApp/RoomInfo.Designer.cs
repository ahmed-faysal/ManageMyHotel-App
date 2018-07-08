namespace MyHotelApp
{
    partial class RoomInfo
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
            this.roomGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.roomAddBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.roomTypeCombo = new MetroFramework.Controls.MetroComboBox();
            this.roomNumbertxt = new MetroFramework.Controls.MetroTextBox();
            this.addNewBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateRoomBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.roomUpdateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.roomStatusCombo = new MetroFramework.Controls.MetroComboBox();
            this.rgPanel1 = new System.Windows.Forms.Panel();
            this.resetBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.roomHomeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.UpdatePanel.SuspendLayout();
            this.rgPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomHomeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // roomGrid
            // 
            this.roomGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roomGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomGrid.DoubleBuffered = true;
            this.roomGrid.EnableHeadersVisualStyles = false;
            this.roomGrid.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.roomGrid.HeaderForeColor = System.Drawing.Color.AliceBlue;
            this.roomGrid.Location = new System.Drawing.Point(42, 186);
            this.roomGrid.Name = "roomGrid";
            this.roomGrid.ReadOnly = true;
            this.roomGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomGrid.Size = new System.Drawing.Size(504, 202);
            this.roomGrid.TabIndex = 0;
            this.roomGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomGrid_CellClick);
            this.roomGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roomGrid_KeyDown);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.roomAddBtn);
            this.AddPanel.Controls.Add(this.roomTypeCombo);
            this.AddPanel.Controls.Add(this.roomNumbertxt);
            this.AddPanel.Location = new System.Drawing.Point(42, 109);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(504, 37);
            this.AddPanel.TabIndex = 13;
            this.AddPanel.Visible = false;
            // 
            // roomAddBtn
            // 
            this.roomAddBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.roomAddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roomAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roomAddBtn.BorderRadius = 0;
            this.roomAddBtn.ButtonText = "Add";
            this.roomAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomAddBtn.DisabledColor = System.Drawing.Color.Gray;
            this.roomAddBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.roomAddBtn.Iconimage = null;
            this.roomAddBtn.Iconimage_right = null;
            this.roomAddBtn.Iconimage_right_Selected = null;
            this.roomAddBtn.Iconimage_Selected = null;
            this.roomAddBtn.IconMarginLeft = 0;
            this.roomAddBtn.IconMarginRight = 0;
            this.roomAddBtn.IconRightVisible = true;
            this.roomAddBtn.IconRightZoom = 0D;
            this.roomAddBtn.IconVisible = true;
            this.roomAddBtn.IconZoom = 90D;
            this.roomAddBtn.IsTab = false;
            this.roomAddBtn.Location = new System.Drawing.Point(384, 4);
            this.roomAddBtn.Name = "roomAddBtn";
            this.roomAddBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.roomAddBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.roomAddBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.roomAddBtn.selected = false;
            this.roomAddBtn.Size = new System.Drawing.Size(120, 29);
            this.roomAddBtn.TabIndex = 13;
            this.roomAddBtn.Text = "Add";
            this.roomAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomAddBtn.Textcolor = System.Drawing.Color.White;
            this.roomAddBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomAddBtn.Click += new System.EventHandler(this.roomAddBtn_Click);
            // 
            // roomTypeCombo
            // 
            this.roomTypeCombo.FormattingEnabled = true;
            this.roomTypeCombo.ItemHeight = 23;
            this.roomTypeCombo.Items.AddRange(new object[] {
            "VIP",
            "Regular"});
            this.roomTypeCombo.Location = new System.Drawing.Point(258, 4);
            this.roomTypeCombo.Name = "roomTypeCombo";
            this.roomTypeCombo.Size = new System.Drawing.Size(120, 29);
            this.roomTypeCombo.TabIndex = 12;
            this.roomTypeCombo.UseSelectable = true;
            // 
            // roomNumbertxt
            // 
            // 
            // 
            // 
            this.roomNumbertxt.CustomButton.Image = null;
            this.roomNumbertxt.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.roomNumbertxt.CustomButton.Name = "";
            this.roomNumbertxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.roomNumbertxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.roomNumbertxt.CustomButton.TabIndex = 1;
            this.roomNumbertxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.roomNumbertxt.CustomButton.UseSelectable = true;
            this.roomNumbertxt.CustomButton.Visible = false;
            this.roomNumbertxt.Lines = new string[0];
            this.roomNumbertxt.Location = new System.Drawing.Point(0, 4);
            this.roomNumbertxt.MaxLength = 32767;
            this.roomNumbertxt.Name = "roomNumbertxt";
            this.roomNumbertxt.PasswordChar = '\0';
            this.roomNumbertxt.PromptText = "Number";
            this.roomNumbertxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roomNumbertxt.SelectedText = "";
            this.roomNumbertxt.SelectionLength = 0;
            this.roomNumbertxt.SelectionStart = 0;
            this.roomNumbertxt.ShortcutsEnabled = true;
            this.roomNumbertxt.Size = new System.Drawing.Size(252, 29);
            this.roomNumbertxt.TabIndex = 11;
            this.roomNumbertxt.UseSelectable = true;
            this.roomNumbertxt.WaterMark = "Number";
            this.roomNumbertxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.roomNumbertxt.WaterMarkFont = new System.Drawing.Font("Pericles", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // addNewBtn
            // 
            this.addNewBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addNewBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewBtn.BorderRadius = 0;
            this.addNewBtn.ButtonText = "Add New Room";
            this.addNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addNewBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addNewBtn.Iconimage = null;
            this.addNewBtn.Iconimage_right = null;
            this.addNewBtn.Iconimage_right_Selected = null;
            this.addNewBtn.Iconimage_Selected = null;
            this.addNewBtn.IconMarginLeft = 0;
            this.addNewBtn.IconMarginRight = 0;
            this.addNewBtn.IconRightVisible = true;
            this.addNewBtn.IconRightZoom = 0D;
            this.addNewBtn.IconVisible = true;
            this.addNewBtn.IconZoom = 90D;
            this.addNewBtn.IsTab = false;
            this.addNewBtn.Location = new System.Drawing.Point(42, 118);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.addNewBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.addNewBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addNewBtn.selected = false;
            this.addNewBtn.Size = new System.Drawing.Size(233, 29);
            this.addNewBtn.TabIndex = 14;
            this.addNewBtn.Text = "Add New Room";
            this.addNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addNewBtn.Textcolor = System.Drawing.Color.White;
            this.addNewBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // updateRoomBtn
            // 
            this.updateRoomBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateRoomBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.updateRoomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateRoomBtn.BorderRadius = 0;
            this.updateRoomBtn.ButtonText = "Update Room Info";
            this.updateRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateRoomBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateRoomBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateRoomBtn.Iconimage = null;
            this.updateRoomBtn.Iconimage_right = null;
            this.updateRoomBtn.Iconimage_right_Selected = null;
            this.updateRoomBtn.Iconimage_Selected = null;
            this.updateRoomBtn.IconMarginLeft = 0;
            this.updateRoomBtn.IconMarginRight = 0;
            this.updateRoomBtn.IconRightVisible = true;
            this.updateRoomBtn.IconRightZoom = 0D;
            this.updateRoomBtn.IconVisible = true;
            this.updateRoomBtn.IconZoom = 90D;
            this.updateRoomBtn.IsTab = false;
            this.updateRoomBtn.Location = new System.Drawing.Point(314, 118);
            this.updateRoomBtn.Name = "updateRoomBtn";
            this.updateRoomBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.updateRoomBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.updateRoomBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateRoomBtn.selected = false;
            this.updateRoomBtn.Size = new System.Drawing.Size(232, 29);
            this.updateRoomBtn.TabIndex = 15;
            this.updateRoomBtn.Text = "Update Room Info";
            this.updateRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateRoomBtn.Textcolor = System.Drawing.Color.White;
            this.updateRoomBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRoomBtn.Click += new System.EventHandler(this.updateRoomBtn_Click);
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.Controls.Add(this.roomUpdateBtn);
            this.UpdatePanel.Controls.Add(this.roomStatusCombo);
            this.UpdatePanel.Location = new System.Drawing.Point(42, 147);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(504, 37);
            this.UpdatePanel.TabIndex = 16;
            this.UpdatePanel.Visible = false;
            // 
            // roomUpdateBtn
            // 
            this.roomUpdateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.roomUpdateBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.roomUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roomUpdateBtn.BorderRadius = 0;
            this.roomUpdateBtn.ButtonText = "Update";
            this.roomUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomUpdateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.roomUpdateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.roomUpdateBtn.Iconimage = null;
            this.roomUpdateBtn.Iconimage_right = null;
            this.roomUpdateBtn.Iconimage_right_Selected = null;
            this.roomUpdateBtn.Iconimage_Selected = null;
            this.roomUpdateBtn.IconMarginLeft = 0;
            this.roomUpdateBtn.IconMarginRight = 0;
            this.roomUpdateBtn.IconRightVisible = true;
            this.roomUpdateBtn.IconRightZoom = 0D;
            this.roomUpdateBtn.IconVisible = true;
            this.roomUpdateBtn.IconZoom = 90D;
            this.roomUpdateBtn.IsTab = false;
            this.roomUpdateBtn.Location = new System.Drawing.Point(384, 4);
            this.roomUpdateBtn.Name = "roomUpdateBtn";
            this.roomUpdateBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.roomUpdateBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.roomUpdateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.roomUpdateBtn.selected = false;
            this.roomUpdateBtn.Size = new System.Drawing.Size(120, 29);
            this.roomUpdateBtn.TabIndex = 14;
            this.roomUpdateBtn.Text = "Update";
            this.roomUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomUpdateBtn.Textcolor = System.Drawing.Color.White;
            this.roomUpdateBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomUpdateBtn.Click += new System.EventHandler(this.roomUpdateBtn_Click);
            // 
            // roomStatusCombo
            // 
            this.roomStatusCombo.FormattingEnabled = true;
            this.roomStatusCombo.ItemHeight = 23;
            this.roomStatusCombo.Items.AddRange(new object[] {
            "Available",
            "Booked"});
            this.roomStatusCombo.Location = new System.Drawing.Point(258, 4);
            this.roomStatusCombo.Name = "roomStatusCombo";
            this.roomStatusCombo.Size = new System.Drawing.Size(120, 29);
            this.roomStatusCombo.TabIndex = 13;
            this.roomStatusCombo.UseSelectable = true;
            // 
            // rgPanel1
            // 
            this.rgPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rgPanel1.Controls.Add(this.resetBtn);
            this.rgPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.rgPanel1.Controls.Add(this.roomHomeBtn);
            this.rgPanel1.Location = new System.Drawing.Point(0, 26);
            this.rgPanel1.Name = "rgPanel1";
            this.rgPanel1.Size = new System.Drawing.Size(585, 78);
            this.rgPanel1.TabIndex = 17;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.Image = global::MyHotelApp.Properties.Resources.updateicon;
            this.resetBtn.ImageActive = null;
            this.resetBtn.Location = new System.Drawing.Point(508, 10);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(63, 60);
            this.resetBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resetBtn.TabIndex = 4;
            this.resetBtn.TabStop = false;
            this.resetBtn.Zoom = 10;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Moire", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(152, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(277, 39);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Manage Rooms";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomHomeBtn
            // 
            this.roomHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.roomHomeBtn.Image = global::MyHotelApp.Properties.Resources.home;
            this.roomHomeBtn.ImageActive = null;
            this.roomHomeBtn.Location = new System.Drawing.Point(11, 10);
            this.roomHomeBtn.Name = "roomHomeBtn";
            this.roomHomeBtn.Size = new System.Drawing.Size(63, 60);
            this.roomHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roomHomeBtn.TabIndex = 1;
            this.roomHomeBtn.TabStop = false;
            this.roomHomeBtn.Zoom = 10;
            this.roomHomeBtn.Click += new System.EventHandler(this.roomHomeBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // RoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.rgPanel1);
            this.Controls.Add(this.UpdatePanel);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.updateRoomBtn);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.roomGrid);
            this.MaximizeBox = false;
            this.Name = "RoomInfo";
            this.Text = "RoomInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomInfo_FormClosed);
            this.Load += new System.EventHandler(this.RoomInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.UpdatePanel.ResumeLayout(false);
            this.rgPanel1.ResumeLayout(false);
            this.rgPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resetBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomHomeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid roomGrid;
        private System.Windows.Forms.Panel AddPanel;
        private Bunifu.Framework.UI.BunifuFlatButton roomAddBtn;
        private MetroFramework.Controls.MetroComboBox roomTypeCombo;
        private MetroFramework.Controls.MetroTextBox roomNumbertxt;
        private Bunifu.Framework.UI.BunifuFlatButton addNewBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updateRoomBtn;
        private System.Windows.Forms.Panel UpdatePanel;
        private Bunifu.Framework.UI.BunifuFlatButton roomUpdateBtn;
        private MetroFramework.Controls.MetroComboBox roomStatusCombo;
        private System.Windows.Forms.Panel rgPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton roomHomeBtn;
        private Bunifu.Framework.UI.BunifuImageButton resetBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}