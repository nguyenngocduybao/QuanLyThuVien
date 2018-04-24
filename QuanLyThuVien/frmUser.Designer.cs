namespace QuanLyThuVien
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grb_Control = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_EditUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_IDDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_Data = new System.Windows.Forms.GroupBox();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.grb_Info = new System.Windows.Forms.GroupBox();
            this.dtp_NgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.dtp_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbb_TypeReader = new System.Windows.Forms.ComboBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_NgayLapThe = new System.Windows.Forms.Label();
            this.lb_TypeReader = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_BirthDay = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Info = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grb_Control.SuspendLayout();
            this.grb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.grb_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.grb_Control);
            this.bunifuGradientPanel1.Controls.Add(this.grb_Data);
            this.bunifuGradientPanel1.Controls.Add(this.grb_Info);
            this.bunifuGradientPanel1.Controls.Add(this.lb_Info);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1259, 798);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // grb_Control
            // 
            this.grb_Control.BackColor = System.Drawing.Color.Transparent;
            this.grb_Control.Controls.Add(this.btn_Delete);
            this.grb_Control.Controls.Add(this.btn_Back);
            this.grb_Control.Controls.Add(this.btn_EditUser);
            this.grb_Control.Controls.Add(this.btn_Add);
            this.grb_Control.Controls.Add(this.tb_IDDel);
            this.grb_Control.Controls.Add(this.label1);
            this.grb_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Control.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Control.Location = new System.Drawing.Point(47, 578);
            this.grb_Control.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_Control.Name = "grb_Control";
            this.grb_Control.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_Control.Size = new System.Drawing.Size(488, 206);
            this.grb_Control.TabIndex = 7;
            this.grb_Control.TabStop = false;
            this.grb_Control.Text = "Xử lí";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.color = System.Drawing.Color.SeaGreen;
            this.btn_Delete.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = global::QuanLyThuVien.Properties.Resources.icons8_cancel_40;
            this.btn_Delete.ImagePosition = 20;
            this.btn_Delete.ImageZoom = 50;
            this.btn_Delete.LabelPosition = 41;
            this.btn_Delete.LabelText = "Xóa";
            this.btn_Delete.Location = new System.Drawing.Point(336, 123);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(81, 77);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Back.color = System.Drawing.Color.SeaGreen;
            this.btn_Back.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = global::QuanLyThuVien.Properties.Resources.icons8_back_64;
            this.btn_Back.ImagePosition = 20;
            this.btn_Back.ImageZoom = 50;
            this.btn_Back.LabelPosition = 41;
            this.btn_Back.LabelText = "Trở về";
            this.btn_Back.Location = new System.Drawing.Point(336, 26);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(81, 81);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_EditUser.color = System.Drawing.Color.SeaGreen;
            this.btn_EditUser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_EditUser.ForeColor = System.Drawing.Color.White;
            this.btn_EditUser.Image = global::QuanLyThuVien.Properties.Resources.icons8_pencil_30;
            this.btn_EditUser.ImagePosition = 20;
            this.btn_EditUser.ImageZoom = 50;
            this.btn_EditUser.LabelPosition = 41;
            this.btn_EditUser.LabelText = "Sửa";
            this.btn_EditUser.Location = new System.Drawing.Point(177, 26);
            this.btn_EditUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(86, 81);
            this.btn_EditUser.TabIndex = 17;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.color = System.Drawing.Color.SeaGreen;
            this.btn_Add.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::QuanLyThuVien.Properties.Resources.icons8_plus_40;
            this.btn_Add.ImagePosition = 20;
            this.btn_Add.ImageZoom = 50;
            this.btn_Add.LabelPosition = 41;
            this.btn_Add.LabelText = "Thêm";
            this.btn_Add.Location = new System.Drawing.Point(31, 26);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(79, 81);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_IDDel
            // 
            this.tb_IDDel.Location = new System.Drawing.Point(194, 150);
            this.tb_IDDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_IDDel.MaxLength = 3;
            this.tb_IDDel.Name = "tb_IDDel";
            this.tb_IDDel.Size = new System.Drawing.Size(123, 30);
            this.tb_IDDel.TabIndex = 5;
            this.tb_IDDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDDel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập ID cần xóa:";
            // 
            // grb_Data
            // 
            this.grb_Data.BackColor = System.Drawing.Color.Transparent;
            this.grb_Data.Controls.Add(this.dgv_User);
            this.grb_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Data.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Data.Location = new System.Drawing.Point(543, 79);
            this.grb_Data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_Data.Name = "grb_Data";
            this.grb_Data.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_Data.Size = new System.Drawing.Size(644, 699);
            this.grb_Data.TabIndex = 6;
            this.grb_Data.TabStop = false;
            this.grb_Data.Text = "Bảng thông tin độc giả";
            // 
            // dgv_User
            // 
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(19, 27);
            this.dgv_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.RowTemplate.Height = 28;
            this.dgv_User.Size = new System.Drawing.Size(621, 668);
            this.dgv_User.TabIndex = 0;
            // 
            // grb_Info
            // 
            this.grb_Info.BackColor = System.Drawing.Color.Transparent;
            this.grb_Info.Controls.Add(this.dtp_NgayLapThe);
            this.grb_Info.Controls.Add(this.dtp_BirthDay);
            this.grb_Info.Controls.Add(this.cbb_TypeReader);
            this.grb_Info.Controls.Add(this.tb_Address);
            this.grb_Info.Controls.Add(this.tb_Email);
            this.grb_Info.Controls.Add(this.tb_Name);
            this.grb_Info.Controls.Add(this.tb_ID);
            this.grb_Info.Controls.Add(this.lb_Address);
            this.grb_Info.Controls.Add(this.lb_NgayLapThe);
            this.grb_Info.Controls.Add(this.lb_TypeReader);
            this.grb_Info.Controls.Add(this.lb_Email);
            this.grb_Info.Controls.Add(this.lb_BirthDay);
            this.grb_Info.Controls.Add(this.lb_Name);
            this.grb_Info.Controls.Add(this.lb_ID);
            this.grb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Info.Location = new System.Drawing.Point(47, 70);
            this.grb_Info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_Info.Name = "grb_Info";
            this.grb_Info.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_Info.Size = new System.Drawing.Size(461, 498);
            this.grb_Info.TabIndex = 5;
            this.grb_Info.TabStop = false;
            this.grb_Info.Text = "Nhập thông tin độc giả";
            // 
            // dtp_NgayLapThe
            // 
            this.dtp_NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapThe.Location = new System.Drawing.Point(177, 390);
            this.dtp_NgayLapThe.Name = "dtp_NgayLapThe";
            this.dtp_NgayLapThe.Size = new System.Drawing.Size(265, 30);
            this.dtp_NgayLapThe.TabIndex = 17;
            // 
            // dtp_BirthDay
            // 
            this.dtp_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BirthDay.Location = new System.Drawing.Point(177, 195);
            this.dtp_BirthDay.Name = "dtp_BirthDay";
            this.dtp_BirthDay.Size = new System.Drawing.Size(265, 30);
            this.dtp_BirthDay.TabIndex = 16;
            // 
            // cbb_TypeReader
            // 
            this.cbb_TypeReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TypeReader.FormattingEnabled = true;
            this.cbb_TypeReader.Items.AddRange(new object[] {
            "LDG01",
            "LDG02"});
            this.cbb_TypeReader.Location = new System.Drawing.Point(177, 325);
            this.cbb_TypeReader.Name = "cbb_TypeReader";
            this.cbb_TypeReader.Size = new System.Drawing.Size(265, 33);
            this.cbb_TypeReader.TabIndex = 13;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(177, 455);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(265, 30);
            this.tb_Address.TabIndex = 10;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(177, 260);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(265, 30);
            this.tb_Email.TabIndex = 9;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(177, 130);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(265, 30);
            this.tb_Name.TabIndex = 8;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(177, 65);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ID.MaxLength = 3;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(265, 30);
            this.tb_ID.TabIndex = 7;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(21, 455);
            this.lb_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(85, 25);
            this.lb_Address.TabIndex = 6;
            this.lb_Address.Text = "Địa chỉ:";
            // 
            // lb_NgayLapThe
            // 
            this.lb_NgayLapThe.AutoSize = true;
            this.lb_NgayLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayLapThe.Location = new System.Drawing.Point(21, 390);
            this.lb_NgayLapThe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NgayLapThe.Name = "lb_NgayLapThe";
            this.lb_NgayLapThe.Size = new System.Drawing.Size(140, 25);
            this.lb_NgayLapThe.TabIndex = 5;
            this.lb_NgayLapThe.Text = "Ngày lập thẻ:";
            // 
            // lb_TypeReader
            // 
            this.lb_TypeReader.AutoSize = true;
            this.lb_TypeReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypeReader.Location = new System.Drawing.Point(21, 325);
            this.lb_TypeReader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TypeReader.Name = "lb_TypeReader";
            this.lb_TypeReader.Size = new System.Drawing.Size(136, 25);
            this.lb_TypeReader.TabIndex = 4;
            this.lb_TypeReader.Text = "Loại độc giả:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(21, 260);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(72, 25);
            this.lb_Email.TabIndex = 3;
            this.lb_Email.Text = "Email:";
            // 
            // lb_BirthDay
            // 
            this.lb_BirthDay.AutoSize = true;
            this.lb_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BirthDay.Location = new System.Drawing.Point(21, 195);
            this.lb_BirthDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BirthDay.Name = "lb_BirthDay";
            this.lb_BirthDay.Size = new System.Drawing.Size(115, 25);
            this.lb_BirthDay.TabIndex = 2;
            this.lb_BirthDay.Text = "Ngày sinh:";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(21, 130);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(111, 25);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Họ và tên:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(21, 65);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(40, 25);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID:";
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.BackColor = System.Drawing.Color.Transparent;
            this.lb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info.ForeColor = System.Drawing.Color.Blue;
            this.lb_Info.Location = new System.Drawing.Point(413, 5);
            this.lb_Info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(327, 46);
            this.lb_Info.TabIndex = 4;
            this.lb_Info.Text = "Thông tin độc giả";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(911, 484);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grb_Control.ResumeLayout(false);
            this.grb_Control.PerformLayout();
            this.grb_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.grb_Info.ResumeLayout(false);
            this.grb_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grb_Control;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private Bunifu.Framework.UI.BunifuTileButton btn_EditUser;
        private Bunifu.Framework.UI.BunifuTileButton btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_Data;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.GroupBox grb_Info;
        private System.Windows.Forms.ComboBox cbb_TypeReader;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_NgayLapThe;
        private System.Windows.Forms.Label lb_TypeReader;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_BirthDay;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.TextBox tb_IDDel;
        private System.Windows.Forms.DateTimePicker dtp_BirthDay;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapThe;
    }
}