namespace QuanLyThuVien
{
    partial class frmPhieuMuon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_MuonSach = new System.Windows.Forms.TabPage();
            this.tab_TraSach = new System.Windows.Forms.TabPage();
            this.lb_MuonSach = new System.Windows.Forms.Label();
            this.lb_IDPhieuMuon = new System.Windows.Forms.Label();
            this.tb_IDPhieuMuon = new System.Windows.Forms.TextBox();
            this.lb_IDUser = new System.Windows.Forms.Label();
            this.cbb_User = new System.Windows.Forms.ComboBox();
            this.grb_ThongTinMuon = new System.Windows.Forms.GroupBox();
            this.lb_NameUser = new System.Windows.Forms.Label();
            this.lb_ShowNameUser = new System.Windows.Forms.Label();
            this.lb_NgayMuon = new System.Windows.Forms.Label();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lb_IDSach = new System.Windows.Forms.Label();
            this.cbb_Book = new System.Windows.Forms.ComboBox();
            this.grb_DataBook = new System.Windows.Forms.GroupBox();
            this.dgv_Book = new System.Windows.Forms.DataGridView();
            this.grb_Datas = new System.Windows.Forms.GroupBox();
            this.dgv_PhieuMuon = new System.Windows.Forms.DataGridView();
            this.lb_SachMuon = new System.Windows.Forms.Label();
            this.cbb_SoSachMuon = new System.Windows.Forms.ComboBox();
            this.btnn_ThemSach = new System.Windows.Forms.Button();
            this.btn_SavePM = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_MuonSach.SuspendLayout();
            this.grb_ThongTinMuon.SuspendLayout();
            this.grb_DataBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            this.grb_Datas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_MuonSach);
            this.tabControl1.Controls.Add(this.tab_TraSach);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1889, 1002);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_MuonSach
            // 
            this.tab_MuonSach.Controls.Add(this.grb_Datas);
            this.tab_MuonSach.Controls.Add(this.grb_DataBook);
            this.tab_MuonSach.Controls.Add(this.lb_MuonSach);
            this.tab_MuonSach.Controls.Add(this.grb_ThongTinMuon);
            this.tab_MuonSach.Location = new System.Drawing.Point(4, 29);
            this.tab_MuonSach.Name = "tab_MuonSach";
            this.tab_MuonSach.Padding = new System.Windows.Forms.Padding(3);
            this.tab_MuonSach.Size = new System.Drawing.Size(1881, 969);
            this.tab_MuonSach.TabIndex = 0;
            this.tab_MuonSach.Text = "Mượn sách";
            this.tab_MuonSach.UseVisualStyleBackColor = true;
            // 
            // tab_TraSach
            // 
            this.tab_TraSach.Location = new System.Drawing.Point(4, 29);
            this.tab_TraSach.Name = "tab_TraSach";
            this.tab_TraSach.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TraSach.Size = new System.Drawing.Size(1881, 969);
            this.tab_TraSach.TabIndex = 1;
            this.tab_TraSach.Text = "Trả sách";
            this.tab_TraSach.UseVisualStyleBackColor = true;
            // 
            // lb_MuonSach
            // 
            this.lb_MuonSach.AutoSize = true;
            this.lb_MuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MuonSach.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_MuonSach.Location = new System.Drawing.Point(765, 33);
            this.lb_MuonSach.Name = "lb_MuonSach";
            this.lb_MuonSach.Size = new System.Drawing.Size(216, 46);
            this.lb_MuonSach.TabIndex = 1;
            this.lb_MuonSach.Text = "Mượn sách";
            // 
            // lb_IDPhieuMuon
            // 
            this.lb_IDPhieuMuon.AutoSize = true;
            this.lb_IDPhieuMuon.Location = new System.Drawing.Point(7, 59);
            this.lb_IDPhieuMuon.Name = "lb_IDPhieuMuon";
            this.lb_IDPhieuMuon.Size = new System.Drawing.Size(216, 36);
            this.lb_IDPhieuMuon.TabIndex = 0;
            this.lb_IDPhieuMuon.Text = "ID phiếu mượn:";
            // 
            // tb_IDPhieuMuon
            // 
            this.tb_IDPhieuMuon.Location = new System.Drawing.Point(252, 56);
            this.tb_IDPhieuMuon.Name = "tb_IDPhieuMuon";
            this.tb_IDPhieuMuon.Size = new System.Drawing.Size(230, 41);
            this.tb_IDPhieuMuon.TabIndex = 1;
            this.tb_IDPhieuMuon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IDPhieuMuon_KeyPress);
            // 
            // lb_IDUser
            // 
            this.lb_IDUser.AutoSize = true;
            this.lb_IDUser.Location = new System.Drawing.Point(7, 120);
            this.lb_IDUser.Name = "lb_IDUser";
            this.lb_IDUser.Size = new System.Drawing.Size(217, 36);
            this.lb_IDUser.TabIndex = 2;
            this.lb_IDUser.Text = "ID người mượn:";
            // 
            // cbb_User
            // 
            this.cbb_User.FormattingEnabled = true;
            this.cbb_User.Location = new System.Drawing.Point(252, 117);
            this.cbb_User.Name = "cbb_User";
            this.cbb_User.Size = new System.Drawing.Size(230, 44);
            this.cbb_User.TabIndex = 3;
            this.cbb_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbb_User_KeyPress);
            // 
            // grb_ThongTinMuon
            // 
            this.grb_ThongTinMuon.Controls.Add(this.btn_Delete);
            this.grb_ThongTinMuon.Controls.Add(this.btn_Edit);
            this.grb_ThongTinMuon.Controls.Add(this.btn_SavePM);
            this.grb_ThongTinMuon.Controls.Add(this.btnn_ThemSach);
            this.grb_ThongTinMuon.Controls.Add(this.cbb_SoSachMuon);
            this.grb_ThongTinMuon.Controls.Add(this.lb_SachMuon);
            this.grb_ThongTinMuon.Controls.Add(this.cbb_Book);
            this.grb_ThongTinMuon.Controls.Add(this.lb_IDSach);
            this.grb_ThongTinMuon.Controls.Add(this.dtp_NgayMuon);
            this.grb_ThongTinMuon.Controls.Add(this.lb_NgayMuon);
            this.grb_ThongTinMuon.Controls.Add(this.lb_ShowNameUser);
            this.grb_ThongTinMuon.Controls.Add(this.lb_NameUser);
            this.grb_ThongTinMuon.Controls.Add(this.cbb_User);
            this.grb_ThongTinMuon.Controls.Add(this.lb_IDUser);
            this.grb_ThongTinMuon.Controls.Add(this.tb_IDPhieuMuon);
            this.grb_ThongTinMuon.Controls.Add(this.lb_IDPhieuMuon);
            this.grb_ThongTinMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTinMuon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_ThongTinMuon.Location = new System.Drawing.Point(6, 86);
            this.grb_ThongTinMuon.Name = "grb_ThongTinMuon";
            this.grb_ThongTinMuon.Size = new System.Drawing.Size(750, 405);
            this.grb_ThongTinMuon.TabIndex = 0;
            this.grb_ThongTinMuon.TabStop = false;
            this.grb_ThongTinMuon.Text = "Thông tin mượn sách";
            // 
            // lb_NameUser
            // 
            this.lb_NameUser.AutoSize = true;
            this.lb_NameUser.Location = new System.Drawing.Point(7, 173);
            this.lb_NameUser.Name = "lb_NameUser";
            this.lb_NameUser.Size = new System.Drawing.Size(239, 36);
            this.lb_NameUser.TabIndex = 4;
            this.lb_NameUser.Text = "Tên người mượn:";
            // 
            // lb_ShowNameUser
            // 
            this.lb_ShowNameUser.AutoSize = true;
            this.lb_ShowNameUser.Location = new System.Drawing.Point(246, 173);
            this.lb_ShowNameUser.Name = "lb_ShowNameUser";
            this.lb_ShowNameUser.Size = new System.Drawing.Size(93, 36);
            this.lb_ShowNameUser.TabIndex = 5;
            this.lb_ShowNameUser.Text = "NULL";
            // 
            // lb_NgayMuon
            // 
            this.lb_NgayMuon.AutoSize = true;
            this.lb_NgayMuon.Location = new System.Drawing.Point(7, 220);
            this.lb_NgayMuon.Name = "lb_NgayMuon";
            this.lb_NgayMuon.Size = new System.Drawing.Size(175, 36);
            this.lb_NgayMuon.TabIndex = 6;
            this.lb_NgayMuon.Text = "Ngày mượn:";
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(252, 215);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(230, 41);
            this.dtp_NgayMuon.TabIndex = 7;
            // 
            // lb_IDSach
            // 
            this.lb_IDSach.AutoSize = true;
            this.lb_IDSach.Location = new System.Drawing.Point(6, 338);
            this.lb_IDSach.Name = "lb_IDSach";
            this.lb_IDSach.Size = new System.Drawing.Size(205, 36);
            this.lb_IDSach.TabIndex = 8;
            this.lb_IDSach.Text = "ID sách mượn:";
            // 
            // cbb_Book
            // 
            this.cbb_Book.FormattingEnabled = true;
            this.cbb_Book.Location = new System.Drawing.Point(252, 335);
            this.cbb_Book.Name = "cbb_Book";
            this.cbb_Book.Size = new System.Drawing.Size(230, 44);
            this.cbb_Book.TabIndex = 9;
            // 
            // grb_DataBook
            // 
            this.grb_DataBook.Controls.Add(this.dgv_Book);
            this.grb_DataBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_DataBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_DataBook.Location = new System.Drawing.Point(6, 497);
            this.grb_DataBook.Name = "grb_DataBook";
            this.grb_DataBook.Size = new System.Drawing.Size(750, 376);
            this.grb_DataBook.TabIndex = 2;
            this.grb_DataBook.TabStop = false;
            this.grb_DataBook.Text = "Danh sách sách mượn";
            // 
            // dgv_Book
            // 
            this.dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book.Location = new System.Drawing.Point(13, 40);
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.RowTemplate.Height = 28;
            this.dgv_Book.Size = new System.Drawing.Size(731, 322);
            this.dgv_Book.TabIndex = 0;
            // 
            // grb_Datas
            // 
            this.grb_Datas.Controls.Add(this.dgv_PhieuMuon);
            this.grb_Datas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Datas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Datas.Location = new System.Drawing.Point(794, 86);
            this.grb_Datas.Name = "grb_Datas";
            this.grb_Datas.Size = new System.Drawing.Size(1025, 760);
            this.grb_Datas.TabIndex = 3;
            this.grb_Datas.TabStop = false;
            this.grb_Datas.Text = "Thông tin phiếu mượn";
            // 
            // dgv_PhieuMuon
            // 
            this.dgv_PhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuMuon.Location = new System.Drawing.Point(6, 40);
            this.dgv_PhieuMuon.Name = "dgv_PhieuMuon";
            this.dgv_PhieuMuon.RowTemplate.Height = 28;
            this.dgv_PhieuMuon.Size = new System.Drawing.Size(1013, 714);
            this.dgv_PhieuMuon.TabIndex = 0;
            // 
            // lb_SachMuon
            // 
            this.lb_SachMuon.AutoSize = true;
            this.lb_SachMuon.Location = new System.Drawing.Point(6, 279);
            this.lb_SachMuon.Name = "lb_SachMuon";
            this.lb_SachMuon.Size = new System.Drawing.Size(213, 36);
            this.lb_SachMuon.TabIndex = 10;
            this.lb_SachMuon.Text = "Số sách mượn:";
            // 
            // cbb_SoSachMuon
            // 
            this.cbb_SoSachMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_SoSachMuon.FormattingEnabled = true;
            this.cbb_SoSachMuon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbb_SoSachMuon.Location = new System.Drawing.Point(252, 276);
            this.cbb_SoSachMuon.Name = "cbb_SoSachMuon";
            this.cbb_SoSachMuon.Size = new System.Drawing.Size(230, 44);
            this.cbb_SoSachMuon.TabIndex = 11;
            // 
            // btnn_ThemSach
            // 
            this.btnn_ThemSach.Location = new System.Drawing.Point(526, 334);
            this.btnn_ThemSach.Name = "btnn_ThemSach";
            this.btnn_ThemSach.Size = new System.Drawing.Size(174, 44);
            this.btnn_ThemSach.TabIndex = 12;
            this.btnn_ThemSach.Text = "Thêm sách";
            this.btnn_ThemSach.UseVisualStyleBackColor = true;
            // 
            // btn_SavePM
            // 
            this.btn_SavePM.Location = new System.Drawing.Point(526, 81);
            this.btn_SavePM.Name = "btn_SavePM";
            this.btn_SavePM.Size = new System.Drawing.Size(174, 43);
            this.btn_SavePM.TabIndex = 13;
            this.btn_SavePM.Text = "Lưu";
            this.btn_SavePM.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(526, 150);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(174, 41);
            this.btn_Edit.TabIndex = 14;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(526, 209);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(174, 41);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 1018);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPhieuMuon";
            this.Text = "frmPhieuMuon";
            this.tabControl1.ResumeLayout(false);
            this.tab_MuonSach.ResumeLayout(false);
            this.tab_MuonSach.PerformLayout();
            this.grb_ThongTinMuon.ResumeLayout(false);
            this.grb_ThongTinMuon.PerformLayout();
            this.grb_DataBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.grb_Datas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_MuonSach;
        private System.Windows.Forms.TabPage tab_TraSach;
        private System.Windows.Forms.Label lb_MuonSach;
        private System.Windows.Forms.GroupBox grb_ThongTinMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Label lb_NgayMuon;
        private System.Windows.Forms.Label lb_ShowNameUser;
        private System.Windows.Forms.Label lb_NameUser;
        private System.Windows.Forms.ComboBox cbb_User;
        private System.Windows.Forms.Label lb_IDUser;
        private System.Windows.Forms.TextBox tb_IDPhieuMuon;
        private System.Windows.Forms.Label lb_IDPhieuMuon;
        private System.Windows.Forms.GroupBox grb_Datas;
        private System.Windows.Forms.DataGridView dgv_PhieuMuon;
        private System.Windows.Forms.GroupBox grb_DataBook;
        private System.Windows.Forms.DataGridView dgv_Book;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_SavePM;
        private System.Windows.Forms.Button btnn_ThemSach;
        private System.Windows.Forms.ComboBox cbb_SoSachMuon;
        private System.Windows.Forms.Label lb_SachMuon;
        private System.Windows.Forms.ComboBox cbb_Book;
        private System.Windows.Forms.Label lb_IDSach;
    }
}