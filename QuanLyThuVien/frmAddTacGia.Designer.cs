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
            this.grb_Control = new System.Windows.Forms.GroupBox();
            this.tb_IDDel = new System.Windows.Forms.TextBox();
            this.lb_IDDelete = new System.Windows.Forms.Label();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuTileButton();
            this.grb_TacGia = new System.Windows.Forms.GroupBox();
            this.dgv_TacGia = new System.Windows.Forms.DataGridView();
            this.grb_InfoTacGia = new System.Windows.Forms.GroupBox();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_TenTacGia = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_TitleTacGia = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.grb_Control.SuspendLayout();
            this.grb_TacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).BeginInit();
            this.grb_InfoTacGia.SuspendLayout();
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
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(905, 487);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // grb_Control
            // 
            this.grb_Control.Controls.Add(this.tb_IDDel);
            this.grb_Control.Controls.Add(this.lb_IDDelete);
            this.grb_Control.Controls.Add(this.btn_Delete);
            this.grb_Control.Controls.Add(this.btn_Back);
            this.grb_Control.Controls.Add(this.btn_Edit);
            this.grb_Control.Controls.Add(this.btn_Add);
            this.grb_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Control.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Control.Location = new System.Drawing.Point(8, 275);
            this.grb_Control.Margin = new System.Windows.Forms.Padding(2);
            this.grb_Control.Name = "grb_Control";
            this.grb_Control.Padding = new System.Windows.Forms.Padding(2);
            this.grb_Control.Size = new System.Drawing.Size(315, 226);
            this.grb_Control.TabIndex = 3;
            this.grb_Control.TabStop = false;
            this.grb_Control.Text = "Điều khiển";
            // 
            // tb_IDDel
            // 
            this.tb_IDDel.Location = new System.Drawing.Point(16, 174);
            this.tb_IDDel.Margin = new System.Windows.Forms.Padding(2);
            this.tb_IDDel.Name = "tb_IDDel";
            this.tb_IDDel.Size = new System.Drawing.Size(160, 30);
            this.tb_IDDel.TabIndex = 5;
            // 
            // lb_IDDelete
            // 
            this.lb_IDDelete.AutoSize = true;
            this.lb_IDDelete.Location = new System.Drawing.Point(12, 136);
            this.lb_IDDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_IDDelete.Name = "lb_IDDelete";
            this.lb_IDDelete.Size = new System.Drawing.Size(163, 25);
            this.lb_IDDelete.TabIndex = 4;
            this.lb_IDDelete.Text = "Nhập ID cần xóa:";
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
            this.btn_Delete.Location = new System.Drawing.Point(216, 136);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(70, 79);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Back.Location = new System.Drawing.Point(216, 37);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 77);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            this.btn_Edit.Location = new System.Drawing.Point(113, 37);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(74, 77);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            this.btn_Add.Location = new System.Drawing.Point(16, 37);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(72, 77);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grb_TacGia
            // 
            this.grb_TacGia.Controls.Add(this.dgv_TacGia);
            this.grb_TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TacGia.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_TacGia.Location = new System.Drawing.Point(338, 106);
            this.grb_TacGia.Margin = new System.Windows.Forms.Padding(2);
            this.grb_TacGia.Name = "grb_TacGia";
            this.grb_TacGia.Padding = new System.Windows.Forms.Padding(2);
            this.grb_TacGia.Size = new System.Drawing.Size(559, 395);
            this.grb_TacGia.TabIndex = 2;
            this.grb_TacGia.TabStop = false;
            this.grb_TacGia.Text = "Bảng thông tin tác giả";
            // 
            // dgv_TacGia
            // 
            this.dgv_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TacGia.Location = new System.Drawing.Point(4, 26);
            this.dgv_TacGia.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_TacGia.Name = "dgv_TacGia";
            this.dgv_TacGia.RowTemplate.Height = 28;
            this.dgv_TacGia.Size = new System.Drawing.Size(551, 365);
            this.dgv_TacGia.TabIndex = 0;
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
            this.grb_InfoTacGia.Location = new System.Drawing.Point(8, 106);
            this.grb_InfoTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.grb_InfoTacGia.Name = "grb_InfoTacGia";
            this.grb_InfoTacGia.Padding = new System.Windows.Forms.Padding(2);
            this.grb_InfoTacGia.Size = new System.Drawing.Size(315, 155);
            this.grb_InfoTacGia.TabIndex = 1;
            this.grb_InfoTacGia.TabStop = false;
            this.grb_InfoTacGia.Text = "Thông tin tác giả";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(127, 108);
            this.dtp_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(166, 30);
            this.dtp_NgaySinh.TabIndex = 5;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(127, 72);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(166, 30);
            this.tb_Name.TabIndex = 4;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(127, 38);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(166, 30);
            this.tb_ID.TabIndex = 3;
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(12, 110);
            this.lb_NgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(105, 25);
            this.lb_NgaySinh.TabIndex = 2;
            this.lb_NgaySinh.Text = "Ngày sinh:";
            // 
            // lb_TenTacGia
            // 
            this.lb_TenTacGia.AutoSize = true;
            this.lb_TenTacGia.Location = new System.Drawing.Point(12, 74);
            this.lb_TenTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenTacGia.Name = "lb_TenTacGia";
            this.lb_TenTacGia.Size = new System.Drawing.Size(115, 25);
            this.lb_TenTacGia.TabIndex = 1;
            this.lb_TenTacGia.Text = "Tên tác giả:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(12, 38);
            this.lb_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(99, 25);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID tác giả:";
            // 
            // lb_TitleTacGia
            // 
            this.lb_TitleTacGia.AutoSize = true;
            this.lb_TitleTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TitleTacGia.Location = new System.Drawing.Point(286, 44);
            this.lb_TitleTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TitleTacGia.Name = "lb_TitleTacGia";
            this.lb_TitleTacGia.Size = new System.Drawing.Size(315, 46);
            this.lb_TitleTacGia.TabIndex = 0;
            this.lb_TitleTacGia.Text = "Thông tin tác giả";
            // 
            // frmAddTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 487);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddTacGia";
            this.Text = "frmAddTacGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddTacGia_FormClosing);
            this.Load += new System.EventHandler(this.frmAddTacGia_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.grb_Control.ResumeLayout(false);
            this.grb_Control.PerformLayout();
            this.grb_TacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).EndInit();
            this.grb_InfoTacGia.ResumeLayout(false);
            this.grb_InfoTacGia.PerformLayout();
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
        private System.Windows.Forms.TextBox tb_IDDel;
        private System.Windows.Forms.Label lb_IDDelete;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
        private Bunifu.Framework.UI.BunifuTileButton btn_Edit;
        private Bunifu.Framework.UI.BunifuTileButton btn_Add;
        private System.Windows.Forms.DataGridView dgv_TacGia;
    }
}