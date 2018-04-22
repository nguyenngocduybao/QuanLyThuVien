using System;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tb_Pwd = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tb_UserName = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_SigninAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Signup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Signin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.tb_Pwd);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Controls.Add(this.tb_UserName);
            this.bunifuGradientPanel1.Controls.Add(this.btn_SigninAdmin);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Signup);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Signin);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(592, 625);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pwd.Location = new System.Drawing.Point(122, 316);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.PasswordChar = '*';
            this.tb_Pwd.Size = new System.Drawing.Size(375, 41);
            this.tb_Pwd.TabIndex = 6;
            this.tb_Pwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Pwd_MouseClick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(196, 42);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(230, 162);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // tb_UserName
            // 
            this.tb_UserName.BackColor = System.Drawing.Color.Silver;
            this.tb_UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_UserName.BackgroundImage")));
            this.tb_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_UserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tb_UserName.Icon = ((System.Drawing.Image)(resources.GetObject("tb_UserName.Icon")));
            this.tb_UserName.Location = new System.Drawing.Point(122, 211);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(375, 65);
            this.tb_UserName.TabIndex = 3;
            this.tb_UserName.text = "username";
            this.tb_UserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_UserName_MouseClick);
            // 
            // btn_SigninAdmin
            // 
            this.btn_SigninAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SigninAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SigninAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SigninAdmin.BorderRadius = 0;
            this.btn_SigninAdmin.ButtonText = "Sign in Admin";
            this.btn_SigninAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SigninAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SigninAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SigninAdmin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_SigninAdmin.Iconimage")));
            this.btn_SigninAdmin.Iconimage_right = null;
            this.btn_SigninAdmin.Iconimage_right_Selected = null;
            this.btn_SigninAdmin.Iconimage_Selected = null;
            this.btn_SigninAdmin.IconMarginLeft = 0;
            this.btn_SigninAdmin.IconMarginRight = 0;
            this.btn_SigninAdmin.IconRightVisible = true;
            this.btn_SigninAdmin.IconRightZoom = 0D;
            this.btn_SigninAdmin.IconVisible = true;
            this.btn_SigninAdmin.IconZoom = 90D;
            this.btn_SigninAdmin.IsTab = false;
            this.btn_SigninAdmin.Location = new System.Drawing.Point(220, 525);
            this.btn_SigninAdmin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_SigninAdmin.Name = "btn_SigninAdmin";
            this.btn_SigninAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SigninAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_SigninAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SigninAdmin.selected = false;
            this.btn_SigninAdmin.Size = new System.Drawing.Size(188, 52);
            this.btn_SigninAdmin.TabIndex = 2;
            this.btn_SigninAdmin.Text = "Sign in Admin";
            this.btn_SigninAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SigninAdmin.Textcolor = System.Drawing.Color.White;
            this.btn_SigninAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SigninAdmin.Click += new System.EventHandler(this.btn_SigninAdmin_Click);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Signup.BorderRadius = 0;
            this.btn_Signup.ButtonText = "Sign up";
            this.btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signup.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Signup.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Signup.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Signup.Iconimage")));
            this.btn_Signup.Iconimage_right = null;
            this.btn_Signup.Iconimage_right_Selected = null;
            this.btn_Signup.Iconimage_Selected = null;
            this.btn_Signup.IconMarginLeft = 0;
            this.btn_Signup.IconMarginRight = 0;
            this.btn_Signup.IconRightVisible = true;
            this.btn_Signup.IconRightZoom = 0D;
            this.btn_Signup.IconVisible = true;
            this.btn_Signup.IconZoom = 90D;
            this.btn_Signup.IsTab = false;
            this.btn_Signup.Location = new System.Drawing.Point(220, 463);
            this.btn_Signup.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Signup.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Signup.selected = false;
            this.btn_Signup.Size = new System.Drawing.Size(188, 52);
            this.btn_Signup.TabIndex = 1;
            this.btn_Signup.Text = "Sign up";
            this.btn_Signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Signup.Textcolor = System.Drawing.Color.White;
            this.btn_Signup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // btn_Signin
            // 
            this.btn_Signin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Signin.BorderRadius = 0;
            this.btn_Signin.ButtonText = "Sign in";
            this.btn_Signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signin.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Signin.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Signin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Signin.Iconimage")));
            this.btn_Signin.Iconimage_right = null;
            this.btn_Signin.Iconimage_right_Selected = null;
            this.btn_Signin.Iconimage_Selected = null;
            this.btn_Signin.IconMarginLeft = 0;
            this.btn_Signin.IconMarginRight = 0;
            this.btn_Signin.IconRightVisible = true;
            this.btn_Signin.IconRightZoom = 0D;
            this.btn_Signin.IconVisible = true;
            this.btn_Signin.IconZoom = 90D;
            this.btn_Signin.IsTab = false;
            this.btn_Signin.Location = new System.Drawing.Point(220, 402);
            this.btn_Signin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_Signin.Name = "btn_Signin";
            this.btn_Signin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Signin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Signin.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Signin.selected = false;
            this.btn_Signin.Size = new System.Drawing.Size(188, 52);
            this.btn_Signin.TabIndex = 0;
            this.btn_Signin.Text = "Sign in";
            this.btn_Signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Signin.Textcolor = System.Drawing.Color.White;
            this.btn_Signin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signin.Click += new System.EventHandler(this.btn_Signin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 625);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmLogin";
            this.Text = "Đăng nhập";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTextbox tb_UserName;
        private Bunifu.Framework.UI.BunifuFlatButton btn_SigninAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Signup;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Signin;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private TextBox tb_Pwd;
    }
}