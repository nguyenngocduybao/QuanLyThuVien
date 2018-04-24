namespace QuanLyThuVien
{
    partial class frmAddCuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCuonSach));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.dgv_CuonSach = new System.Windows.Forms.DataGridView();
            this.grb_Info = new System.Windows.Forms.GroupBox();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.tb_IDDauSach = new System.Windows.Forms.TextBox();
            this.tb_IDCuonSach = new System.Windows.Forms.TextBox();
            this.lb_TinhTrang = new System.Windows.Forms.Label();
            this.lb_IDDauSach = new System.Windows.Forms.Label();
            this.lb_IDCuonSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_Control = new System.Windows.Forms.GroupBox();
            this.btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.tb_Delete = new System.Windows.Forms.TextBox();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grb_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuonSach)).BeginInit();
            this.grb_Info.SuspendLayout();
            this.grb_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.grb_Control);
            this.bunifuGradientPanel1.Controls.Add(this.grb_ThongTin);
            this.bunifuGradientPanel1.Controls.Add(this.grb_Info);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1161, 739);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.dgv_CuonSach);
            this.grb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ThongTin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_ThongTin.Location = new System.Drawing.Point(525, 149);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(624, 581);
            this.grb_ThongTin.TabIndex = 2;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Bảng thông tin sách";
            // 
            // dgv_CuonSach
            // 
            this.dgv_CuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CuonSach.Location = new System.Drawing.Point(3, 37);
            this.dgv_CuonSach.Name = "dgv_CuonSach";
            this.dgv_CuonSach.RowTemplate.Height = 28;
            this.dgv_CuonSach.Size = new System.Drawing.Size(618, 541);
            this.dgv_CuonSach.TabIndex = 0;
            // 
            // grb_Info
            // 
            this.grb_Info.Controls.Add(this.cbb_TinhTrang);
            this.grb_Info.Controls.Add(this.tb_IDDauSach);
            this.grb_Info.Controls.Add(this.tb_IDCuonSach);
            this.grb_Info.Controls.Add(this.lb_TinhTrang);
            this.grb_Info.Controls.Add(this.lb_IDDauSach);
            this.grb_Info.Controls.Add(this.lb_IDCuonSach);
            this.grb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Info.Location = new System.Drawing.Point(12, 149);
            this.grb_Info.Name = "grb_Info";
            this.grb_Info.Size = new System.Drawing.Size(476, 239);
            this.grb_Info.TabIndex = 1;
            this.grb_Info.TabStop = false;
            this.grb_Info.Text = "Thông tin cuốn sách";
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Items.AddRange(new object[] {
            "Đã cho mượn",
            "Chưa cho mượn"});
            this.cbb_TinhTrang.Location = new System.Drawing.Point(209, 176);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(246, 44);
            this.cbb_TinhTrang.TabIndex = 5;
            // 
            // tb_IDDauSach
            // 
            this.tb_IDDauSach.Location = new System.Drawing.Point(209, 114);
            this.tb_IDDauSach.Name = "tb_IDDauSach";
            this.tb_IDDauSach.Size = new System.Drawing.Size(246, 41);
            this.tb_IDDauSach.TabIndex = 4;
            // 
            // tb_IDCuonSach
            // 
            this.tb_IDCuonSach.Location = new System.Drawing.Point(209, 54);
            this.tb_IDCuonSach.Name = "tb_IDCuonSach";
            this.tb_IDCuonSach.Size = new System.Drawing.Size(246, 41);
            this.tb_IDCuonSach.TabIndex = 3;
            // 
            // lb_TinhTrang
            // 
            this.lb_TinhTrang.AutoSize = true;
            this.lb_TinhTrang.Location = new System.Drawing.Point(6, 179);
            this.lb_TinhTrang.Name = "lb_TinhTrang";
            this.lb_TinhTrang.Size = new System.Drawing.Size(158, 36);
            this.lb_TinhTrang.TabIndex = 2;
            this.lb_TinhTrang.Text = "Tình trạng:";
            // 
            // lb_IDDauSach
            // 
            this.lb_IDDauSach.AutoSize = true;
            this.lb_IDDauSach.Location = new System.Drawing.Point(6, 117);
            this.lb_IDDauSach.Name = "lb_IDDauSach";
            this.lb_IDDauSach.Size = new System.Drawing.Size(181, 36);
            this.lb_IDDauSach.TabIndex = 1;
            this.lb_IDDauSach.Text = "ID đầu sách:";
            // 
            // lb_IDCuonSach
            // 
            this.lb_IDCuonSach.AutoSize = true;
            this.lb_IDCuonSach.Location = new System.Drawing.Point(6, 57);
            this.lb_IDCuonSach.Name = "lb_IDCuonSach";
            this.lb_IDCuonSach.Size = new System.Drawing.Size(197, 36);
            this.lb_IDCuonSach.TabIndex = 0;
            this.lb_IDCuonSach.Text = "ID cuốn sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(322, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin cuốn sách";
            // 
            // grb_Control
            // 
            this.grb_Control.Controls.Add(this.btn_Delete);
            this.grb_Control.Controls.Add(this.tb_Delete);
            this.grb_Control.Controls.Add(this.label2);
            this.grb_Control.Controls.Add(this.btn_Back);
            this.grb_Control.Controls.Add(this.btn_Edit);
            this.grb_Control.Controls.Add(this.btn_Add);
            this.grb_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Control.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Control.Location = new System.Drawing.Point(15, 394);
            this.grb_Control.Name = "grb_Control";
            this.grb_Control.Size = new System.Drawing.Size(473, 336);
            this.grb_Control.TabIndex = 3;
            this.grb_Control.TabStop = false;
            this.grb_Control.Text = "Điều khiển";
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
            this.btn_Add.Location = new System.Drawing.Point(9, 43);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(128, 129);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.btn_Edit.Location = new System.Drawing.Point(161, 43);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(128, 129);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            this.btn_Back.Location = new System.Drawing.Point(324, 43);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(128, 129);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tb_Delete
            // 
            this.tb_Delete.Location = new System.Drawing.Point(6, 247);
            this.tb_Delete.Name = "tb_Delete";
            this.tb_Delete.Size = new System.Drawing.Size(280, 41);
            this.tb_Delete.TabIndex = 4;
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
            this.btn_Delete.Location = new System.Drawing.Point(324, 198);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(128, 129);
            this.btn_Delete.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID cuốn sách cần xóa:";
            // 
            // frmAddCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 739);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmAddCuonSach";
            this.Text = "frmAddCuonSach";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grb_ThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuonSach)).EndInit();
            this.grb_Info.ResumeLayout(false);
            this.grb_Info.PerformLayout();
            this.grb_Control.ResumeLayout(false);
            this.grb_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.DataGridView dgv_CuonSach;
        private System.Windows.Forms.GroupBox grb_Info;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.TextBox tb_IDDauSach;
        private System.Windows.Forms.TextBox tb_IDCuonSach;
        private System.Windows.Forms.Label lb_TinhTrang;
        private System.Windows.Forms.Label lb_IDDauSach;
        private System.Windows.Forms.Label lb_IDCuonSach;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grb_Control;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
        private System.Windows.Forms.TextBox tb_Delete;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private Bunifu.Framework.UI.BunifuTileButton btn_Edit;
        private Bunifu.Framework.UI.BunifuTileButton btn_Add;
    }
}