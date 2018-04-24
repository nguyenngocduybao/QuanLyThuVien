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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchBook));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grb_DieuKhien = new System.Windows.Forms.GroupBox();
            this.btn_HienDL = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grb_SearchBook = new System.Windows.Forms.GroupBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.rd_YXB = new System.Windows.Forms.RadioButton();
            this.rd_TinhTrang = new System.Windows.Forms.RadioButton();
            this.rd_TheLoai = new System.Windows.Forms.RadioButton();
            this.rd_TacGia = new System.Windows.Forms.RadioButton();
            this.rd_NXB = new System.Windows.Forms.RadioButton();
            this.rd_TenSach = new System.Windows.Forms.RadioButton();
            this.rd_IDSach = new System.Windows.Forms.RadioButton();
            this.lb_Search = new System.Windows.Forms.Label();
            this.grb_DataSearchBook = new System.Windows.Forms.GroupBox();
            this.dgv_SearchBook = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grb_DieuKhien.SuspendLayout();
            this.grb_SearchBook.SuspendLayout();
            this.grb_DataSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchBook)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.grb_DieuKhien);
            this.bunifuGradientPanel1.Controls.Add(this.grb_SearchBook);
            this.bunifuGradientPanel1.Controls.Add(this.lb_Search);
            this.bunifuGradientPanel1.Controls.Add(this.grb_DataSearchBook);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1929, 1092);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // grb_DieuKhien
            // 
            this.grb_DieuKhien.Controls.Add(this.btn_HienDL);
            this.grb_DieuKhien.Controls.Add(this.btn_Back);
            this.grb_DieuKhien.Controls.Add(this.btn_Search);
            this.grb_DieuKhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DieuKhien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DieuKhien.Location = new System.Drawing.Point(1149, 295);
            this.grb_DieuKhien.Name = "grb_DieuKhien";
            this.grb_DieuKhien.Size = new System.Drawing.Size(702, 131);
            this.grb_DieuKhien.TabIndex = 8;
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
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(495, 49);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(140, 51);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(35, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 51);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // grb_SearchBook
            // 
            this.grb_SearchBook.Controls.Add(this.tb_Search);
            this.grb_SearchBook.Controls.Add(this.rd_YXB);
            this.grb_SearchBook.Controls.Add(this.rd_TinhTrang);
            this.grb_SearchBook.Controls.Add(this.rd_TheLoai);
            this.grb_SearchBook.Controls.Add(this.rd_TacGia);
            this.grb_SearchBook.Controls.Add(this.rd_NXB);
            this.grb_SearchBook.Controls.Add(this.rd_TenSach);
            this.grb_SearchBook.Controls.Add(this.rd_IDSach);
            this.grb_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_SearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_SearchBook.Location = new System.Drawing.Point(19, 161);
            this.grb_SearchBook.Name = "grb_SearchBook";
            this.grb_SearchBook.Size = new System.Drawing.Size(1087, 265);
            this.grb_SearchBook.TabIndex = 7;
            this.grb_SearchBook.TabStop = false;
            this.grb_SearchBook.Text = "Thông tin tra cứu";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(658, 134);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(285, 41);
            this.tb_Search.TabIndex = 7;
            // 
            // rd_YXB
            // 
            this.rd_YXB.AutoSize = true;
            this.rd_YXB.Location = new System.Drawing.Point(658, 59);
            this.rd_YXB.Name = "rd_YXB";
            this.rd_YXB.Size = new System.Drawing.Size(223, 40);
            this.rd_YXB.TabIndex = 6;
            this.rd_YXB.TabStop = true;
            this.rd_YXB.Text = "Năm xuất bản";
            this.rd_YXB.UseVisualStyleBackColor = true;
            // 
            // rd_TinhTrang
            // 
            this.rd_TinhTrang.AutoSize = true;
            this.rd_TinhTrang.Location = new System.Drawing.Point(365, 196);
            this.rd_TinhTrang.Name = "rd_TinhTrang";
            this.rd_TinhTrang.Size = new System.Drawing.Size(175, 40);
            this.rd_TinhTrang.TabIndex = 5;
            this.rd_TinhTrang.TabStop = true;
            this.rd_TinhTrang.Text = "Tình trạng";
            this.rd_TinhTrang.UseVisualStyleBackColor = true;
            // 
            // rd_TheLoai
            // 
            this.rd_TheLoai.AutoSize = true;
            this.rd_TheLoai.Location = new System.Drawing.Point(365, 134);
            this.rd_TheLoai.Name = "rd_TheLoai";
            this.rd_TheLoai.Size = new System.Drawing.Size(146, 40);
            this.rd_TheLoai.TabIndex = 4;
            this.rd_TheLoai.TabStop = true;
            this.rd_TheLoai.Text = "Thể loại";
            this.rd_TheLoai.UseVisualStyleBackColor = true;
            // 
            // rd_TacGia
            // 
            this.rd_TacGia.AutoSize = true;
            this.rd_TacGia.Location = new System.Drawing.Point(365, 59);
            this.rd_TacGia.Name = "rd_TacGia";
            this.rd_TacGia.Size = new System.Drawing.Size(137, 40);
            this.rd_TacGia.TabIndex = 3;
            this.rd_TacGia.TabStop = true;
            this.rd_TacGia.Text = "Tác giả";
            this.rd_TacGia.UseVisualStyleBackColor = true;
            // 
            // rd_NXB
            // 
            this.rd_NXB.AutoSize = true;
            this.rd_NXB.Location = new System.Drawing.Point(33, 196);
            this.rd_NXB.Name = "rd_NXB";
            this.rd_NXB.Size = new System.Drawing.Size(217, 40);
            this.rd_NXB.TabIndex = 2;
            this.rd_NXB.TabStop = true;
            this.rd_NXB.Text = "Nhà xuất bản";
            this.rd_NXB.UseVisualStyleBackColor = true;
            // 
            // rd_TenSach
            // 
            this.rd_TenSach.AutoSize = true;
            this.rd_TenSach.Location = new System.Drawing.Point(33, 134);
            this.rd_TenSach.Name = "rd_TenSach";
            this.rd_TenSach.Size = new System.Drawing.Size(162, 40);
            this.rd_TenSach.TabIndex = 1;
            this.rd_TenSach.TabStop = true;
            this.rd_TenSach.Text = "Tên sách";
            this.rd_TenSach.UseVisualStyleBackColor = true;
            // 
            // rd_IDSach
            // 
            this.rd_IDSach.AutoSize = true;
            this.rd_IDSach.Location = new System.Drawing.Point(33, 59);
            this.rd_IDSach.Name = "rd_IDSach";
            this.rd_IDSach.Size = new System.Drawing.Size(140, 40);
            this.rd_IDSach.TabIndex = 0;
            this.rd_IDSach.TabStop = true;
            this.rd_IDSach.Text = "ID sách";
            this.rd_IDSach.UseVisualStyleBackColor = true;
            // 
            // lb_Search
            // 
            this.lb_Search.AutoSize = true;
            this.lb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Search.Location = new System.Drawing.Point(825, 32);
            this.lb_Search.Name = "lb_Search";
            this.lb_Search.Size = new System.Drawing.Size(374, 69);
            this.lb_Search.TabIndex = 6;
            this.lb_Search.Text = "Tra cứu sách";
            // 
            // grb_DataSearchBook
            // 
            this.grb_DataSearchBook.Controls.Add(this.dgv_SearchBook);
            this.grb_DataSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataSearchBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataSearchBook.Location = new System.Drawing.Point(12, 432);
            this.grb_DataSearchBook.Name = "grb_DataSearchBook";
            this.grb_DataSearchBook.Size = new System.Drawing.Size(1905, 645);
            this.grb_DataSearchBook.TabIndex = 5;
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
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 1092);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmSearchBook";
            this.Text = "frmSearchBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchBook_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grb_DieuKhien.ResumeLayout(false);
            this.grb_SearchBook.ResumeLayout(false);
            this.grb_SearchBook.PerformLayout();
            this.grb_DataSearchBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grb_DieuKhien;
        private System.Windows.Forms.Button btn_HienDL;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox grb_SearchBook;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.RadioButton rd_YXB;
        private System.Windows.Forms.RadioButton rd_TinhTrang;
        private System.Windows.Forms.RadioButton rd_TheLoai;
        private System.Windows.Forms.RadioButton rd_TacGia;
        private System.Windows.Forms.RadioButton rd_NXB;
        private System.Windows.Forms.RadioButton rd_TenSach;
        private System.Windows.Forms.RadioButton rd_IDSach;
        private System.Windows.Forms.Label lb_Search;
        private System.Windows.Forms.GroupBox grb_DataSearchBook;
        private System.Windows.Forms.DataGridView dgv_SearchBook;
    }
}