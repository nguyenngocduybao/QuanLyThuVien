namespace QuanLyThuVien
{
    partial class frmSignupUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignupUser));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Pwd = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_Pwd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_ID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_UserName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_UserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_ID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_Signup = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_Add);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lb_Signup);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LawnGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 20;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(562, 453);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Activecolor = System.Drawing.Color.MediumBlue;
            this.btn_Add.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.ButtonText = "Đăng kí";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.SeaShell;
            this.btn_Add.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Add.Iconimage")));
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 0;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = true;
            this.btn_Add.IconRightZoom = 0D;
            this.btn_Add.IconVisible = true;
            this.btn_Add.IconZoom = 90D;
            this.btn_Add.IsTab = false;
            this.btn_Add.Location = new System.Drawing.Point(224, 384);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.SkyBlue;
            this.btn_Add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(142, 47);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Đăng kí";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Textcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tb_Pwd);
            this.groupBox1.Controls.Add(this.lb_Pwd);
            this.groupBox1.Controls.Add(this.lb_ID);
            this.groupBox1.Controls.Add(this.tb_UserName);
            this.groupBox1.Controls.Add(this.lb_UserName);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox1.Location = new System.Drawing.Point(72, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // tb_Pwd
            // 
            this.tb_Pwd.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_Pwd.Location = new System.Drawing.Point(167, 144);
            this.tb_Pwd.Name = "tb_Pwd";
            this.tb_Pwd.PasswordChar = '*';
            this.tb_Pwd.Size = new System.Drawing.Size(223, 35);
            this.tb_Pwd.TabIndex = 5;
            // 
            // lb_Pwd
            // 
            this.lb_Pwd.AutoSize = true;
            this.lb_Pwd.Location = new System.Drawing.Point(25, 147);
            this.lb_Pwd.Name = "lb_Pwd";
            this.lb_Pwd.Size = new System.Drawing.Size(115, 29);
            this.lb_Pwd.TabIndex = 4;
            this.lb_Pwd.Text = "Mật khẩu:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(25, 53);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(127, 29);
            this.lb_ID.TabIndex = 2;
            this.lb_ID.Text = "ID độc giả:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_UserName.Location = new System.Drawing.Point(167, 98);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(223, 35);
            this.tb_UserName.TabIndex = 1;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(25, 101);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(125, 29);
            this.lb_UserName.TabIndex = 0;
            this.lb_UserName.Text = "Tài khoản:";
            // 
            // tb_ID
            // 
            this.tb_ID.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ID.Location = new System.Drawing.Point(167, 50);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(223, 35);
            this.tb_ID.TabIndex = 3;
            // 
            // lb_Signup
            // 
            this.lb_Signup.AutoSize = true;
            this.lb_Signup.BackColor = System.Drawing.Color.Transparent;
            this.lb_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Signup.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_Signup.Location = new System.Drawing.Point(268, 79);
            this.lb_Signup.Name = "lb_Signup";
            this.lb_Signup.Size = new System.Drawing.Size(155, 46);
            this.lb_Signup.TabIndex = 1;
            this.lb_Signup.Text = "Sign up";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(153, 51);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(109, 91);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // frmSignupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 453);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmSignupUser";
            this.Text = "frmSignupUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSignupUser_FormClosing);
            this.Load += new System.EventHandler(this.frmSignupUser_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Signup;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_UserName;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_Pwd;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Pwd;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_ID;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_ID;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_UserName;
    }
}