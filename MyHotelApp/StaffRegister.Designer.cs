namespace MyHotelApp
{
    partial class StaffRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffRegister));
            this.rsPanel1 = new System.Windows.Forms.Panel();
            this.rgHomeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rsGenderCombo = new MetroFramework.Controls.MetroComboBox();
            this.rsDOBdate = new MetroFramework.Controls.MetroDateTime();
            this.rsNIDtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rsAddressTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rsMailTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rsPhoneTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rsNameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rsJoinDate = new MetroFramework.Controls.MetroDateTime();
            this.rsResignDate = new MetroFramework.Controls.MetroDateTime();
            this.rsResetBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.rsPanel2 = new System.Windows.Forms.Panel();
            this.rsRegCloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.rsPassConfTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rsPassTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rsRegBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rsUserTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rsSaveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rsRoleCombo = new MetroFramework.Controls.MetroComboBox();
            this.labelRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgHomeBtn)).BeginInit();
            this.rsPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsRegCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // rsPanel1
            // 
            this.rsPanel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rsPanel1.Controls.Add(this.rgHomeBtn);
            this.rsPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.rsPanel1.Location = new System.Drawing.Point(0, 27);
            this.rsPanel1.Name = "rsPanel1";
            this.rsPanel1.Size = new System.Drawing.Size(801, 78);
            this.rsPanel1.TabIndex = 3;
            // 
            // rgHomeBtn
            // 
            this.rgHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.rgHomeBtn.Image = global::MyHotelApp.Properties.Resources.home;
            this.rgHomeBtn.ImageActive = null;
            this.rgHomeBtn.Location = new System.Drawing.Point(11, 8);
            this.rgHomeBtn.Name = "rgHomeBtn";
            this.rgHomeBtn.Size = new System.Drawing.Size(63, 60);
            this.rgHomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rgHomeBtn.TabIndex = 2;
            this.rgHomeBtn.TabStop = false;
            this.rgHomeBtn.Zoom = 10;
            this.rgHomeBtn.Click += new System.EventHandler(this.rgHomeBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Moire", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(263, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(257, 39);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Register Staff";
            // 
            // rsGenderCombo
            // 
            this.rsGenderCombo.FormattingEnabled = true;
            this.rsGenderCombo.ItemHeight = 23;
            this.rsGenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.rsGenderCombo.Location = new System.Drawing.Point(149, 212);
            this.rsGenderCombo.Margin = new System.Windows.Forms.Padding(6);
            this.rsGenderCombo.Name = "rsGenderCombo";
            this.rsGenderCombo.Size = new System.Drawing.Size(250, 29);
            this.rsGenderCombo.TabIndex = 51;
            this.rsGenderCombo.UseSelectable = true;
            // 
            // rsDOBdate
            // 
            this.rsDOBdate.Location = new System.Drawing.Point(149, 175);
            this.rsDOBdate.Margin = new System.Windows.Forms.Padding(4);
            this.rsDOBdate.MinimumSize = new System.Drawing.Size(4, 29);
            this.rsDOBdate.Name = "rsDOBdate";
            this.rsDOBdate.Size = new System.Drawing.Size(250, 29);
            this.rsDOBdate.TabIndex = 50;
            // 
            // rsNIDtxt
            // 
            this.rsNIDtxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.rsNIDtxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsNIDtxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rsNIDtxt.BorderThickness = 2;
            this.rsNIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsNIDtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsNIDtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsNIDtxt.isPassword = false;
            this.rsNIDtxt.Location = new System.Drawing.Point(149, 284);
            this.rsNIDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsNIDtxt.Name = "rsNIDtxt";
            this.rsNIDtxt.Size = new System.Drawing.Size(250, 29);
            this.rsNIDtxt.TabIndex = 47;
            this.rsNIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(33, 290);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(39, 19);
            this.bunifuCustomLabel9.TabIndex = 45;
            this.bunifuCustomLabel9.Text = "NID";
            // 
            // rsAddressTxt
            // 
            this.rsAddressTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.rsAddressTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsAddressTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rsAddressTxt.BorderThickness = 2;
            this.rsAddressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsAddressTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsAddressTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsAddressTxt.isPassword = false;
            this.rsAddressTxt.Location = new System.Drawing.Point(526, 138);
            this.rsAddressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsAddressTxt.Name = "rsAddressTxt";
            this.rsAddressTxt.Size = new System.Drawing.Size(250, 105);
            this.rsAddressTxt.TabIndex = 43;
            this.rsAddressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rsMailTxt
            // 
            this.rsMailTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.rsMailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsMailTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rsMailTxt.BorderThickness = 2;
            this.rsMailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsMailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsMailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsMailTxt.isPassword = false;
            this.rsMailTxt.Location = new System.Drawing.Point(149, 321);
            this.rsMailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsMailTxt.Name = "rsMailTxt";
            this.rsMailTxt.Size = new System.Drawing.Size(250, 29);
            this.rsMailTxt.TabIndex = 42;
            this.rsMailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rsPhoneTxt
            // 
            this.rsPhoneTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.rsPhoneTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsPhoneTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rsPhoneTxt.BorderThickness = 2;
            this.rsPhoneTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsPhoneTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsPhoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsPhoneTxt.isPassword = false;
            this.rsPhoneTxt.Location = new System.Drawing.Point(149, 247);
            this.rsPhoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsPhoneTxt.Name = "rsPhoneTxt";
            this.rsPhoneTxt.Size = new System.Drawing.Size(250, 29);
            this.rsPhoneTxt.TabIndex = 41;
            this.rsPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rsNameTxt
            // 
            this.rsNameTxt.BorderColorFocused = System.Drawing.Color.Blue;
            this.rsNameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsNameTxt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rsNameTxt.BorderThickness = 2;
            this.rsNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsNameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsNameTxt.isPassword = false;
            this.rsNameTxt.Location = new System.Drawing.Point(149, 138);
            this.rsNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsNameTxt.Name = "rsNameTxt";
            this.rsNameTxt.Size = new System.Drawing.Size(250, 29);
            this.rsNameTxt.TabIndex = 40;
            this.rsNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(410, 144);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(66, 19);
            this.bunifuCustomLabel7.TabIndex = 39;
            this.bunifuCustomLabel7.Text = "Address";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(33, 327);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel6.TabIndex = 38;
            this.bunifuCustomLabel6.Text = "Email";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(33, 253);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(117, 19);
            this.bunifuCustomLabel5.TabIndex = 37;
            this.bunifuCustomLabel5.Text = "Phone Number";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(33, 214);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(61, 19);
            this.bunifuCustomLabel4.TabIndex = 36;
            this.bunifuCustomLabel4.Text = "Gender";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 178);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(107, 19);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "Date Of Birth";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 145);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(53, 19);
            this.bunifuCustomLabel2.TabIndex = 34;
            this.bunifuCustomLabel2.Text = "Name";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(410, 255);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(78, 19);
            this.bunifuCustomLabel8.TabIndex = 54;
            this.bunifuCustomLabel8.Text = "Join Date";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(410, 291);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(96, 19);
            this.bunifuCustomLabel10.TabIndex = 52;
            this.bunifuCustomLabel10.Text = "Resign Date";
            // 
            // rsJoinDate
            // 
            this.rsJoinDate.Location = new System.Drawing.Point(526, 249);
            this.rsJoinDate.Margin = new System.Windows.Forms.Padding(4);
            this.rsJoinDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.rsJoinDate.Name = "rsJoinDate";
            this.rsJoinDate.Size = new System.Drawing.Size(250, 29);
            this.rsJoinDate.TabIndex = 55;
            // 
            // rsResignDate
            // 
            this.rsResignDate.Location = new System.Drawing.Point(526, 286);
            this.rsResignDate.Margin = new System.Windows.Forms.Padding(4);
            this.rsResignDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.rsResignDate.Name = "rsResignDate";
            this.rsResignDate.Size = new System.Drawing.Size(250, 29);
            this.rsResignDate.TabIndex = 56;
            // 
            // rsResetBtn
            // 
            this.rsResetBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rsResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rsResetBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rsResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rsResetBtn.BorderRadius = 0;
            this.rsResetBtn.ButtonText = "Reset";
            this.rsResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rsResetBtn.DisabledColor = System.Drawing.Color.Gray;
            this.rsResetBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.rsResetBtn.Iconimage = null;
            this.rsResetBtn.Iconimage_right = null;
            this.rsResetBtn.Iconimage_right_Selected = null;
            this.rsResetBtn.Iconimage_Selected = null;
            this.rsResetBtn.IconMarginLeft = 0;
            this.rsResetBtn.IconMarginRight = 0;
            this.rsResetBtn.IconRightVisible = true;
            this.rsResetBtn.IconRightZoom = 0D;
            this.rsResetBtn.IconVisible = true;
            this.rsResetBtn.IconZoom = 90D;
            this.rsResetBtn.IsTab = false;
            this.rsResetBtn.Location = new System.Drawing.Point(410, 391);
            this.rsResetBtn.Name = "rsResetBtn";
            this.rsResetBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.rsResetBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.rsResetBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.rsResetBtn.selected = false;
            this.rsResetBtn.Size = new System.Drawing.Size(255, 36);
            this.rsResetBtn.TabIndex = 58;
            this.rsResetBtn.Text = "Reset";
            this.rsResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rsResetBtn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.rsResetBtn.TextFont = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsResetBtn.Click += new System.EventHandler(this.rsResetBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // rsPanel2
            // 
            this.rsPanel2.BackColor = System.Drawing.Color.SlateGray;
            this.rsPanel2.Controls.Add(this.rsRegCloseBtn);
            this.rsPanel2.Controls.Add(this.rsPassConfTxt);
            this.rsPanel2.Controls.Add(this.rsPassTxt);
            this.rsPanel2.Controls.Add(this.rsRegBtn);
            this.rsPanel2.Controls.Add(this.bunifuCustomLabel13);
            this.rsPanel2.Controls.Add(this.bunifuCustomLabel12);
            this.rsPanel2.Controls.Add(this.bunifuCustomLabel11);
            this.rsPanel2.Controls.Add(this.rsUserTxt);
            this.rsPanel2.Location = new System.Drawing.Point(11, 111);
            this.rsPanel2.Name = "rsPanel2";
            this.rsPanel2.Size = new System.Drawing.Size(779, 328);
            this.rsPanel2.TabIndex = 59;
            this.rsPanel2.Visible = false;
            // 
            // rsRegCloseBtn
            // 
            this.rsRegCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.rsRegCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("rsRegCloseBtn.Image")));
            this.rsRegCloseBtn.ImageActive = null;
            this.rsRegCloseBtn.Location = new System.Drawing.Point(742, 3);
            this.rsRegCloseBtn.Name = "rsRegCloseBtn";
            this.rsRegCloseBtn.Size = new System.Drawing.Size(34, 36);
            this.rsRegCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rsRegCloseBtn.TabIndex = 15;
            this.rsRegCloseBtn.TabStop = false;
            this.rsRegCloseBtn.Zoom = 10;
            this.rsRegCloseBtn.Click += new System.EventHandler(this.rsRegCloseBtn_Click);
            // 
            // rsPassConfTxt
            // 
            this.rsPassConfTxt.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.rsPassConfTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.rsPassConfTxt.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.rsPassConfTxt.BorderThickness = 3;
            this.rsPassConfTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsPassConfTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsPassConfTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsPassConfTxt.isPassword = true;
            this.rsPassConfTxt.Location = new System.Drawing.Point(202, 198);
            this.rsPassConfTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsPassConfTxt.Name = "rsPassConfTxt";
            this.rsPassConfTxt.Size = new System.Drawing.Size(370, 44);
            this.rsPassConfTxt.TabIndex = 14;
            this.rsPassConfTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rsPassTxt
            // 
            this.rsPassTxt.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.rsPassTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.rsPassTxt.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.rsPassTxt.BorderThickness = 3;
            this.rsPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsPassTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsPassTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsPassTxt.isPassword = true;
            this.rsPassTxt.Location = new System.Drawing.Point(202, 120);
            this.rsPassTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsPassTxt.Name = "rsPassTxt";
            this.rsPassTxt.Size = new System.Drawing.Size(370, 44);
            this.rsPassTxt.TabIndex = 13;
            this.rsPassTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rsRegBtn
            // 
            this.rsRegBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rsRegBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rsRegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rsRegBtn.BorderRadius = 0;
            this.rsRegBtn.ButtonText = "Register";
            this.rsRegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rsRegBtn.DisabledColor = System.Drawing.Color.Gray;
            this.rsRegBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.rsRegBtn.Iconimage = null;
            this.rsRegBtn.Iconimage_right = null;
            this.rsRegBtn.Iconimage_right_Selected = null;
            this.rsRegBtn.Iconimage_Selected = null;
            this.rsRegBtn.IconMarginLeft = 0;
            this.rsRegBtn.IconMarginRight = 0;
            this.rsRegBtn.IconRightVisible = true;
            this.rsRegBtn.IconRightZoom = 0D;
            this.rsRegBtn.IconVisible = true;
            this.rsRegBtn.IconZoom = 90D;
            this.rsRegBtn.IsTab = false;
            this.rsRegBtn.Location = new System.Drawing.Point(268, 249);
            this.rsRegBtn.Name = "rsRegBtn";
            this.rsRegBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.rsRegBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.rsRegBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.rsRegBtn.selected = false;
            this.rsRegBtn.Size = new System.Drawing.Size(241, 48);
            this.rsRegBtn.TabIndex = 12;
            this.rsRegBtn.Text = "Register";
            this.rsRegBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rsRegBtn.Textcolor = System.Drawing.Color.White;
            this.rsRegBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsRegBtn.Click += new System.EventHandler(this.rsRegBtn_Click);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(211, 175);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(140, 19);
            this.bunifuCustomLabel13.TabIndex = 11;
            this.bunifuCustomLabel13.Text = "Confirm Password";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(211, 97);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(77, 19);
            this.bunifuCustomLabel12.TabIndex = 10;
            this.bunifuCustomLabel12.Text = "Password";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(211, 20);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(87, 19);
            this.bunifuCustomLabel11.TabIndex = 9;
            this.bunifuCustomLabel11.Text = "UserName";
            // 
            // rsUserTxt
            // 
            this.rsUserTxt.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.rsUserTxt.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.rsUserTxt.BorderColorMouseHover = System.Drawing.Color.LightSteelBlue;
            this.rsUserTxt.BorderThickness = 3;
            this.rsUserTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rsUserTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rsUserTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rsUserTxt.isPassword = false;
            this.rsUserTxt.Location = new System.Drawing.Point(202, 42);
            this.rsUserTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rsUserTxt.Name = "rsUserTxt";
            this.rsUserTxt.Size = new System.Drawing.Size(370, 44);
            this.rsUserTxt.TabIndex = 6;
            this.rsUserTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rsSaveBtn
            // 
            this.rsSaveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rsSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rsSaveBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rsSaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rsSaveBtn.BorderRadius = 0;
            this.rsSaveBtn.ButtonText = "Save";
            this.rsSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rsSaveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.rsSaveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.rsSaveBtn.Iconimage = null;
            this.rsSaveBtn.Iconimage_right = null;
            this.rsSaveBtn.Iconimage_right_Selected = null;
            this.rsSaveBtn.Iconimage_Selected = null;
            this.rsSaveBtn.IconMarginLeft = 0;
            this.rsSaveBtn.IconMarginRight = 0;
            this.rsSaveBtn.IconRightVisible = true;
            this.rsSaveBtn.IconRightZoom = 0D;
            this.rsSaveBtn.IconVisible = true;
            this.rsSaveBtn.IconZoom = 90D;
            this.rsSaveBtn.IsTab = false;
            this.rsSaveBtn.Location = new System.Drawing.Point(149, 391);
            this.rsSaveBtn.Name = "rsSaveBtn";
            this.rsSaveBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.rsSaveBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.rsSaveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.rsSaveBtn.selected = false;
            this.rsSaveBtn.Size = new System.Drawing.Size(255, 36);
            this.rsSaveBtn.TabIndex = 60;
            this.rsSaveBtn.Text = "Save";
            this.rsSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rsSaveBtn.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.rsSaveBtn.TextFont = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsSaveBtn.Click += new System.EventHandler(this.rsSaveBtn_Click);
            // 
            // rsRoleCombo
            // 
            this.rsRoleCombo.FormattingEnabled = true;
            this.rsRoleCombo.ItemHeight = 23;
            this.rsRoleCombo.Items.AddRange(new object[] {
            "Management",
            "Security",
            "Cook",
            "Cleaning Staffs"});
            this.rsRoleCombo.Location = new System.Drawing.Point(526, 323);
            this.rsRoleCombo.Margin = new System.Windows.Forms.Padding(6);
            this.rsRoleCombo.Name = "rsRoleCombo";
            this.rsRoleCombo.Size = new System.Drawing.Size(250, 29);
            this.rsRoleCombo.TabIndex = 62;
            this.rsRoleCombo.UseSelectable = true;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(410, 328);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(41, 19);
            this.labelRole.TabIndex = 61;
            this.labelRole.Text = "Role";
            // 
            // StaffRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rsPanel2);
            this.Controls.Add(this.rsResetBtn);
            this.Controls.Add(this.rsResignDate);
            this.Controls.Add(this.rsJoinDate);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.rsGenderCombo);
            this.Controls.Add(this.rsDOBdate);
            this.Controls.Add(this.rsNIDtxt);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.rsAddressTxt);
            this.Controls.Add(this.rsMailTxt);
            this.Controls.Add(this.rsPhoneTxt);
            this.Controls.Add(this.rsNameTxt);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.rsPanel1);
            this.Controls.Add(this.rsSaveBtn);
            this.Controls.Add(this.rsRoleCombo);
            this.Controls.Add(this.labelRole);
            this.Name = "StaffRegister";
            this.Text = "StaffRegister";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffRegister_FormClosed);
            this.Load += new System.EventHandler(this.StaffRegister_Load);
            this.rsPanel1.ResumeLayout(false);
            this.rsPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgHomeBtn)).EndInit();
            this.rsPanel2.ResumeLayout(false);
            this.rsPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rsRegCloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rsPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroComboBox rsGenderCombo;
        private MetroFramework.Controls.MetroDateTime rsDOBdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsNIDtxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsAddressTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsMailTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsPhoneTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsNameTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private MetroFramework.Controls.MetroDateTime rsJoinDate;
        private MetroFramework.Controls.MetroDateTime rsResignDate;
        private Bunifu.Framework.UI.BunifuFlatButton rsResetBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton rgHomeBtn;
        private System.Windows.Forms.Panel rsPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsUserTxt;
        private Bunifu.Framework.UI.BunifuFlatButton rsRegBtn;
        private Bunifu.Framework.UI.BunifuImageButton rsRegCloseBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsPassConfTxt;
        private Bunifu.Framework.UI.BunifuMetroTextbox rsPassTxt;
        private Bunifu.Framework.UI.BunifuFlatButton rsSaveBtn;
        private MetroFramework.Controls.MetroComboBox rsRoleCombo;
        private Bunifu.Framework.UI.BunifuCustomLabel labelRole;
    }
}