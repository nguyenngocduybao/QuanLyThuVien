namespace QuanLyThuVien
{
    partial class frmInfoUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoUser));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Add = new Bunifu.Framework.UI.BunifuImageButton();
            this.grb_Info = new System.Windows.Forms.GroupBox();
            this.tb_Address = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_DiaChi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtp_NgayLapThe = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lb_NgayLapThe = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbb_TypeReader = new System.Windows.Forms.ComboBox();
            this.lb_LoaiDocGia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_Email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_Email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtp_BirthDay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lb_NgaySinh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_Name = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_Name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_ID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lb_IDDocGia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_Info = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            this.grb_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_Add);
            this.bunifuGradientPanel1.Controls.Add(this.grb_Info);
            this.bunifuGradientPanel1.Controls.Add(this.lb_Info);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Chartreuse;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(644, 734);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageActive = null;
            this.btn_Add.Location = new System.Drawing.Point(274, 610);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 90);
            this.btn_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Add.TabIndex = 3;
            this.btn_Add.TabStop = false;
            this.btn_Add.Zoom = 10;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grb_Info
            // 
            this.grb_Info.BackColor = System.Drawing.Color.Transparent;
            this.grb_Info.Controls.Add(this.tb_Address);
            this.grb_Info.Controls.Add(this.lb_DiaChi);
            this.grb_Info.Controls.Add(this.dtp_NgayLapThe);
            this.grb_Info.Controls.Add(this.lb_NgayLapThe);
            this.grb_Info.Controls.Add(this.cbb_TypeReader);
            this.grb_Info.Controls.Add(this.lb_LoaiDocGia);
            this.grb_Info.Controls.Add(this.tb_Email);
            this.grb_Info.Controls.Add(this.lb_Email);
            this.grb_Info.Controls.Add(this.dtp_BirthDay);
            this.grb_Info.Controls.Add(this.lb_NgaySinh);
            this.grb_Info.Controls.Add(this.tb_Name);
            this.grb_Info.Controls.Add(this.lb_Name);
            this.grb_Info.Controls.Add(this.tb_ID);
            this.grb_Info.Controls.Add(this.lb_IDDocGia);
            this.grb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Info.ForeColor = System.Drawing.Color.SpringGreen;
            this.grb_Info.Location = new System.Drawing.Point(96, 188);
            this.grb_Info.Name = "grb_Info";
            this.grb_Info.Size = new System.Drawing.Size(464, 391);
            this.grb_Info.TabIndex = 2;
            this.grb_Info.TabStop = false;
            this.grb_Info.Text = "Nhập thông tin độc giả:";
            // 
            // tb_Address
            // 
            this.tb_Address.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_Address.Location = new System.Drawing.Point(178, 329);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(223, 35);
            this.tb_Address.TabIndex = 13;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(19, 332);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(92, 29);
            this.lb_DiaChi.TabIndex = 12;
            this.lb_DiaChi.Text = "Địa chỉ:";
            // 
            // dtp_NgayLapThe
            // 
            this.dtp_NgayLapThe.BackColor = System.Drawing.Color.SeaGreen;
            this.dtp_NgayLapThe.BorderRadius = 0;
            this.dtp_NgayLapThe.ForeColor = System.Drawing.Color.White;
            this.dtp_NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapThe.FormatCustom = null;
            this.dtp_NgayLapThe.Location = new System.Drawing.Point(178, 285);
            this.dtp_NgayLapThe.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtp_NgayLapThe.Name = "dtp_NgayLapThe";
            this.dtp_NgayLapThe.Size = new System.Drawing.Size(223, 37);
            this.dtp_NgayLapThe.TabIndex = 11;
            this.dtp_NgayLapThe.Value = new System.DateTime(2018, 4, 17, 11, 41, 53, 660);
            // 
            // lb_NgayLapThe
            // 
            this.lb_NgayLapThe.AutoSize = true;
            this.lb_NgayLapThe.Location = new System.Drawing.Point(19, 285);
            this.lb_NgayLapThe.Name = "lb_NgayLapThe";
            this.lb_NgayLapThe.Size = new System.Drawing.Size(153, 29);
            this.lb_NgayLapThe.TabIndex = 10;
            this.lb_NgayLapThe.Text = "Ngày lập thẻ:";
            // 
            // cbb_TypeReader
            // 
            this.cbb_TypeReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TypeReader.FormattingEnabled = true;
            this.cbb_TypeReader.Items.AddRange(new object[] {
            "LDG01",
            "LDG02"});
            this.cbb_TypeReader.Location = new System.Drawing.Point(178, 236);
            this.cbb_TypeReader.Name = "cbb_TypeReader";
            this.cbb_TypeReader.Size = new System.Drawing.Size(223, 37);
            this.cbb_TypeReader.TabIndex = 9;
            // 
            // lb_LoaiDocGia
            // 
            this.lb_LoaiDocGia.AutoSize = true;
            this.lb_LoaiDocGia.Location = new System.Drawing.Point(19, 239);
            this.lb_LoaiDocGia.Name = "lb_LoaiDocGia";
            this.lb_LoaiDocGia.Size = new System.Drawing.Size(150, 29);
            this.lb_LoaiDocGia.TabIndex = 8;
            this.lb_LoaiDocGia.Text = "Loại độc giả:";
            // 
            // tb_Email
            // 
            this.tb_Email.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_Email.Location = new System.Drawing.Point(178, 189);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(223, 35);
            this.tb_Email.TabIndex = 7;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(19, 195);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(80, 29);
            this.lb_Email.TabIndex = 6;
            this.lb_Email.Text = "Email:";
            // 
            // dtp_BirthDay
            // 
            this.dtp_BirthDay.BackColor = System.Drawing.Color.SeaGreen;
            this.dtp_BirthDay.BorderRadius = 0;
            this.dtp_BirthDay.ForeColor = System.Drawing.Color.White;
            this.dtp_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BirthDay.FormatCustom = null;
            this.dtp_BirthDay.Location = new System.Drawing.Point(178, 151);
            this.dtp_BirthDay.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtp_BirthDay.Name = "dtp_BirthDay";
            this.dtp_BirthDay.Size = new System.Drawing.Size(223, 29);
            this.dtp_BirthDay.TabIndex = 5;
            this.dtp_BirthDay.Value = new System.DateTime(2018, 4, 17, 11, 30, 19, 798);
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(19, 151);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(125, 29);
            this.lb_NgaySinh.TabIndex = 4;
            this.lb_NgaySinh.Text = "Ngày sinh:";
            // 
            // tb_Name
            // 
            this.tb_Name.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_Name.Location = new System.Drawing.Point(178, 99);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(223, 35);
            this.tb_Name.TabIndex = 3;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(19, 102);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(119, 29);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Họ và tên:";
            // 
            // tb_ID
            // 
            this.tb_ID.BorderColor = System.Drawing.Color.SeaGreen;
            this.tb_ID.Location = new System.Drawing.Point(178, 50);
            this.tb_ID.MaxLength = 3;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(223, 35);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lb_IDDocGia
            // 
            this.lb_IDDocGia.AutoSize = true;
            this.lb_IDDocGia.Location = new System.Drawing.Point(19, 50);
            this.lb_IDDocGia.Name = "lb_IDDocGia";
            this.lb_IDDocGia.Size = new System.Drawing.Size(42, 29);
            this.lb_IDDocGia.TabIndex = 0;
            this.lb_IDDocGia.Text = "ID:";
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.BackColor = System.Drawing.Color.Transparent;
            this.lb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_Info.Location = new System.Drawing.Point(233, 113);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(327, 46);
            this.lb_Info.TabIndex = 1;
            this.lb_Info.Text = "Thông tin độc giả";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(96, 85);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(131, 97);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // frmInfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 734);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmInfoUser";
            this.Text = "frmInfoUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInfoUser_FormClosing);
            this.Load += new System.EventHandler(this.frmInfoUser_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            this.grb_Info.ResumeLayout(false);
            this.grb_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grb_Info;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_IDDocGia;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Info;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_ID;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Name;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_Name;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_NgaySinh;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_BirthDay;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_Email;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_Email;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_LoaiDocGia;
        public System.Windows.Forms.ComboBox cbb_TypeReader;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_NgayLapThe;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_NgayLapThe;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_DiaChi;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tb_Address;
        private Bunifu.Framework.UI.BunifuImageButton btn_Add;
    }
}