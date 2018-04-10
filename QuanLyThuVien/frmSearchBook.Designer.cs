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
            this.grb_SearchBook = new System.Windows.Forms.GroupBox();
            this.cbb_TacGia = new System.Windows.Forms.ComboBox();
            this.lb_TacGia = new System.Windows.Forms.Label();
            this.cbb_TheLoai = new System.Windows.Forms.ComboBox();
            this.lb_TheLoai = new System.Windows.Forms.Label();
            this.tb_IDSach = new System.Windows.Forms.TextBox();
            this.lb_IDSach = new System.Windows.Forms.Label();
            this.grb_DataSearchBook = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_Search = new System.Windows.Forms.Label();
            this.lb_NXB = new System.Windows.Forms.Label();
            this.tb_NXB = new System.Windows.Forms.TextBox();
            this.lb_YXB = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grb_SearchBook.SuspendLayout();
            this.grb_DataSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_DieuKhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_SearchBook
            // 
            this.grb_SearchBook.Controls.Add(this.comboBox1);
            this.grb_SearchBook.Controls.Add(this.lb_YXB);
            this.grb_SearchBook.Controls.Add(this.tb_NXB);
            this.grb_SearchBook.Controls.Add(this.lb_NXB);
            this.grb_SearchBook.Controls.Add(this.cbb_TacGia);
            this.grb_SearchBook.Controls.Add(this.lb_TacGia);
            this.grb_SearchBook.Controls.Add(this.cbb_TheLoai);
            this.grb_SearchBook.Controls.Add(this.lb_TheLoai);
            this.grb_SearchBook.Controls.Add(this.tb_IDSach);
            this.grb_SearchBook.Controls.Add(this.lb_IDSach);
            this.grb_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_SearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_SearchBook.Location = new System.Drawing.Point(12, 154);
            this.grb_SearchBook.Name = "grb_SearchBook";
            this.grb_SearchBook.Size = new System.Drawing.Size(1043, 292);
            this.grb_SearchBook.TabIndex = 0;
            this.grb_SearchBook.TabStop = false;
            this.grb_SearchBook.Text = "Thông tin tra cứu sách";
            // 
            // cbb_TacGia
            // 
            this.cbb_TacGia.FormattingEnabled = true;
            this.cbb_TacGia.Location = new System.Drawing.Point(647, 69);
            this.cbb_TacGia.Name = "cbb_TacGia";
            this.cbb_TacGia.Size = new System.Drawing.Size(279, 44);
            this.cbb_TacGia.TabIndex = 5;
            // 
            // lb_TacGia
            // 
            this.lb_TacGia.AutoSize = true;
            this.lb_TacGia.Location = new System.Drawing.Point(488, 72);
            this.lb_TacGia.Name = "lb_TacGia";
            this.lb_TacGia.Size = new System.Drawing.Size(120, 36);
            this.lb_TacGia.TabIndex = 4;
            this.lb_TacGia.Text = "Tác giả:";
            // 
            // cbb_TheLoai
            // 
            this.cbb_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TheLoai.FormattingEnabled = true;
            this.cbb_TheLoai.Items.AddRange(new object[] {
            "Truyện",
            "Văn học dân gian",
            "Văn học quốc tế"});
            this.cbb_TheLoai.Location = new System.Drawing.Point(147, 141);
            this.cbb_TheLoai.Name = "cbb_TheLoai";
            this.cbb_TheLoai.Size = new System.Drawing.Size(263, 44);
            this.cbb_TheLoai.TabIndex = 3;
            // 
            // lb_TheLoai
            // 
            this.lb_TheLoai.AutoSize = true;
            this.lb_TheLoai.Location = new System.Drawing.Point(6, 144);
            this.lb_TheLoai.Name = "lb_TheLoai";
            this.lb_TheLoai.Size = new System.Drawing.Size(129, 36);
            this.lb_TheLoai.TabIndex = 2;
            this.lb_TheLoai.Text = "Thể loại:";
            // 
            // tb_IDSach
            // 
            this.tb_IDSach.Location = new System.Drawing.Point(147, 69);
            this.tb_IDSach.Name = "tb_IDSach";
            this.tb_IDSach.Size = new System.Drawing.Size(263, 41);
            this.tb_IDSach.TabIndex = 1;
            // 
            // lb_IDSach
            // 
            this.lb_IDSach.AutoSize = true;
            this.lb_IDSach.Location = new System.Drawing.Point(6, 72);
            this.lb_IDSach.Name = "lb_IDSach";
            this.lb_IDSach.Size = new System.Drawing.Size(135, 36);
            this.lb_IDSach.TabIndex = 0;
            this.lb_IDSach.Text = "Mã sách:";
            // 
            // grb_DataSearchBook
            // 
            this.grb_DataSearchBook.Controls.Add(this.dataGridView1);
            this.grb_DataSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataSearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataSearchBook.Location = new System.Drawing.Point(12, 452);
            this.grb_DataSearchBook.Name = "grb_DataSearchBook";
            this.grb_DataSearchBook.Size = new System.Drawing.Size(1905, 645);
            this.grb_DataSearchBook.TabIndex = 1;
            this.grb_DataSearchBook.TabStop = false;
            this.grb_DataSearchBook.Text = "Danh sách sách vừa tra cứu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1892, 638);
            this.dataGridView1.TabIndex = 0;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Search.Location = new System.Drawing.Point(810, 45);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(374, 69);
            this.lb_Search.TabIndex = 2;
            this.lb_Search.Text = "Tra cứu sách";
            // 
            // lb_NXB
            // 
            this.lb_NXB.AutoSize = true;
            this.lb_NXB.Location = new System.Drawing.Point(488, 144);
            this.lb_NXB.Name = "lb_NXB";
            this.lb_NXB.Size = new System.Drawing.Size(200, 36);
            this.lb_NXB.TabIndex = 6;
            this.lb_NXB.Text = "Nhà xuất bản:";
            // 
            // tb_NXB
            // 
            this.tb_NXB.Location = new System.Drawing.Point(694, 141);
            this.tb_NXB.Name = "tb_NXB";
            this.tb_NXB.Size = new System.Drawing.Size(232, 41);
            this.tb_NXB.TabIndex = 7;
            // 
            // lb_YXB
            // 
            this.lb_YXB.AutoSize = true;
            this.lb_YXB.Location = new System.Drawing.Point(6, 225);
            this.lb_YXB.Name = "lb_YXB";
            this.lb_YXB.Size = new System.Drawing.Size(206, 36);
            this.lb_YXB.TabIndex = 8;
            this.lb_YXB.Text = "Năm xuất bản:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.comboBox1.Location = new System.Drawing.Point(220, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 44);
            this.comboBox1.TabIndex = 9;
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.btn_Search);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(1118, 317);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(454, 129);
            this.grb_DieuKhien.TabIndex = 3;
            this.grb_DieuKhien.TabStop = false;
            this.grb_DieuKhien.Text = "Tác vụ:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(20, 57);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(170, 47);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 1109);
            this.Controls.Add(this.grb_DieuKhien);
            this.Controls.Add(this.lb_Search);
            this.Controls.Add(this.grb_DataSearchBook);
            this.Controls.Add(this.grb_SearchBook);
            this.Name = "frmSearchBook";
            this.Text = "frmSearchBook";
            this.grb_SearchBook.ResumeLayout(false);
            this.grb_SearchBook.PerformLayout();
            this.grb_DataSearchBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_DieuKhien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_SearchBook;
        private System.Windows.Forms.GroupBox grb_DataSearchBook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.Label lb_TheLoai;
        private System.Windows.Forms.TextBox tb_IDSach;
        private System.Windows.Forms.Label lb_IDSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_TheLoai;
        private System.Windows.Forms.ComboBox cbb_TacGia;
        private System.Windows.Forms.Label lb_TacGia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_YXB;
        private System.Windows.Forms.TextBox tb_NXB;
        private System.Windows.Forms.Label lb_NXB;
        private System.Windows.Forms.GroupBox grb_DieuKhien;
        private System.Windows.Forms.Button btn_Search;
    }
}