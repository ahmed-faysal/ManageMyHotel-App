namespace MyHotelApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.forgotBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.loginBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Moire", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(349, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Pleasure Our Responsibility";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(100, 20);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(395, 61);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Hotel De Heaven";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.passwordTxt);
            this.panel2.Controls.Add(this.usernameTxt);
            this.panel2.Controls.Add(this.forgotBtn);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 320);
            this.panel2.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTxt.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTxt.HintText = "";
            this.passwordTxt.isPassword = true;
            this.passwordTxt.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.passwordTxt.LineIdleColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.passwordTxt.LineThickness = 3;
            this.passwordTxt.Location = new System.Drawing.Point(111, 160);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(379, 33);
            this.passwordTxt.TabIndex = 7;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.usernameTxt.HintText = "";
            this.usernameTxt.isPassword = false;
            this.usernameTxt.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.usernameTxt.LineIdleColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.usernameTxt.LineThickness = 3;
            this.usernameTxt.Location = new System.Drawing.Point(111, 77);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(379, 33);
            this.usernameTxt.TabIndex = 6;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // forgotBtn
            // 
            this.forgotBtn.ActiveBorderThickness = 1;
            this.forgotBtn.ActiveCornerRadius = 20;
            this.forgotBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.forgotBtn.ActiveForecolor = System.Drawing.Color.Silver;
            this.forgotBtn.ActiveLineColor = System.Drawing.Color.Transparent;
            this.forgotBtn.BackColor = System.Drawing.Color.SlateGray;
            this.forgotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forgotBtn.BackgroundImage")));
            this.forgotBtn.ButtonText = "Forgot Password ?";
            this.forgotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.forgotBtn.IdleBorderThickness = 1;
            this.forgotBtn.IdleCornerRadius = 20;
            this.forgotBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.forgotBtn.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.forgotBtn.IdleLineColor = System.Drawing.Color.Transparent;
            this.forgotBtn.Location = new System.Drawing.Point(219, 254);
            this.forgotBtn.Margin = new System.Windows.Forms.Padding(5);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Size = new System.Drawing.Size(181, 41);
            this.forgotBtn.TabIndex = 5;
            this.forgotBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.BorderRadius = 0;
            this.loginBtn.ButtonText = "Log In";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DisabledColor = System.Drawing.Color.Gray;
            this.loginBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.loginBtn.Iconimage = null;
            this.loginBtn.Iconimage_right = null;
            this.loginBtn.Iconimage_right_Selected = null;
            this.loginBtn.Iconimage_Selected = null;
            this.loginBtn.IconMarginLeft = 0;
            this.loginBtn.IconMarginRight = 0;
            this.loginBtn.IconRightVisible = true;
            this.loginBtn.IconRightZoom = 0D;
            this.loginBtn.IconVisible = true;
            this.loginBtn.IconZoom = 90D;
            this.loginBtn.IsTab = false;
            this.loginBtn.Location = new System.Drawing.Point(187, 200);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.loginBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.loginBtn.selected = false;
            this.loginBtn.Size = new System.Drawing.Size(241, 48);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Log In";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Textcolor = System.Drawing.Color.White;
            this.loginBtn.TextFont = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(108, 137);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(77, 19);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Miramonte", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(107, 54);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 forgotBtn;
        private Bunifu.Framework.UI.BunifuFlatButton loginBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

