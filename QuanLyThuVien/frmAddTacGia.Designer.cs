namespace QuanLyThuVien
{
    partial class frmAddTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTacGia));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lb_TitleTacGia = new System.Windows.Forms.Label();
            this.grb_InfoTacGia = new System.Windows.Forms.GroupBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_TenTacGia = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.grb_TacGia = new System.Windows.Forms.GroupBox();
            this.dgv_TacGia = new System.Windows.Forms.DataGridView();
            this.grb_Control = new System.Windows.Forms.GroupBox();
            this.btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.lb_IDDelete = new System.Windows.Forms.Label();
            this.tb_IDDelete = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grb_InfoTacGia.SuspendLayout();
            this.grb_TacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).BeginInit();
            this.grb_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.grb_Control);
            this.bunifuGradientPanel1.Controls.Add(this.grb_TacGia);
            this.bunifuGradientPanel1.Controls.Add(this.grb_InfoTacGia);
            this.bunifuGradientPanel1.Controls.Add(this.lb_TitleTacGia);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1358, 782);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // lb_TitleTacGia
            // 
            this.lb_TitleTacGia.AutoSize = true;
            this.lb_TitleTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TitleTacGia.Location = new System.Drawing.Point(429, 67);
            this.lb_TitleTacGia.Name = "lb_TitleTacGia";
            this.lb_TitleTacGia.Size = new System.Drawing.Size(471, 69);
            this.lb_TitleTacGia.TabIndex = 0;
            this.lb_TitleTacGia.Text = "Thông tin tác giả";
            // 
            // grb_InfoTacGia
            // 
            this.grb_InfoTacGia.Controls.Add(this.dtp_NgaySinh);
            this.grb_InfoTacGia.Controls.Add(this.tb_Name);
            this.grb_InfoTacGia.Controls.Add(this.tb_ID);
            this.grb_InfoTacGia.Controls.Add(this.lb_NgaySinh);
            this.grb_InfoTacGia.Controls.Add(this.lb_TenTacGia);
            this.grb_InfoTacGia.Controls.Add(this.lb_ID);
            this.grb_InfoTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_InfoTacGia.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_InfoTacGia.Location = new System.Drawing.Point(12, 163);
            this.grb_InfoTacGia.Name = "grb_InfoTacGia";
            this.grb_InfoTacGia.Size = new System.Drawing.Size(472, 238);
            this.grb_InfoTacGia.TabIndex = 1;
            this.grb_InfoTacGia.TabStop = false;
            this.grb_InfoTacGia.Text = "Thông tin tác giả";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(18, 58);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(147, 36);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID tác giả:";
            // 
            // lb_TenTacGia
            // 
            this.lb_TenTacGia.AutoSize = true;
            this.lb_TenTacGia.Location = new System.Drawing.Point(18, 114);
            this.lb_TenTacGia.Name = "lb_TenTacGia";
            this.lb_TenTacGia.Size = new System.Drawing.Size(169, 36);
            this.lb_TenTacGia.TabIndex = 1;
            this.lb_TenTacGia.Text = "Tên tác giả:";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(18, 170);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(157, 36);
            this.lb_NgaySinh.TabIndex = 2;
            this.lb_NgaySinh.Text = "Ngày sinh:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(190, 58);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(247, 41);
            this.tb_ID.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(190, 111);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(247, 41);
            this.tb_Name.TabIndex = 4;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(190, 166);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(247, 41);
            this.dtp_NgaySinh.TabIndex = 5;
            // 
            // grb_TacGia
            // 
            this.grb_TacGia.Controls.Add(this.dgv_TacGia);
            this.grb_TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TacGia.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_TacGia.Location = new System.Drawing.Point(507, 163);
            this.grb_TacGia.Name = "grb_TacGia";
            this.grb_TacGia.Size = new System.Drawing.Size(839, 607);
            this.grb_TacGia.TabIndex = 2;
            this.grb_TacGia.TabStop = false;
            this.grb_TacGia.Text = "Bảng thông tin tác giả";
            // 
            // dgv_TacGia
            // 
            this.dgv_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TacGia.Location = new System.Drawing.Point(6, 40);
            this.dgv_TacGia.Name = "dgv_TacGia";
            this.dgv_TacGia.RowTemplate.Height = 28;
            this.dgv_TacGia.Size = new System.Drawing.Size(827, 561);
            this.dgv_TacGia.TabIndex = 0;
            // 
            // grb_Control
            // 
            this.grb_Control.Controls.Add(this.tb_IDDelete);
            this.grb_Control.Controls.Add(this.lb_IDDelete);
            this.grb_Control.Controls.Add(this.bunifuTileButton3);
            this.grb_Control.Controls.Add(this.btn_Back);
            this.grb_Control.Controls.Add(this.btn_Edit);
            this.grb_Control.Controls.Add(this.btn_Add);
            this.grb_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Control.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Control.Location = new System.Drawing.Point(12, 423);
            this.grb_Control.Name = "grb_Control";
            this.grb_Control.Size = new System.Drawing.Size(472, 347);
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
            this.btn_Add.Location = new System.Drawing.Point(24, 57);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 118);
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
            this.btn_Edit.Location = new System.Drawing.Point(169, 57);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(111, 118);
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
            this.btn_Back.Location = new System.Drawing.Point(324, 57);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(113, 118);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::QuanLyThuVien.Properties.Resources.icons8_cancel_40;
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Xóa";
            this.bunifuTileButton3.Location = new System.Drawing.Point(324, 209);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(105, 121);
            this.bunifuTileButton3.TabIndex = 3;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // lb_IDDelete
            // 
            this.lb_IDDelete.AutoSize = true;
            this.lb_IDDelete.Location = new System.Drawing.Point(18, 209);
            this.lb_IDDelete.Name = "lb_IDDelete";
            this.lb_IDDelete.Size = new System.Drawing.Size(244, 36);
            this.lb_IDDelete.TabIndex = 4;
            this.lb_IDDelete.Text = "Nhập ID cần xóa:";
            // 
            // tb_IDDelete
            // 
            this.tb_IDDelete.Location = new System.Drawing.Point(24, 268);
            this.tb_IDDelete.Name = "tb_IDDelete";
            this.tb_IDDelete.Size = new System.Drawing.Size(238, 41);
            this.tb_IDDelete.TabIndex = 5;
            // 
            // frmAddTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 782);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "frmAddTacGia";
            this.Text = "frmAddTacGia";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grb_InfoTacGia.ResumeLayout(false);
            this.grb_InfoTacGia.PerformLayout();
            this.grb_TacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).EndInit();
            this.grb_Control.ResumeLayout(false);
            this.grb_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox grb_TacGia;
        private System.Windows.Forms.GroupBox grb_InfoTacGia;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_TenTacGia;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_TitleTacGia;
        private System.Windows.Forms.GroupBox grb_Control;
        private System.Windows.Forms.TextBox tb_IDDelete;
        private System.Windows.Forms.Label lb_IDDelete;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private Bunifu.Framework.UI.BunifuTileButton btn_Edit;
        private Bunifu.Framework.UI.BunifuTileButton btn_Add;
        private System.Windows.Forms.DataGridView dgv_TacGia;
    }
}