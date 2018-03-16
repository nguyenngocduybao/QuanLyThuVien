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
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbb_NamXB = new System.Windows.Forms.ComboBox();
            this.cbb_Authors = new System.Windows.Forms.ComboBox();
            this.cbb_TypeBook = new System.Windows.Forms.ComboBox();
            this.tb_TriGia = new System.Windows.Forms.TextBox();
            this.tb_NhaXB = new System.Windows.Forms.TextBox();
            this.tb_NameBook = new System.Windows.Forms.TextBox();
            this.tb_IDBook = new System.Windows.Forms.TextBox();
            this.lb_Image = new System.Windows.Forms.Label();
            this.lb_TriGia = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_NhaXB = new System.Windows.Forms.Label();
            this.lb_NamXB = new System.Windows.Forms.Label();
            this.lb_Authors = new System.Windows.Forms.Label();
            this.lb_TypeBook = new System.Windows.Forms.Label();
            this.lb_NameBook = new System.Windows.Forms.Label();
            this.lb_IDSach = new System.Windows.Forms.Label();
            this.grb_DataBook = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btn_EditBook = new System.Windows.Forms.Button();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.grb_InfoBook.SuspendLayout();
            this.grb_DieuKhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ThongTin
            // 
            this.lb_ThongTin.AutoSize = true;
            this.lb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_ThongTin.Location = new System.Drawing.Point(608, 110);
            this.lb_ThongTin.Name = "lb_ThongTin";
            this.lb_ThongTin.Size = new System.Drawing.Size(421, 69);
            this.lb_ThongTin.TabIndex = 0;
            this.lb_ThongTin.Text = "Thông tin sách";
            // 
            // grb_InfoBook
            // 
            this.grb_InfoBook.Controls.Add(this.dtp_NgayNhap);
            this.grb_InfoBook.Controls.Add(this.cbb_NamXB);
            this.grb_InfoBook.Controls.Add(this.cbb_Authors);
            this.grb_InfoBook.Controls.Add(this.cbb_TypeBook);
            this.grb_InfoBook.Controls.Add(this.tb_TriGia);
            this.grb_InfoBook.Controls.Add(this.tb_NhaXB);
            this.grb_InfoBook.Controls.Add(this.tb_NameBook);
            this.grb_InfoBook.Controls.Add(this.tb_IDBook);
            this.grb_InfoBook.Controls.Add(this.lb_Image);
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
            this.grb_InfoBook.Location = new System.Drawing.Point(72, 195);
            this.grb_InfoBook.Name = "grb_InfoBook";
            this.grb_InfoBook.Size = new System.Drawing.Size(686, 697);
            this.grb_InfoBook.TabIndex = 1;
            this.grb_InfoBook.TabStop = false;
            this.grb_InfoBook.Text = "Nhập thông tin sách";
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(247, 475);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(311, 41);
            this.dtp_NgayNhap.TabIndex = 17;
            // 
            // cbb_NamXB
            // 
            this.cbb_NamXB.FormattingEnabled = true;
            this.cbb_NamXB.Location = new System.Drawing.Point(247, 336);
            this.cbb_NamXB.Name = "cbb_NamXB";
            this.cbb_NamXB.Size = new System.Drawing.Size(311, 44);
            this.cbb_NamXB.TabIndex = 15;
            // 
            // cbb_Authors
            // 
            this.cbb_Authors.FormattingEnabled = true;
            this.cbb_Authors.Location = new System.Drawing.Point(247, 266);
            this.cbb_Authors.Name = "cbb_Authors";
            this.cbb_Authors.Size = new System.Drawing.Size(311, 44);
            this.cbb_Authors.TabIndex = 14;
            // 
            // cbb_TypeBook
            // 
            this.cbb_TypeBook.FormattingEnabled = true;
            this.cbb_TypeBook.Location = new System.Drawing.Point(247, 196);
            this.cbb_TypeBook.Name = "cbb_TypeBook";
            this.cbb_TypeBook.Size = new System.Drawing.Size(311, 44);
            this.cbb_TypeBook.TabIndex = 13;
            // 
            // tb_TriGia
            // 
            this.tb_TriGia.Location = new System.Drawing.Point(247, 546);
            this.tb_TriGia.Name = "tb_TriGia";
            this.tb_TriGia.Size = new System.Drawing.Size(311, 41);
            this.tb_TriGia.TabIndex = 12;
            // 
            // tb_NhaXB
            // 
            this.tb_NhaXB.Location = new System.Drawing.Point(247, 406);
            this.tb_NhaXB.Name = "tb_NhaXB";
            this.tb_NhaXB.Size = new System.Drawing.Size(311, 41);
            this.tb_NhaXB.TabIndex = 11;
            // 
            // tb_NameBook
            // 
            this.tb_NameBook.Location = new System.Drawing.Point(247, 126);
            this.tb_NameBook.Name = "tb_NameBook";
            this.tb_NameBook.Size = new System.Drawing.Size(311, 41);
            this.tb_NameBook.TabIndex = 10;
            // 
            // tb_IDBook
            // 
            this.tb_IDBook.Location = new System.Drawing.Point(247, 56);
            this.tb_IDBook.Name = "tb_IDBook";
            this.tb_IDBook.Size = new System.Drawing.Size(311, 41);
            this.tb_IDBook.TabIndex = 9;
            // 
            // lb_Image
            // 
            this.lb_Image.AutoSize = true;
            this.lb_Image.Location = new System.Drawing.Point(25, 619);
            this.lb_Image.Name = "lb_Image";
            this.lb_Image.Size = new System.Drawing.Size(152, 36);
            this.lb_Image.TabIndex = 8;
            this.lb_Image.Text = "Hình ảnh:";
            // 
            // lb_TriGia
            // 
            this.lb_TriGia.AutoSize = true;
            this.lb_TriGia.Location = new System.Drawing.Point(25, 549);
            this.lb_TriGia.Name = "lb_TriGia";
            this.lb_TriGia.Size = new System.Drawing.Size(111, 36);
            this.lb_TriGia.TabIndex = 7;
            this.lb_TriGia.Text = "Trị Giá";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(25, 479);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(178, 36);
            this.lb_Time.TabIndex = 6;
            this.lb_Time.Text = "Ngày nhập:";
            // 
            // lb_NhaXB
            // 
            this.lb_NhaXB.AutoSize = true;
            this.lb_NhaXB.Location = new System.Drawing.Point(25, 409);
            this.lb_NhaXB.Name = "lb_NhaXB";
            this.lb_NhaXB.Size = new System.Drawing.Size(213, 36);
            this.lb_NhaXB.TabIndex = 5;
            this.lb_NhaXB.Text = "Nhà xuất bản:";
            // 
            // lb_NamXB
            // 
            this.lb_NamXB.AutoSize = true;
            this.lb_NamXB.Location = new System.Drawing.Point(25, 339);
            this.lb_NamXB.Name = "lb_NamXB";
            this.lb_NamXB.Size = new System.Drawing.Size(219, 36);
            this.lb_NamXB.TabIndex = 4;
            this.lb_NamXB.Text = "Năm xuất bản:";
            // 
            // lb_Authors
            // 
            this.lb_Authors.AutoSize = true;
            this.lb_Authors.Location = new System.Drawing.Point(25, 269);
            this.lb_Authors.Name = "lb_Authors";
            this.lb_Authors.Size = new System.Drawing.Size(128, 36);
            this.lb_Authors.TabIndex = 3;
            this.lb_Authors.Text = "Tác giả:";
            // 
            // lb_TypeBook
            // 
            this.lb_TypeBook.AutoSize = true;
            this.lb_TypeBook.Location = new System.Drawing.Point(25, 199);
            this.lb_TypeBook.Name = "lb_TypeBook";
            this.lb_TypeBook.Size = new System.Drawing.Size(139, 36);
            this.lb_TypeBook.TabIndex = 2;
            this.lb_TypeBook.Text = "Thể Loại";
            // 
            // lb_NameBook
            // 
            this.lb_NameBook.AutoSize = true;
            this.lb_NameBook.Location = new System.Drawing.Point(25, 129);
            this.lb_NameBook.Name = "lb_NameBook";
            this.lb_NameBook.Size = new System.Drawing.Size(154, 36);
            this.lb_NameBook.TabIndex = 1;
            this.lb_NameBook.Text = "Tên sách:";
            // 
            // lb_IDSach
            // 
            this.lb_IDSach.AutoSize = true;
            this.lb_IDSach.Location = new System.Drawing.Point(25, 59);
            this.lb_IDSach.Name = "lb_IDSach";
            this.lb_IDSach.Size = new System.Drawing.Size(131, 36);
            this.lb_IDSach.TabIndex = 0;
            this.lb_IDSach.Text = "ID sách:";
            // 
            // grb_DataBook
            // 
            this.grb_DataBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataBook.Location = new System.Drawing.Point(785, 195);
            this.grb_DataBook.Name = "grb_DataBook";
            this.grb_DataBook.Size = new System.Drawing.Size(1080, 697);
            this.grb_DataBook.TabIndex = 2;
            this.grb_DataBook.TabStop = false;
            this.grb_DataBook.Text = "Bảng thông tin sách";
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.btn_Back);
            this.grb_DieuKhien.Controls.Add(this.btn_DeleteBook);
            this.grb_DieuKhien.Controls.Add(this.btn_EditBook);
            this.grb_DieuKhien.Controls.Add(this.btn_AddBook);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(412, 926);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(890, 118);
            this.grb_DieuKhien.TabIndex = 3;
            this.grb_DieuKhien.TabStop = false;
            this.grb_DieuKhien.Text = "Xử lí";
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(66, 49);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(140, 46);
            this.btn_AddBook.TabIndex = 0;
            this.btn_AddBook.Text = "Thêm";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            // 
            // btn_EditBook
            // 
            this.btn_EditBook.Location = new System.Drawing.Point(281, 49);
            this.btn_EditBook.Name = "btn_EditBook";
            this.btn_EditBook.Size = new System.Drawing.Size(135, 46);
            this.btn_EditBook.TabIndex = 1;
            this.btn_EditBook.Text = "Sửa";
            this.btn_EditBook.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.Location = new System.Drawing.Point(486, 49);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(143, 46);
            this.btn_DeleteBook.TabIndex = 2;
            this.btn_DeleteBook.Text = "Xóa";
            this.btn_DeleteBook.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(701, 49);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(132, 46);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1895, 1056);
            this.Controls.Add(this.grb_DieuKhien);
            this.Controls.Add(this.grb_DataBook);
            this.Controls.Add(this.grb_InfoBook);
            this.Controls.Add(this.lb_ThongTin);
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddBook";
            this.grb_InfoBook.ResumeLayout(false);
            this.grb_InfoBook.PerformLayout();
            this.grb_DieuKhien.ResumeLayout(false);
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
        private System.Windows.Forms.Label lb_Image;
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
    }
}