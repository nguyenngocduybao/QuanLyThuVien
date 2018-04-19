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
            this.lb_Search = new System.Windows.Forms.Label();
            this.grb_SearchBook = new System.Windows.Forms.GroupBox();
            this.lb_YXB = new System.Windows.Forms.Label();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.lb_TheLoai = new System.Windows.Forms.Label();
            this.lb_IDTacGia = new System.Windows.Forms.Label();
            this.lb_NhaXB = new System.Windows.Forms.Label();
            this.lb_NameBook = new System.Windows.Forms.Label();
            this.lb_IDBook = new System.Windows.Forms.Label();
            this.cb_YXB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_IDTacGia = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_TheLoai = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_TinhTrang = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_NXB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_NameBook = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cb_IDBook = new Bunifu.Framework.UI.BunifuCheckbox();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.btn_HienDL = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grb_DataSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchBook)).BeginInit();
            this.grb_SearchBook.SuspendLayout();
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
            this.grb_SearchBook.Controls.Add(this.lb_YXB);
            this.grb_SearchBook.Controls.Add(this.lb_TinhTrang);
            this.grb_SearchBook.Controls.Add(this.lb_TheLoai);
            this.grb_SearchBook.Controls.Add(this.lb_IDTacGia);
            this.grb_SearchBook.Controls.Add(this.lb_NhaXB);
            this.grb_SearchBook.Controls.Add(this.lb_NameBook);
            this.grb_SearchBook.Controls.Add(this.lb_IDBook);
            this.grb_SearchBook.Controls.Add(this.cb_YXB);
            this.grb_SearchBook.Controls.Add(this.cb_IDTacGia);
            this.grb_SearchBook.Controls.Add(this.cb_TheLoai);
            this.grb_SearchBook.Controls.Add(this.cb_TinhTrang);
            this.grb_SearchBook.Controls.Add(this.cb_NXB);
            this.grb_SearchBook.Controls.Add(this.cb_NameBook);
            this.grb_SearchBook.Controls.Add(this.cb_IDBook);
            this.grb_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_SearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_SearchBook.Location = new System.Drawing.Point(19, 181);
            this.grb_SearchBook.Name = "grb_SearchBook";
            this.grb_SearchBook.Size = new System.Drawing.Size(1087, 265);
            this.grb_SearchBook.TabIndex = 3;
            this.grb_SearchBook.TabStop = false;
            this.grb_SearchBook.Text = "Thông tin tra cứu";
            // 
            // lb_YXB
            // 
            this.lb_YXB.AutoSize = true;
            this.lb_YXB.Location = new System.Drawing.Point(733, 68);
            this.lb_YXB.Name = "lb_YXB";
            this.lb_YXB.Size = new System.Drawing.Size(198, 36);
            this.lb_YXB.TabIndex = 13;
            this.lb_YXB.Text = "Năm xuất bản";
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.Location = new System.Drawing.Point(423, 212);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(150, 36);
            this.lb_TinhTrang.TabIndex = 12;
            this.lb_TinhTrang.Text = "Tình trạng";
            // 
            // lb_TheLoai
            // 
            this.lb_TheLoai.AutoSize = true;
            this.lb_TheLoai.Location = new System.Drawing.Point(423, 147);
            this.lb_TheLoai.Name = "lb_TheLoai";
            this.lb_TheLoai.Size = new System.Drawing.Size(121, 36);
            this.lb_TheLoai.TabIndex = 11;
            this.lb_TheLoai.Text = "Thể loại";
            // 
            // lb_IDTacGia
            // 
            this.lb_IDTacGia.AutoSize = true;
            this.lb_IDTacGia.Location = new System.Drawing.Point(423, 68);
            this.lb_IDTacGia.Name = "lb_IDTacGia";
            this.lb_IDTacGia.Size = new System.Drawing.Size(139, 36);
            this.lb_IDTacGia.TabIndex = 10;
            this.lb_IDTacGia.Text = "ID tác giả";
            // 
            // lb_NhaXB
            // 
            this.lb_NhaXB.AutoSize = true;
            this.lb_NhaXB.Location = new System.Drawing.Point(76, 212);
            this.lb_NhaXB.Name = "lb_NhaXB";
            this.lb_NhaXB.Size = new System.Drawing.Size(192, 36);
            this.lb_NhaXB.TabIndex = 9;
            this.lb_NhaXB.Text = "Nhà xuất bản";
            // 
            // lb_NameBook
            // 
            this.lb_NameBook.AutoSize = true;
            this.lb_NameBook.Location = new System.Drawing.Point(76, 147);
            this.lb_NameBook.Name = "lb_NameBook";
            this.lb_NameBook.Size = new System.Drawing.Size(137, 36);
            this.lb_NameBook.TabIndex = 8;
            this.lb_NameBook.Text = "Tên sách";
            // 
            // lb_IDBook
            // 
            this.lb_IDBook.AutoSize = true;
            this.lb_IDBook.Location = new System.Drawing.Point(76, 68);
            this.lb_IDBook.Name = "lb_IDBook";
            this.lb_IDBook.Size = new System.Drawing.Size(115, 36);
            this.lb_IDBook.TabIndex = 7;
            this.lb_IDBook.Text = "ID sách";
            // 
            // cb_YXB
            // 
            this.cb_YXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_YXB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_YXB.Checked = false;
            this.cb_YXB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_YXB.ForeColor = System.Drawing.Color.White;
            this.cb_YXB.Location = new System.Drawing.Point(988, 84);
            this.cb_YXB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_YXB.Name = "cb_YXB";
            this.cb_YXB.Size = new System.Drawing.Size(20, 20);
            this.cb_YXB.TabIndex = 6;
            this.cb_YXB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // cb_IDTacGia
            // 
            this.cb_IDTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_IDTacGia.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_IDTacGia.Checked = false;
            this.cb_IDTacGia.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_IDTacGia.ForeColor = System.Drawing.Color.White;
            this.cb_IDTacGia.Location = new System.Drawing.Point(614, 84);
            this.cb_IDTacGia.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_IDTacGia.Name = "cb_IDTacGia";
            this.cb_IDTacGia.Size = new System.Drawing.Size(20, 20);
            this.cb_IDTacGia.TabIndex = 5;
            this.cb_IDTacGia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // cb_TheLoai
            // 
            this.cb_TheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_TheLoai.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_TheLoai.Checked = false;
            this.cb_TheLoai.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_TheLoai.ForeColor = System.Drawing.Color.White;
            this.cb_TheLoai.Location = new System.Drawing.Point(614, 163);
            this.cb_TheLoai.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_TheLoai.Name = "cb_TheLoai";
            this.cb_TheLoai.Size = new System.Drawing.Size(20, 20);
            this.cb_TheLoai.TabIndex = 4;
            this.cb_TheLoai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_TinhTrang.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_TinhTrang.Checked = false;
            this.cb_TinhTrang.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_TinhTrang.ForeColor = System.Drawing.Color.White;
            this.cb_TinhTrang.Location = new System.Drawing.Point(614, 228);
            this.cb_TinhTrang.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(20, 20);
            this.cb_TinhTrang.TabIndex = 3;
            this.cb_TinhTrang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // cb_NXB
            // 
            this.cb_NXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_NXB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_NXB.Checked = false;
            this.cb_NXB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_NXB.ForeColor = System.Drawing.Color.White;
            this.cb_NXB.Location = new System.Drawing.Point(296, 228);
            this.cb_NXB.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_NXB.Name = "cb_NXB";
            this.cb_NXB.Size = new System.Drawing.Size(20, 20);
            this.cb_NXB.TabIndex = 2;
            this.cb_NXB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // cb_NameBook
            // 
            this.cb_NameBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_NameBook.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_NameBook.Checked = false;
            this.cb_NameBook.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_NameBook.ForeColor = System.Drawing.Color.White;
            this.cb_NameBook.Location = new System.Drawing.Point(296, 163);
            this.cb_NameBook.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_NameBook.Name = "cb_NameBook";
            this.cb_NameBook.Size = new System.Drawing.Size(20, 20);
            this.cb_NameBook.TabIndex = 1;
            this.cb_NameBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // cb_IDBook
            // 
            this.cb_IDBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_IDBook.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_IDBook.Checked = false;
            this.cb_IDBook.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_IDBook.ForeColor = System.Drawing.Color.White;
            this.cb_IDBook.Location = new System.Drawing.Point(296, 84);
            this.cb_IDBook.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cb_IDBook.Name = "cb_IDBook";
            this.cb_IDBook.Size = new System.Drawing.Size(20, 20);
            this.cb_IDBook.TabIndex = 0;
            this.cb_IDBook.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbOnChange);
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.btn_HienDL);
            this.grb_DieuKhien.Controls.Add(this.btn_Back);
            this.grb_DieuKhien.Controls.Add(this.btn_Search);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(1149, 315);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(702, 131);
            this.grb_DieuKhien.TabIndex = 4;
            this.grb_DieuKhien.TabStop = false;
            this.grb_DieuKhien.Text = "Điều khiển";
            // 
            // btn_HienDL
            // 
            this.btn_HienDL.Location = new System.Drawing.Point(204, 49);
            this.btn_HienDL.Name = "btn_HienDL";
            this.btn_HienDL.Size = new System.Drawing.Size(247, 51);
            this.btn_HienDL.TabIndex = 2;
            this.btn_HienDL.Text = "Hiển thị dữ liệu";
            this.btn_HienDL.UseVisualStyleBackColor = true;
            this.btn_HienDL.Click += new System.EventHandler(this.btn_HienDL_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(495, 49);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 51);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            this.grb_SearchBook.PerformLayout();
            this.grb_DieuKhien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grb_DataSearchBook;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.DataGridView dgv_SearchBook;
        private System.Windows.Forms.GroupBox grb_SearchBook;
        private System.Windows.Forms.GroupBox grb_DieuKhien;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_HienDL;
        private Bunifu.Framework.UI.BunifuCheckbox cb_TinhTrang;
        private Bunifu.Framework.UI.BunifuCheckbox cb_NXB;
        private Bunifu.Framework.UI.BunifuCheckbox cb_NameBook;
        private Bunifu.Framework.UI.BunifuCheckbox cb_IDBook;
        private System.Windows.Forms.Label lb_YXB;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.Label lb_TheLoai;
        private System.Windows.Forms.Label lb_IDTacGia;
        private System.Windows.Forms.Label lb_NhaXB;
        private System.Windows.Forms.Label lb_IDBook;
        private Bunifu.Framework.UI.BunifuCheckbox cb_YXB;
        private Bunifu.Framework.UI.BunifuCheckbox cb_IDTacGia;
        private Bunifu.Framework.UI.BunifuCheckbox cb_TheLoai;
        private System.Windows.Forms.Label lb_NameBook;
    }
}