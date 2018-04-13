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
            this.lb_ThongTin = new System.Windows.Forms.Label();
            this.grb_InfoBook = new System.Windows.Forms.GroupBox();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbb_NamXB = new System.Windows.Forms.ComboBox();
            this.cbb_Authors = new System.Windows.Forms.ComboBox();
            this.cbb_TypeBook = new System.Windows.Forms.ComboBox();
            this.tb_TriGia = new System.Windows.Forms.TextBox();
            this.tb_NhaXB = new System.Windows.Forms.TextBox();
            this.tb_NameBook = new System.Windows.Forms.TextBox();
            this.tb_IDBook = new System.Windows.Forms.TextBox();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.lb_TriGia = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_NhaXB = new System.Windows.Forms.Label();
            this.lb_NamXB = new System.Windows.Forms.Label();
            this.lb_Authors = new System.Windows.Forms.Label();
            this.lb_TypeBook = new System.Windows.Forms.Label();
            this.lb_NameBook = new System.Windows.Forms.Label();
            this.lb_IDSach = new System.Windows.Forms.Label();
            this.grb_DataBook = new System.Windows.Forms.GroupBox();
            this.dgv_AddBook = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.tb_IDDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.btn_EditBook = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.grb_InfoBook.SuspendLayout();
            this.grb_DataBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddBook)).BeginInit();
            this.grb_DieuKhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ThongTin
            // 
            this.lb_ThongTin.AutoSize = true;
            this.lb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_ThongTin.Location = new System.Drawing.Point(723, 44);
            this.lb_ThongTin.Name = "lb_ThongTin";
            this.lb_ThongTin.Size = new System.Drawing.Size(421, 69);
            this.lb_ThongTin.TabIndex = 0;
            this.lb_ThongTin.Text = "Thông tin sách";
            // 
            // grb_InfoBook
            // 
            this.grb_InfoBook.Controls.Add(this.cbb_TinhTrang);
            this.grb_InfoBook.Controls.Add(this.dtp_NgayNhap);
            this.grb_InfoBook.Controls.Add(this.cbb_NamXB);
            this.grb_InfoBook.Controls.Add(this.cbb_Authors);
            this.grb_InfoBook.Controls.Add(this.cbb_TypeBook);
            this.grb_InfoBook.Controls.Add(this.tb_TriGia);
            this.grb_InfoBook.Controls.Add(this.tb_NhaXB);
            this.grb_InfoBook.Controls.Add(this.tb_NameBook);
            this.grb_InfoBook.Controls.Add(this.tb_IDBook);
            this.grb_InfoBook.Controls.Add(this.lb_TinhTrang);
            this.grb_InfoBook.Controls.Add(this.lb_TriGia);
            this.grb_InfoBook.Controls.Add(this.lb_Time);
            this.grb_InfoBook.Controls.Add(this.lb_NhaXB);
            this.grb_InfoBook.Controls.Add(this.lb_NamXB);
            this.grb_InfoBook.Controls.Add(this.lb_Authors);
            this.grb_InfoBook.Controls.Add(this.lb_TypeBook);
            this.grb_InfoBook.Controls.Add(this.lb_NameBook);
            this.grb_InfoBook.Controls.Add(this.lb_IDSach);
            this.grb_InfoBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_InfoBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_InfoBook.Location = new System.Drawing.Point(88, 149);
            this.grb_InfoBook.Name = "grb_InfoBook";
            this.grb_InfoBook.Size = new System.Drawing.Size(686, 697);
            this.grb_InfoBook.TabIndex = 1;
            this.grb_InfoBook.TabStop = false;
            this.grb_InfoBook.Text = "Nhập thông tin sách";
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Items.AddRange(new object[] {
            "Cho mượn",
            "Chưa cho mượn"});
            this.cbb_TinhTrang.Location = new System.Drawing.Point(248, 614);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(312, 44);
            this.cbb_TinhTrang.TabIndex = 18;
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(248, 475);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(312, 41);
            this.dtp_NgayNhap.TabIndex = 17;
            // 
            // cbb_NamXB
            // 
            this.cbb_NamXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NamXB.FormattingEnabled = true;
            this.cbb_NamXB.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.cbb_NamXB.Location = new System.Drawing.Point(248, 335);
            this.cbb_NamXB.Name = "cbb_NamXB";
            this.cbb_NamXB.Size = new System.Drawing.Size(312, 44);
            this.cbb_NamXB.TabIndex = 15;
            // 
            // cbb_Authors
            // 
            this.cbb_Authors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Authors.FormattingEnabled = true;
            this.cbb_Authors.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.cbb_Authors.Location = new System.Drawing.Point(248, 266);
            this.cbb_Authors.Name = "cbb_Authors";
            this.cbb_Authors.Size = new System.Drawing.Size(312, 44);
            this.cbb_Authors.TabIndex = 14;
            // 
            // cbb_TypeBook
            // 
            this.cbb_TypeBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TypeBook.FormattingEnabled = true;
            this.cbb_TypeBook.Items.AddRange(new object[] {
            "Truyện",
            "Văn học dân gian",
            "Văn học quốc tế"});
            this.cbb_TypeBook.Location = new System.Drawing.Point(248, 195);
            this.cbb_TypeBook.Name = "cbb_TypeBook";
            this.cbb_TypeBook.Size = new System.Drawing.Size(312, 44);
            this.cbb_TypeBook.TabIndex = 13;
            // 
            // tb_TriGia
            // 
            this.tb_TriGia.Location = new System.Drawing.Point(248, 546);
            this.tb_TriGia.Name = "tb_TriGia";
            this.tb_TriGia.Size = new System.Drawing.Size(312, 41);
            this.tb_TriGia.TabIndex = 12;
            this.tb_TriGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TriGia_KeyPress);
            // 
            // tb_NhaXB
            // 
            this.tb_NhaXB.Location = new System.Drawing.Point(248, 406);
            this.tb_NhaXB.Name = "tb_NhaXB";
            this.tb_NhaXB.Size = new System.Drawing.Size(312, 41);
            this.tb_NhaXB.TabIndex = 11;
            // 
            // tb_NameBook
            // 
            this.tb_NameBook.Location = new System.Drawing.Point(248, 126);
            this.tb_NameBook.Name = "tb_NameBook";
            this.tb_NameBook.Size = new System.Drawing.Size(312, 41);
            this.tb_NameBook.TabIndex = 10;
            // 
            // tb_IDBook
            // 
            this.tb_IDBook.Location = new System.Drawing.Point(248, 55);
            this.tb_IDBook.Name = "tb_IDBook";
            this.tb_IDBook.Size = new System.Drawing.Size(312, 41);
            this.tb_IDBook.TabIndex = 9;
            this.tb_IDBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDBook_KeyPress);
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.Location = new System.Drawing.Point(26, 618);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(169, 36);
            this.lb_TinhTrang.TabIndex = 8;
            this.lb_TinhTrang.Text = "Tình trạng:";
            // 
            // lb_TriGia
            // 
            this.lb_TriGia.AutoSize = true;
            this.lb_TriGia.Location = new System.Drawing.Point(26, 549);
            this.lb_TriGia.Name = "lb_TriGia";
            this.lb_TriGia.Size = new System.Drawing.Size(111, 36);
            this.lb_TriGia.TabIndex = 7;
            this.lb_TriGia.Text = "Trị Giá";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(26, 478);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(178, 36);
            this.lb_Time.TabIndex = 6;
            this.lb_Time.Text = "Ngày nhập:";
            // 
            // lb_NhaXB
            // 
            this.lb_NhaXB.AutoSize = true;
            this.lb_NhaXB.Location = new System.Drawing.Point(26, 409);
            this.lb_NhaXB.Name = "lb_NhaXB";
            this.lb_NhaXB.Size = new System.Drawing.Size(213, 36);
            this.lb_NhaXB.TabIndex = 5;
            this.lb_NhaXB.Text = "Nhà xuất bản:";
            // 
            // lb_NamXB
            // 
            this.lb_NamXB.AutoSize = true;
            this.lb_NamXB.Location = new System.Drawing.Point(26, 338);
            this.lb_NamXB.Name = "lb_NamXB";
            this.lb_NamXB.Size = new System.Drawing.Size(219, 36);
            this.lb_NamXB.TabIndex = 4;
            this.lb_NamXB.Text = "Năm xuất bản:";
            // 
            // lb_Authors
            // 
            this.lb_Authors.AutoSize = true;
            this.lb_Authors.Location = new System.Drawing.Point(26, 269);
            this.lb_Authors.Name = "lb_Authors";
            this.lb_Authors.Size = new System.Drawing.Size(128, 36);
            this.lb_Authors.TabIndex = 3;
            this.lb_Authors.Text = "Tác giả:";
            // 
            // lb_TypeBook
            // 
            this.lb_TypeBook.AutoSize = true;
            this.lb_TypeBook.Location = new System.Drawing.Point(26, 198);
            this.lb_TypeBook.Name = "lb_TypeBook";
            this.lb_TypeBook.Size = new System.Drawing.Size(139, 36);
            this.lb_TypeBook.TabIndex = 2;
            this.lb_TypeBook.Text = "Thể Loại";
            // 
            // lb_NameBook
            // 
            this.lb_NameBook.AutoSize = true;
            this.lb_NameBook.Location = new System.Drawing.Point(26, 129);
            this.lb_NameBook.Name = "lb_NameBook";
            this.lb_NameBook.Size = new System.Drawing.Size(154, 36);
            this.lb_NameBook.TabIndex = 1;
            this.lb_NameBook.Text = "Tên sách:";
            // 
            // lb_IDSach
            // 
            this.lb_IDSach.AutoSize = true;
            this.lb_IDSach.Location = new System.Drawing.Point(26, 58);
            this.lb_IDSach.Name = "lb_IDSach";
            this.lb_IDSach.Size = new System.Drawing.Size(131, 36);
            this.lb_IDSach.TabIndex = 0;
            this.lb_IDSach.Text = "ID sách:";
            // 
            // grb_DataBook
            // 
            this.grb_DataBook.Controls.Add(this.dgv_AddBook);
            this.grb_DataBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataBook.Location = new System.Drawing.Point(784, 195);
            this.grb_DataBook.Name = "grb_DataBook";
            this.grb_DataBook.Size = new System.Drawing.Size(1080, 854);
            this.grb_DataBook.TabIndex = 2;
            this.grb_DataBook.TabStop = false;
            this.grb_DataBook.Text = "Bảng thông tin sách";
            // 
            // dgv_AddBook
            // 
            this.dgv_AddBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AddBook.Location = new System.Drawing.Point(7, 42);
            this.dgv_AddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_AddBook.Name = "dgv_AddBook";
            this.dgv_AddBook.Size = new System.Drawing.Size(1066, 797);
            this.dgv_AddBook.TabIndex = 0;
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.tb_IDDel);
            this.grb_DieuKhien.Controls.Add(this.label1);
            this.grb_DieuKhien.Controls.Add(this.btn_Back);
            this.grb_DieuKhien.Controls.Add(this.btn_DeleteBook);
            this.grb_DieuKhien.Controls.Add(this.btn_EditBook);
            this.grb_DieuKhien.Controls.Add(this.btn_AddBook);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(88, 863);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(690, 186);
            this.grb_DieuKhien.TabIndex = 3;
            this.grb_DieuKhien.TabStop = false;
            this.grb_DieuKhien.Text = "Xử lí";
            // 
            // tb_IDDel
            // 
            this.tb_IDDel.Location = new System.Drawing.Point(312, 125);
            this.tb_IDDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_IDDel.Name = "tb_IDDel";
            this.tb_IDDel.Size = new System.Drawing.Size(129, 41);
            this.tb_IDDel.TabIndex = 5;
            this.tb_IDDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDDel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập ID cần xóa:";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(489, 49);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(132, 46);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.Location = new System.Drawing.Point(489, 125);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(132, 46);
            this.btn_DeleteBook.TabIndex = 2;
            this.btn_DeleteBook.Text = "Xóa";
            this.btn_DeleteBook.UseVisualStyleBackColor = true;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // btn_EditBook
            // 
            this.btn_EditBook.Location = new System.Drawing.Point(290, 49);
            this.btn_EditBook.Name = "btn_EditBook";
            this.btn_EditBook.Size = new System.Drawing.Size(151, 46);
            this.btn_EditBook.TabIndex = 1;
            this.btn_EditBook.Text = "Sửa";
            this.btn_EditBook.UseVisualStyleBackColor = true;
            this.btn_EditBook.Click += new System.EventHandler(this.btn_EditBook_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(66, 49);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(140, 46);
            this.btn_AddBook.TabIndex = 0;
            this.btn_AddBook.Text = "Thêm";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1893, 1066);
            this.Controls.Add(this.grb_DieuKhien);
            this.Controls.Add(this.grb_DataBook);
            this.Controls.Add(this.grb_InfoBook);
            this.Controls.Add(this.lb_ThongTin);
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddBook_FormClosing);
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.grb_InfoBook.ResumeLayout(false);
            this.grb_InfoBook.PerformLayout();
            this.grb_DataBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AddBook)).EndInit();
            this.grb_DieuKhien.ResumeLayout(false);
            this.grb_DieuKhien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ThongTin;
        private System.Windows.Forms.GroupBox grb_InfoBook;
        private System.Windows.Forms.GroupBox grb_DataBook;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.ComboBox cbb_NamXB;
        private System.Windows.Forms.ComboBox cbb_Authors;
        private System.Windows.Forms.ComboBox cbb_TypeBook;
        private System.Windows.Forms.TextBox tb_TriGia;
        private System.Windows.Forms.TextBox tb_NhaXB;
        private System.Windows.Forms.TextBox tb_NameBook;
        private System.Windows.Forms.TextBox tb_IDBook;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.Label lb_TriGia;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_NhaXB;
        private System.Windows.Forms.Label lb_NamXB;
        private System.Windows.Forms.Label lb_Authors;
        private System.Windows.Forms.Label lb_TypeBook;
        private System.Windows.Forms.Label lb_NameBook;
        private System.Windows.Forms.Label lb_IDSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grb_DieuKhien;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_DeleteBook;
        private System.Windows.Forms.Button btn_EditBook;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.DataGridView dgv_AddBook;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.TextBox tb_IDDel;
        private System.Windows.Forms.Label label1;
    }
}