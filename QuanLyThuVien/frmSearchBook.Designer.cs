namespace QuanLyThuVien
{
    partial class frmSearchBook
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
            this.grb_DataSearchBook = new System.Windows.Forms.GroupBox();
            this.dgv_SearchBook = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_Search = new System.Windows.Forms.Label();
            this.grb_SearchBook = new System.Windows.Forms.GroupBox();
            this.tab_SearchBook = new System.Windows.Forms.TabControl();
            this.tab_IDBook = new System.Windows.Forms.TabPage();
            this.tb_IDBook = new System.Windows.Forms.TextBox();
            this.lb_IDSach = new System.Windows.Forms.Label();
            this.tab_NameBook = new System.Windows.Forms.TabPage();
            this.tb_NameBook = new System.Windows.Forms.TextBox();
            this.lb_NameBook = new System.Windows.Forms.Label();
            this.tab_TheLoai = new System.Windows.Forms.TabPage();
            this.cbb_TheLoai = new System.Windows.Forms.ComboBox();
            this.lb_TheLoai = new System.Windows.Forms.Label();
            this.tab_TacGia = new System.Windows.Forms.TabPage();
            this.tab_YXB = new System.Windows.Forms.TabPage();
            this.tab_NXB = new System.Windows.Forms.TabPage();
            this.tab_TinhTrang = new System.Windows.Forms.TabPage();
            this.lb_TacGia = new System.Windows.Forms.Label();
            this.cbb_TacGia = new System.Windows.Forms.ComboBox();
            this.lb_YXB = new System.Windows.Forms.Label();
            this.cbb_YXB = new System.Windows.Forms.ComboBox();
            this.lb_NXB = new System.Windows.Forms.Label();
            this.tb_NXB = new System.Windows.Forms.TextBox();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.grb_DataSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchBook)).BeginInit();
            this.grb_SearchBook.SuspendLayout();
            this.tab_SearchBook.SuspendLayout();
            this.tab_IDBook.SuspendLayout();
            this.tab_NameBook.SuspendLayout();
            this.tab_TheLoai.SuspendLayout();
            this.tab_TacGia.SuspendLayout();
            this.tab_YXB.SuspendLayout();
            this.tab_NXB.SuspendLayout();
            this.tab_TinhTrang.SuspendLayout();
            this.grb_DieuKhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_DataSearchBook
            // 
            this.grb_DataSearchBook.Controls.Add(this.dgv_SearchBook);
            this.grb_DataSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataSearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataSearchBook.Location = new System.Drawing.Point(12, 452);
            this.grb_DataSearchBook.Name = "grb_DataSearchBook";
            this.grb_DataSearchBook.Size = new System.Drawing.Size(1905, 645);
            this.grb_DataSearchBook.TabIndex = 1;
            this.grb_DataSearchBook.TabStop = false;
            this.grb_DataSearchBook.Text = "Danh sách sách vừa tra cứu";
            // 
            // dgv_SearchBook
            // 
            this.dgv_SearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchBook.Location = new System.Drawing.Point(7, 40);
            this.dgv_SearchBook.Name = "dgv_SearchBook";
            this.dgv_SearchBook.RowTemplate.Height = 28;
            this.dgv_SearchBook.Size = new System.Drawing.Size(1892, 638);
            this.dgv_SearchBook.TabIndex = 0;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Search.Location = new System.Drawing.Point(825, 52);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(374, 69);
            this.lb_Search.TabIndex = 2;
            this.lb_Search.Text = "Tra cứu sách";
            // 
            // grb_SearchBook
            // 
            this.grb_SearchBook.Controls.Add(this.tab_SearchBook);
            this.grb_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_SearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_SearchBook.Location = new System.Drawing.Point(19, 181);
            this.grb_SearchBook.Name = "grb_SearchBook";
            this.grb_SearchBook.Size = new System.Drawing.Size(1087, 265);
            this.grb_SearchBook.TabIndex = 3;
            this.grb_SearchBook.TabStop = false;
            this.grb_SearchBook.Text = "Thông tin tra cứu";
            // 
            // tab_SearchBook
            // 
            this.tab_SearchBook.Controls.Add(this.tab_IDBook);
            this.tab_SearchBook.Controls.Add(this.tab_NameBook);
            this.tab_SearchBook.Controls.Add(this.tab_TheLoai);
            this.tab_SearchBook.Controls.Add(this.tab_TacGia);
            this.tab_SearchBook.Controls.Add(this.tab_YXB);
            this.tab_SearchBook.Controls.Add(this.tab_NXB);
            this.tab_SearchBook.Controls.Add(this.tab_TinhTrang);
            this.tab_SearchBook.Location = new System.Drawing.Point(6, 41);
            this.tab_SearchBook.Name = "tab_SearchBook";
            this.tab_SearchBook.SelectedIndex = 0;
            this.tab_SearchBook.Size = new System.Drawing.Size(1055, 197);
            this.tab_SearchBook.TabIndex = 0;
            this.tab_SearchBook.SelectedIndexChanged += new System.EventHandler(this.tab_SearchBook_SelectedIndexChanged);
            // 
            // tab_IDBook
            // 
            this.tab_IDBook.Controls.Add(this.tb_IDBook);
            this.tab_IDBook.Controls.Add(this.lb_IDSach);
            this.tab_IDBook.Location = new System.Drawing.Point(4, 45);
            this.tab_IDBook.Name = "tab_IDBook";
            this.tab_IDBook.Padding = new System.Windows.Forms.Padding(3);
            this.tab_IDBook.Size = new System.Drawing.Size(1047, 148);
            this.tab_IDBook.TabIndex = 0;
            this.tab_IDBook.Text = "ID sách";
            this.tab_IDBook.UseVisualStyleBackColor = true;
            // 
            // tb_IDBook
            // 
            this.tb_IDBook.Location = new System.Drawing.Point(394, 60);
            this.tb_IDBook.Name = "tb_IDBook";
            this.tb_IDBook.Size = new System.Drawing.Size(307, 41);
            this.tb_IDBook.TabIndex = 1;
            // 
            // lb_IDSach
            // 
            this.lb_IDSach.AutoSize = true;
            this.lb_IDSach.Location = new System.Drawing.Point(61, 63);
            this.lb_IDSach.Name = "lb_IDSach";
            this.lb_IDSach.Size = new System.Drawing.Size(313, 36);
            this.lb_IDSach.TabIndex = 0;
            this.lb_IDSach.Text = "Nhập ID sách cần tìm :";
            // 
            // tab_NameBook
            // 
            this.tab_NameBook.Controls.Add(this.tb_NameBook);
            this.tab_NameBook.Controls.Add(this.lb_NameBook);
            this.tab_NameBook.Location = new System.Drawing.Point(4, 45);
            this.tab_NameBook.Name = "tab_NameBook";
            this.tab_NameBook.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NameBook.Size = new System.Drawing.Size(1021, 148);
            this.tab_NameBook.TabIndex = 1;
            this.tab_NameBook.Text = "Tên sách";
            this.tab_NameBook.UseVisualStyleBackColor = true;
            // 
            // tb_NameBook
            // 
            this.tb_NameBook.Location = new System.Drawing.Point(384, 60);
            this.tb_NameBook.Name = "tb_NameBook";
            this.tb_NameBook.Size = new System.Drawing.Size(316, 41);
            this.tb_NameBook.TabIndex = 1;
            // 
            // lb_NameBook
            // 
            this.lb_NameBook.AutoSize = true;
            this.lb_NameBook.Location = new System.Drawing.Point(61, 63);
            this.lb_NameBook.Name = "lb_NameBook";
            this.lb_NameBook.Size = new System.Drawing.Size(317, 36);
            this.lb_NameBook.TabIndex = 0;
            this.lb_NameBook.Text = "Nhập tên sách cần tìm:";
            // 
            // tab_TheLoai
            // 
            this.tab_TheLoai.Controls.Add(this.cbb_TheLoai);
            this.tab_TheLoai.Controls.Add(this.lb_TheLoai);
            this.tab_TheLoai.Location = new System.Drawing.Point(4, 45);
            this.tab_TheLoai.Name = "tab_TheLoai";
            this.tab_TheLoai.Size = new System.Drawing.Size(1021, 148);
            this.tab_TheLoai.TabIndex = 2;
            this.tab_TheLoai.Text = "Thể loại";
            this.tab_TheLoai.UseVisualStyleBackColor = true;
            // 
            // cbb_TheLoai
            // 
            this.cbb_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TheLoai.FormattingEnabled = true;
            this.cbb_TheLoai.Items.AddRange(new object[] {
            "Truyện",
            "Văn học dân gian",
            "Văn học quốc tế"});
            this.cbb_TheLoai.Location = new System.Drawing.Point(401, 60);
            this.cbb_TheLoai.Name = "cbb_TheLoai";
            this.cbb_TheLoai.Size = new System.Drawing.Size(285, 44);
            this.cbb_TheLoai.TabIndex = 1;
            // 
            // lb_TheLoai
            // 
            this.lb_TheLoai.AutoSize = true;
            this.lb_TheLoai.Location = new System.Drawing.Point(61, 63);
            this.lb_TheLoai.Name = "lb_TheLoai";
            this.lb_TheLoai.Size = new System.Drawing.Size(301, 36);
            this.lb_TheLoai.TabIndex = 0;
            this.lb_TheLoai.Text = "Chọn thể loại cần tìm:";
            // 
            // tab_TacGia
            // 
            this.tab_TacGia.Controls.Add(this.cbb_TacGia);
            this.tab_TacGia.Controls.Add(this.lb_TacGia);
            this.tab_TacGia.Location = new System.Drawing.Point(4, 45);
            this.tab_TacGia.Name = "tab_TacGia";
            this.tab_TacGia.Size = new System.Drawing.Size(1021, 148);
            this.tab_TacGia.TabIndex = 3;
            this.tab_TacGia.Text = "Tác giả";
            this.tab_TacGia.UseVisualStyleBackColor = true;
            // 
            // tab_YXB
            // 
            this.tab_YXB.Controls.Add(this.cbb_YXB);
            this.tab_YXB.Controls.Add(this.lb_YXB);
            this.tab_YXB.Location = new System.Drawing.Point(4, 45);
            this.tab_YXB.Name = "tab_YXB";
            this.tab_YXB.Size = new System.Drawing.Size(1021, 148);
            this.tab_YXB.TabIndex = 4;
            this.tab_YXB.Text = "Năm xuất bản";
            this.tab_YXB.UseVisualStyleBackColor = true;
            // 
            // tab_NXB
            // 
            this.tab_NXB.Controls.Add(this.tb_NXB);
            this.tab_NXB.Controls.Add(this.lb_NXB);
            this.tab_NXB.Location = new System.Drawing.Point(4, 45);
            this.tab_NXB.Name = "tab_NXB";
            this.tab_NXB.Size = new System.Drawing.Size(1021, 148);
            this.tab_NXB.TabIndex = 5;
            this.tab_NXB.Text = "Nhà xuất bản";
            this.tab_NXB.UseVisualStyleBackColor = true;
            // 
            // tab_TinhTrang
            // 
            this.tab_TinhTrang.Controls.Add(this.cbb_TinhTrang);
            this.tab_TinhTrang.Controls.Add(this.lb_TinhTrang);
            this.tab_TinhTrang.Location = new System.Drawing.Point(4, 45);
            this.tab_TinhTrang.Name = "tab_TinhTrang";
            this.tab_TinhTrang.Size = new System.Drawing.Size(1021, 148);
            this.tab_TinhTrang.TabIndex = 6;
            this.tab_TinhTrang.Text = "Tình trạng";
            this.tab_TinhTrang.UseVisualStyleBackColor = true;
            // 
            // lb_TacGia
            // 
            this.lb_TacGia.AutoSize = true;
            this.lb_TacGia.Location = new System.Drawing.Point(61, 63);
            this.lb_TacGia.Name = "lb_TacGia";
            this.lb_TacGia.Size = new System.Drawing.Size(341, 36);
            this.lb_TacGia.TabIndex = 0;
            this.lb_TacGia.Text = "Nhập tên tác giả cần tìm:";
            // 
            // cbb_TacGia
            // 
            this.cbb_TacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TacGia.FormattingEnabled = true;
            this.cbb_TacGia.Location = new System.Drawing.Point(424, 60);
            this.cbb_TacGia.Name = "cbb_TacGia";
            this.cbb_TacGia.Size = new System.Drawing.Size(270, 44);
            this.cbb_TacGia.TabIndex = 1;
            // 
            // lb_YXB
            // 
            this.lb_YXB.AutoSize = true;
            this.lb_YXB.Location = new System.Drawing.Point(61, 63);
            this.lb_YXB.Name = "lb_YXB";
            this.lb_YXB.Size = new System.Drawing.Size(383, 36);
            this.lb_YXB.TabIndex = 0;
            this.lb_YXB.Text = "Chọn năm xuất bản cần tìm:";
            // 
            // cbb_YXB
            // 
            this.cbb_YXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_YXB.FormattingEnabled = true;
            this.cbb_YXB.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.cbb_YXB.Location = new System.Drawing.Point(468, 60);
            this.cbb_YXB.Name = "cbb_YXB";
            this.cbb_YXB.Size = new System.Drawing.Size(179, 44);
            this.cbb_YXB.TabIndex = 1;
            // 
            // lb_NXB
            // 
            this.lb_NXB.AutoSize = true;
            this.lb_NXB.Location = new System.Drawing.Point(61, 63);
            this.lb_NXB.Name = "lb_NXB";
            this.lb_NXB.Size = new System.Drawing.Size(377, 36);
            this.lb_NXB.TabIndex = 0;
            this.lb_NXB.Text = "Nhập nhà xuất bản cần tìm:";
            // 
            // tb_NXB
            // 
            this.tb_NXB.Location = new System.Drawing.Point(460, 60);
            this.tb_NXB.Name = "tb_NXB";
            this.tb_NXB.Size = new System.Drawing.Size(326, 41);
            this.tb_NXB.TabIndex = 1;
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.Location = new System.Drawing.Point(61, 63);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(158, 36);
            this.lb_TinhTrang.TabIndex = 0;
            this.lb_TinhTrang.Text = "Tình trạng:";
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Items.AddRange(new object[] {
            "Cho mượn",
            "Chưa cho mượn"});
            this.cbb_TinhTrang.Location = new System.Drawing.Point(249, 60);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(208, 44);
            this.cbb_TinhTrang.TabIndex = 1;
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.btn_Back);
            this.grb_DieuKhien.Controls.Add(this.btn_Search);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(1149, 315);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(413, 131);
            this.grb_DieuKhien.TabIndex = 4;
            this.grb_DieuKhien.TabStop = false;
            this.grb_DieuKhien.Text = "Điều khiển";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(35, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 51);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(235, 49);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 51);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 1109);
            this.Controls.Add(this.grb_DieuKhien);
            this.Controls.Add(this.grb_SearchBook);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.grb_DataSearchBook);
            this.Name = "frmSearchBook";
            this.Text = "frmSearchBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchBook_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.grb_DataSearchBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchBook)).EndInit();
            this.grb_SearchBook.ResumeLayout(false);
            this.tab_SearchBook.ResumeLayout(false);
            this.tab_IDBook.ResumeLayout(false);
            this.tab_IDBook.PerformLayout();
            this.tab_NameBook.ResumeLayout(false);
            this.tab_NameBook.PerformLayout();
            this.tab_TheLoai.ResumeLayout(false);
            this.tab_TheLoai.PerformLayout();
            this.tab_TacGia.ResumeLayout(false);
            this.tab_TacGia.PerformLayout();
            this.tab_YXB.ResumeLayout(false);
            this.tab_YXB.PerformLayout();
            this.tab_NXB.ResumeLayout(false);
            this.tab_NXB.PerformLayout();
            this.tab_TinhTrang.ResumeLayout(false);
            this.tab_TinhTrang.PerformLayout();
            this.grb_DieuKhien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_DataSearchBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.DataGridView dgv_SearchBook;
        private System.Windows.Forms.GroupBox grb_SearchBook;
        private System.Windows.Forms.TabControl tab_SearchBook;
        private System.Windows.Forms.TabPage tab_IDBook;
        private System.Windows.Forms.TabPage tab_NameBook;
        private System.Windows.Forms.TabPage tab_TheLoai;
        private System.Windows.Forms.TabPage tab_TacGia;
        private System.Windows.Forms.TabPage tab_YXB;
        private System.Windows.Forms.TabPage tab_NXB;
        private System.Windows.Forms.TabPage tab_TinhTrang;
        private System.Windows.Forms.TextBox tb_IDBook;
        private System.Windows.Forms.Label lb_IDSach;
        private System.Windows.Forms.TextBox tb_NameBook;
        private System.Windows.Forms.Label lb_NameBook;
        private System.Windows.Forms.ComboBox cbb_TheLoai;
        private System.Windows.Forms.Label lb_TheLoai;
        private System.Windows.Forms.Label lb_TacGia;
        private System.Windows.Forms.ComboBox cbb_TacGia;
        private System.Windows.Forms.ComboBox cbb_YXB;
        private System.Windows.Forms.Label lb_YXB;
        private System.Windows.Forms.TextBox tb_NXB;
        private System.Windows.Forms.Label lb_NXB;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.GroupBox grb_DieuKhien;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Search;
    }
}