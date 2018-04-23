namespace QuanLyThuVien
{
    partial class frmAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBook));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.grb_DataBook = new System.Windows.Forms.GroupBox();
            this.dgv_AddBook = new System.Windows.Forms.DataGridView();
            this.grb_InfoBook = new System.Windows.Forms.GroupBox();
            this.lb_ThongTin = new System.Windows.Forms.Label();
            this.lb_IDDauSach = new System.Windows.Forms.Label();
            this.tb_IDDauSach = new System.Windows.Forms.TextBox();
            this.lb_TenSach = new System.Windows.Forms.Label();
            this.lb_LoaiSach = new System.Windows.Forms.Label();
            this.lb_IDSach = new System.Windows.Forms.Label();
            this.lb_NXB = new System.Windows.Forms.Label();
            this.lb_YXB = new System.Windows.Forms.Label();
            this.lb_SoLuongTon = new System.Windows.Forms.Label();
            this.lb_GiaTien = new System.Windows.Forms.Label();
            this.tb_TenSach = new System.Windows.Forms.TextBox();
            this.cb_LoaiSach = new System.Windows.Forms.ComboBox();
            this.tb_IDSach = new System.Windows.Forms.TextBox();
            this.tb_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.dtp_NXB = new System.Windows.Forms.DateTimePicker();
            this.tb_SoLuongTon = new System.Windows.Forms.TextBox();
            this.tb_GiaTien = new System.Windows.Forms.TextBox();
            this.btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.lb_IDDelete = new System.Windows.Forms.Label();
            this.tb_IDDelete = new System.Windows.Forms.TextBox();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grb_DieuKhien.SuspendLayout();
            this.grb_DataBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddBook)).BeginInit();
            this.grb_InfoBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.grb_DieuKhien);
            this.bunifuGradientPanel1.Controls.Add(this.grb_DataBook);
            this.bunifuGradientPanel1.Controls.Add(this.grb_InfoBook);
            this.bunifuGradientPanel1.Controls.Add(this.lb_ThongTin);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1693, 973);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.btn_Delete);
            this.grb_DieuKhien.Controls.Add(this.tb_IDDelete);
            this.grb_DieuKhien.Controls.Add(this.lb_IDDelete);
            this.grb_DieuKhien.Controls.Add(this.btn_Back);
            this.grb_DieuKhien.Controls.Add(this.btn_Edit);
            this.grb_DieuKhien.Controls.Add(this.btn_Add);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(25, 616);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(556, 350);
            this.grb_DieuKhien.TabIndex = 7;
            this.grb_DieuKhien.TabStop = false;
            this.grb_DieuKhien.Text = "Xử lí";
            // 
            // grb_DataBook
            // 
            this.grb_DataBook.Controls.Add(this.dgv_AddBook);
            this.grb_DataBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataBook.Location = new System.Drawing.Point(603, 119);
            this.grb_DataBook.Name = "grb_DataBook";
            this.grb_DataBook.Size = new System.Drawing.Size(1080, 847);
            this.grb_DataBook.TabIndex = 6;
            this.grb_DataBook.TabStop = false;
            this.grb_DataBook.Text = "Bảng thông tin sách";
            // 
            // dgv_AddBook
            // 
            this.dgv_AddBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AddBook.Location = new System.Drawing.Point(8, 42);
            this.dgv_AddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_AddBook.Name = "dgv_AddBook";
            this.dgv_AddBook.Size = new System.Drawing.Size(1066, 797);
            this.dgv_AddBook.TabIndex = 0;
            // 
            // grb_InfoBook
            // 
            this.grb_InfoBook.Controls.Add(this.tb_GiaTien);
            this.grb_InfoBook.Controls.Add(this.tb_SoLuongTon);
            this.grb_InfoBook.Controls.Add(this.dtp_NXB);
            this.grb_InfoBook.Controls.Add(this.tb_NhaXuatBan);
            this.grb_InfoBook.Controls.Add(this.tb_IDSach);
            this.grb_InfoBook.Controls.Add(this.cb_LoaiSach);
            this.grb_InfoBook.Controls.Add(this.tb_TenSach);
            this.grb_InfoBook.Controls.Add(this.lb_GiaTien);
            this.grb_InfoBook.Controls.Add(this.lb_SoLuongTon);
            this.grb_InfoBook.Controls.Add(this.lb_YXB);
            this.grb_InfoBook.Controls.Add(this.lb_NXB);
            this.grb_InfoBook.Controls.Add(this.lb_IDSach);
            this.grb_InfoBook.Controls.Add(this.lb_LoaiSach);
            this.grb_InfoBook.Controls.Add(this.lb_TenSach);
            this.grb_InfoBook.Controls.Add(this.tb_IDDauSach);
            this.grb_InfoBook.Controls.Add(this.lb_IDDauSach);
            this.grb_InfoBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_InfoBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_InfoBook.Location = new System.Drawing.Point(25, 119);
            this.grb_InfoBook.Name = "grb_InfoBook";
            this.grb_InfoBook.Size = new System.Drawing.Size(556, 473);
            this.grb_InfoBook.TabIndex = 5;
            this.grb_InfoBook.TabStop = false;
            this.grb_InfoBook.Text = "Nhập thông tin sách";
            // 
            // lb_ThongTin
            // 
            this.lb_ThongTin.AutoSize = true;
            this.lb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_ThongTin.Location = new System.Drawing.Point(712, 27);
            this.lb_ThongTin.Name = "lb_ThongTin";
            this.lb_ThongTin.Size = new System.Drawing.Size(421, 69);
            this.lb_ThongTin.TabIndex = 4;
            this.lb_ThongTin.Text = "Thông tin sách";
            // 
            // lb_IDDauSach
            // 
            this.lb_IDDauSach.AutoSize = true;
            this.lb_IDDauSach.Location = new System.Drawing.Point(13, 54);
            this.lb_IDDauSach.Name = "lb_IDDauSach";
            this.lb_IDDauSach.Size = new System.Drawing.Size(193, 36);
            this.lb_IDDauSach.TabIndex = 0;
            this.lb_IDDauSach.Text = "ID đầu sách:";
            // 
            // tb_IDDauSach
            // 
            this.tb_IDDauSach.Location = new System.Drawing.Point(240, 51);
            this.tb_IDDauSach.Name = "tb_IDDauSach";
            this.tb_IDDauSach.Size = new System.Drawing.Size(261, 41);
            this.tb_IDDauSach.TabIndex = 1;
            // 
            // lb_TenSach
            // 
            this.lb_TenSach.AutoSize = true;
            this.lb_TenSach.Location = new System.Drawing.Point(13, 104);
            this.lb_TenSach.Name = "lb_TenSach";
            this.lb_TenSach.Size = new System.Drawing.Size(154, 36);
            this.lb_TenSach.TabIndex = 2;
            this.lb_TenSach.Text = "Tên sách:";
            // 
            // lb_LoaiSach
            // 
            this.lb_LoaiSach.AutoSize = true;
            this.lb_LoaiSach.Location = new System.Drawing.Point(13, 153);
            this.lb_LoaiSach.Name = "lb_LoaiSach";
            this.lb_LoaiSach.Size = new System.Drawing.Size(161, 36);
            this.lb_LoaiSach.TabIndex = 3;
            this.lb_LoaiSach.Text = "Loại sách:";
            // 
            // lb_IDSach
            // 
            this.lb_IDSach.AutoSize = true;
            this.lb_IDSach.Location = new System.Drawing.Point(13, 204);
            this.lb_IDSach.Name = "lb_IDSach";
            this.lb_IDSach.Size = new System.Drawing.Size(131, 36);
            this.lb_IDSach.TabIndex = 4;
            this.lb_IDSach.Text = "ID sách:";
            // 
            // lb_NXB
            // 
            this.lb_NXB.AutoSize = true;
            this.lb_NXB.Location = new System.Drawing.Point(13, 253);
            this.lb_NXB.Name = "lb_NXB";
            this.lb_NXB.Size = new System.Drawing.Size(213, 36);
            this.lb_NXB.TabIndex = 5;
            this.lb_NXB.Text = "Nhà xuất bản:";
            // 
            // lb_YXB
            // 
            this.lb_YXB.AutoSize = true;
            this.lb_YXB.Location = new System.Drawing.Point(13, 303);
            this.lb_YXB.Name = "lb_YXB";
            this.lb_YXB.Size = new System.Drawing.Size(219, 36);
            this.lb_YXB.TabIndex = 6;
            this.lb_YXB.Text = "Năm xuất bản:";
            // 
            // lb_SoLuongTon
            // 
            this.lb_SoLuongTon.AutoSize = true;
            this.lb_SoLuongTon.Location = new System.Drawing.Point(13, 353);
            this.lb_SoLuongTon.Name = "lb_SoLuongTon";
            this.lb_SoLuongTon.Size = new System.Drawing.Size(206, 36);
            this.lb_SoLuongTon.TabIndex = 7;
            this.lb_SoLuongTon.Text = "Số lượng tồn:";
            // 
            // lb_GiaTien
            // 
            this.lb_GiaTien.AutoSize = true;
            this.lb_GiaTien.Location = new System.Drawing.Point(13, 405);
            this.lb_GiaTien.Name = "lb_GiaTien";
            this.lb_GiaTien.Size = new System.Drawing.Size(134, 36);
            this.lb_GiaTien.TabIndex = 8;
            this.lb_GiaTien.Text = "Giá tiền:";
            // 
            // tb_TenSach
            // 
            this.tb_TenSach.Location = new System.Drawing.Point(240, 101);
            this.tb_TenSach.Name = "tb_TenSach";
            this.tb_TenSach.Size = new System.Drawing.Size(261, 41);
            this.tb_TenSach.TabIndex = 10;
            // 
            // cb_LoaiSach
            // 
            this.cb_LoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LoaiSach.FormattingEnabled = true;
            this.cb_LoaiSach.Location = new System.Drawing.Point(240, 150);
            this.cb_LoaiSach.Name = "cb_LoaiSach";
            this.cb_LoaiSach.Size = new System.Drawing.Size(261, 44);
            this.cb_LoaiSach.TabIndex = 11;
            // 
            // tb_IDSach
            // 
            this.tb_IDSach.Location = new System.Drawing.Point(240, 201);
            this.tb_IDSach.Name = "tb_IDSach";
            this.tb_IDSach.Size = new System.Drawing.Size(261, 41);
            this.tb_IDSach.TabIndex = 12;
            // 
            // tb_NhaXuatBan
            // 
            this.tb_NhaXuatBan.Location = new System.Drawing.Point(240, 250);
            this.tb_NhaXuatBan.Name = "tb_NhaXuatBan";
            this.tb_NhaXuatBan.Size = new System.Drawing.Size(261, 41);
            this.tb_NhaXuatBan.TabIndex = 13;
            // 
            // dtp_NXB
            // 
            this.dtp_NXB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NXB.Location = new System.Drawing.Point(240, 299);
            this.dtp_NXB.Name = "dtp_NXB";
            this.dtp_NXB.Size = new System.Drawing.Size(261, 41);
            this.dtp_NXB.TabIndex = 14;
            // 
            // tb_SoLuongTon
            // 
            this.tb_SoLuongTon.Location = new System.Drawing.Point(240, 350);
            this.tb_SoLuongTon.Name = "tb_SoLuongTon";
            this.tb_SoLuongTon.Size = new System.Drawing.Size(261, 41);
            this.tb_SoLuongTon.TabIndex = 15;
            this.tb_SoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDBook_KeyPress);
            // 
            // tb_GiaTien
            // 
            this.tb_GiaTien.Location = new System.Drawing.Point(240, 402);
            this.tb_GiaTien.Name = "tb_GiaTien";
            this.tb_GiaTien.Size = new System.Drawing.Size(261, 41);
            this.tb_GiaTien.TabIndex = 16;
            this.tb_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDBook_KeyPress);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Add.color = System.Drawing.Color.SeaGreen;
            this.btn_Add.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::QuanLyThuVien.Properties.Resources.icons8_plus_48;
            this.btn_Add.ImagePosition = 20;
            this.btn_Add.ImageZoom = 50;
            this.btn_Add.LabelPosition = 41;
            this.btn_Add.LabelText = "Thêm";
            this.btn_Add.Location = new System.Drawing.Point(30, 60);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 129);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.color = System.Drawing.Color.SeaGreen;
            this.btn_Edit.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = global::QuanLyThuVien.Properties.Resources.icons8_pencil_30;
            this.btn_Edit.ImagePosition = 20;
            this.btn_Edit.ImageZoom = 50;
            this.btn_Edit.LabelPosition = 41;
            this.btn_Edit.LabelText = "Sửa";
            this.btn_Edit.Location = new System.Drawing.Point(199, 60);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(128, 129);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Click += new System.EventHandler(this.btn_EditBook_Click);
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
            this.btn_Back.Location = new System.Drawing.Point(365, 57);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(128, 132);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lb_IDDelete
            // 
            this.lb_IDDelete.AutoSize = true;
            this.lb_IDDelete.Location = new System.Drawing.Point(24, 216);
            this.lb_IDDelete.Name = "lb_IDDelete";
            this.lb_IDDelete.Size = new System.Drawing.Size(315, 36);
            this.lb_IDDelete.TabIndex = 3;
            this.lb_IDDelete.Text = "Nhập ID sách cần xóa:";
            // 
            // tb_IDDelete
            // 
            this.tb_IDDelete.Location = new System.Drawing.Point(30, 275);
            this.tb_IDDelete.Name = "tb_IDDelete";
            this.tb_IDDelete.Size = new System.Drawing.Size(309, 41);
            this.tb_IDDelete.TabIndex = 4;
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
            this.btn_Delete.Location = new System.Drawing.Point(365, 216);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 129);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1693, 973);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddBook_FormClosing);
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grb_DieuKhien.ResumeLayout(false);
            this.grb_DieuKhien.PerformLayout();
            this.grb_DataBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddBook)).EndInit();
            this.grb_InfoBook.ResumeLayout(false);
            this.grb_InfoBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grb_DieuKhien;
        private System.Windows.Forms.GroupBox grb_DataBook;
        private System.Windows.Forms.DataGridView dgv_AddBook;
        private System.Windows.Forms.GroupBox grb_InfoBook;
        private System.Windows.Forms.Label lb_ThongTin;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
        private System.Windows.Forms.TextBox tb_IDDelete;
        private System.Windows.Forms.Label lb_IDDelete;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private Bunifu.Framework.UI.BunifuTileButton btn_Edit;
        private Bunifu.Framework.UI.BunifuTileButton btn_Add;
        private System.Windows.Forms.TextBox tb_GiaTien;
        private System.Windows.Forms.TextBox tb_SoLuongTon;
        private System.Windows.Forms.DateTimePicker dtp_NXB;
        private System.Windows.Forms.TextBox tb_NhaXuatBan;
        private System.Windows.Forms.TextBox tb_IDSach;
        private System.Windows.Forms.ComboBox cb_LoaiSach;
        private System.Windows.Forms.TextBox tb_TenSach;
        private System.Windows.Forms.Label lb_GiaTien;
        private System.Windows.Forms.Label lb_SoLuongTon;
        private System.Windows.Forms.Label lb_YXB;
        private System.Windows.Forms.Label lb_NXB;
        private System.Windows.Forms.Label lb_IDSach;
        private System.Windows.Forms.Label lb_LoaiSach;
        private System.Windows.Forms.Label lb_TenSach;
        private System.Windows.Forms.TextBox tb_IDDauSach;
        private System.Windows.Forms.Label lb_IDDauSach;
    }
}