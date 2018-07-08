namespace MyHotelApp
{
    partial class Search
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rgPanel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.searchHomeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.searchtermTxt = new MetroFramework.Controls.MetroTextBox();
            this.typeCombo = new MetroFramework.Controls.MetroComboBox();
            this.fieldCombo = new MetroFramework.Controls.MetroComboBox();
            this.findBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchResultGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.rgPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchHomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rgPanel1
            // 
            this.rgPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rgPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.rgPanel1.Controls.Add(this.searchHomeBtn);
            this.rgPanel1.Location = new System.Drawing.Point(0, 27);
            this.rgPanel1.Name = "rgPanel1";
            this.rgPanel1.Size = new System.Drawing.Size(800, 80);
            this.rgPanel1.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Moire", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(317, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(143, 39);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Search";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchHomeBtn
            // 
            this.searchHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchHomeBtn.Image = global::MyHotelApp.Properties.Resources.home;
            this.searchHomeBtn.ImageActive = null;
            this.searchHomeBtn.Location = new System.Drawing.Point(11, 10);
            this.searchHomeBtn.Name = "searchHomeBtn";
            this.searchHomeBtn.Size = new System.Drawing.Size(63, 60);
            this.searchHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchHomeBtn.TabIndex = 1;
            this.searchHomeBtn.TabStop = false;
            this.searchHomeBtn.Zoom = 10;
            this.searchHomeBtn.Click += new System.EventHandler(this.searchHomeBtn_Click);
            // 
            // searchtermTxt
            // 
            // 
            // 
            // 
            this.searchtermTxt.CustomButton.Image = null;
            this.searchtermTxt.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.searchtermTxt.CustomButton.Name = "";
            this.searchtermTxt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchtermTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchtermTxt.CustomButton.TabIndex = 1;
            this.searchtermTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchtermTxt.CustomButton.UseSelectable = true;
            this.searchtermTxt.CustomButton.Visible = false;
            this.searchtermTxt.Lines = new string[0];
            this.searchtermTxt.Location = new System.Drawing.Point(40, 134);
            this.searchtermTxt.MaxLength = 32767;
            this.searchtermTxt.Name = "searchtermTxt";
            this.searchtermTxt.PasswordChar = '\0';
            this.searchtermTxt.PromptText = "Search Here";
            this.searchtermTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchtermTxt.SelectedText = "";
            this.searchtermTxt.SelectionLength = 0;
            this.searchtermTxt.SelectionStart = 0;
            this.searchtermTxt.ShortcutsEnabled = true;
            this.searchtermTxt.Size = new System.Drawing.Size(328, 29);
            this.searchtermTxt.TabIndex = 4;
            this.searchtermTxt.UseSelectable = true;
            this.searchtermTxt.WaterMark = "Search Here";
            this.searchtermTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchtermTxt.WaterMarkFont = new System.Drawing.Font("Pericles", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.ItemHeight = 23;
            this.typeCombo.Items.AddRange(new object[] {
            "Staff",
            "Guests"});
            this.typeCombo.Location = new System.Drawing.Point(379, 134);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(120, 29);
            this.typeCombo.TabIndex = 5;
            this.typeCombo.UseSelectable = true;
            // 
            // fieldCombo
            // 
            this.fieldCombo.FormattingEnabled = true;
            this.fieldCombo.ItemHeight = 23;
            this.fieldCombo.Items.AddRange(new object[] {
            "Name",
            "NID",
            "Phone",
            "Email"});
            this.fieldCombo.Location = new System.Drawing.Point(509, 134);
            this.fieldCombo.Name = "fieldCombo";
            this.fieldCombo.Size = new System.Drawing.Size(120, 29);
            this.fieldCombo.TabIndex = 6;
            this.fieldCombo.UseSelectable = true;
            // 
            // findBtn
            // 
            this.findBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.findBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.findBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findBtn.BorderRadius = 0;
            this.findBtn.ButtonText = "Find";
            this.findBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findBtn.DisabledColor = System.Drawing.Color.Gray;
            this.findBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.findBtn.Iconimage = null;
            this.findBtn.Iconimage_right = null;
            this.findBtn.Iconimage_right_Selected = null;
            this.findBtn.Iconimage_Selected = null;
            this.findBtn.IconMarginLeft = 0;
            this.findBtn.IconMarginRight = 0;
            this.findBtn.IconRightVisible = true;
            this.findBtn.IconRightZoom = 0D;
            this.findBtn.IconVisible = true;
            this.findBtn.IconZoom = 90D;
            this.findBtn.IsTab = false;
            this.findBtn.Location = new System.Drawing.Point(635, 134);
            this.findBtn.Name = "findBtn";
            this.findBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.findBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.findBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.findBtn.selected = false;
            this.findBtn.Size = new System.Drawing.Size(120, 29);
            this.findBtn.TabIndex = 7;
            this.findBtn.Text = "Find";
            this.findBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findBtn.Textcolor = System.Drawing.Color.White;
            this.findBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // searchResultGrid
            // 
            this.searchResultGrid.AllowUserToAddRows = false;
            this.searchResultGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResultGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.searchResultGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResultGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGrid.DoubleBuffered = true;
            this.searchResultGrid.EnableHeadersVisualStyles = false;
            this.searchResultGrid.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.searchResultGrid.HeaderForeColor = System.Drawing.Color.AliceBlue;
            this.searchResultGrid.Location = new System.Drawing.Point(11, 184);
            this.searchResultGrid.Name = "searchResultGrid";
            this.searchResultGrid.ReadOnly = true;
            this.searchResultGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchResultGrid.Size = new System.Drawing.Size(777, 253);
            this.searchResultGrid.TabIndex = 8;
            this.searchResultGrid.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchResultGrid);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.fieldCombo);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.searchtermTxt);
            this.Controls.Add(this.rgPanel1);
            this.Name = "Search";
            this.Text = "Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Search_FormClosed);
            this.rgPanel1.ResumeLayout(false);
            this.rgPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchHomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rgPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton searchHomeBtn;
        private MetroFramework.Controls.MetroTextBox searchtermTxt;
        private MetroFramework.Controls.MetroComboBox typeCombo;
        private MetroFramework.Controls.MetroComboBox fieldCombo;
        private Bunifu.Framework.UI.BunifuFlatButton findBtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid searchResultGrid;
    }
}