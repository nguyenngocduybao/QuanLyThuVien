namespace QuanLyThuVien
{
    partial class frmUser
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
            this.lb_Info = new System.Windows.Forms.Label();
            this.grb_Info = new System.Windows.Forms.GroupBox();
            this.cbb_TypeReader = new System.Windows.Forms.ComboBox();
            this.dtp_NgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.dtp_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_NgayLapThe = new System.Windows.Forms.Label();
            this.lb_TypeReader = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_BirthDay = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.grb_Data = new System.Windows.Forms.GroupBox();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.grb_Control = new System.Windows.Forms.GroupBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Fix = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grb_Info.SuspendLayout();
            this.grb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.grb_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Info
            // 
            this.lb_Info.AutoSize = true;
            this.lb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info.ForeColor = System.Drawing.Color.Blue;
            this.lb_Info.Location = new System.Drawing.Point(549, 38);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(487, 69);
            this.lb_Info.TabIndex = 0;
            this.lb_Info.Text = "Thông tin độc giả";
            // 
            // grb_Info
            // 
            this.grb_Info.Controls.Add(this.cbb_TypeReader);
            this.grb_Info.Controls.Add(this.dtp_NgayLapThe);
            this.grb_Info.Controls.Add(this.dtp_BirthDay);
            this.grb_Info.Controls.Add(this.tb_Address);
            this.grb_Info.Controls.Add(this.tb_Email);
            this.grb_Info.Controls.Add(this.tb_Name);
            this.grb_Info.Controls.Add(this.tb_ID);
            this.grb_Info.Controls.Add(this.lb_Address);
            this.grb_Info.Controls.Add(this.lb_NgayLapThe);
            this.grb_Info.Controls.Add(this.lb_TypeReader);
            this.grb_Info.Controls.Add(this.lb_Email);
            this.grb_Info.Controls.Add(this.lb_BirthDay);
            this.grb_Info.Controls.Add(this.lb_Name);
            this.grb_Info.Controls.Add(this.lb_ID);
            this.grb_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Info.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Info.Location = new System.Drawing.Point(74, 146);
            this.grb_Info.Name = "grb_Info";
            this.grb_Info.Size = new System.Drawing.Size(692, 766);
            this.grb_Info.TabIndex = 1;
            this.grb_Info.TabStop = false;
            this.grb_Info.Text = "Nhập thông tin độc giả";
            // 
            // cbb_TypeReader
            // 
            this.cbb_TypeReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TypeReader.FormattingEnabled = true;
            this.cbb_TypeReader.Items.AddRange(new object[] {
            "Thường",
            "VIP"});
            this.cbb_TypeReader.Location = new System.Drawing.Point(266, 500);
            this.cbb_TypeReader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_TypeReader.Name = "cbb_TypeReader";
            this.cbb_TypeReader.Size = new System.Drawing.Size(396, 44);
            this.cbb_TypeReader.TabIndex = 13;
            // 
            // dtp_NgayLapThe
            // 
            this.dtp_NgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLapThe.Location = new System.Drawing.Point(266, 600);
            this.dtp_NgayLapThe.Name = "dtp_NgayLapThe";
            this.dtp_NgayLapThe.Size = new System.Drawing.Size(396, 41);
            this.dtp_NgayLapThe.TabIndex = 12;
            // 
            // dtp_BirthDay
            // 
            this.dtp_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BirthDay.Location = new System.Drawing.Point(266, 300);
            this.dtp_BirthDay.Name = "dtp_BirthDay";
            this.dtp_BirthDay.Size = new System.Drawing.Size(396, 41);
            this.dtp_BirthDay.TabIndex = 11;
            this.dtp_BirthDay.TabStop = false;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(266, 700);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(396, 41);
            this.tb_Address.TabIndex = 10;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(266, 400);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(396, 41);
            this.tb_Email.TabIndex = 9;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(266, 200);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(396, 41);
            this.tb_Name.TabIndex = 8;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(266, 100);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(396, 41);
            this.tb_ID.TabIndex = 7;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(32, 700);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(122, 36);
            this.lb_Address.TabIndex = 6;
            this.lb_Address.Text = "Địa chỉ:";
            // 
            // lb_NgayLapThe
            // 
            this.lb_NgayLapThe.AutoSize = true;
            this.lb_NgayLapThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayLapThe.Location = new System.Drawing.Point(32, 600);
            this.lb_NgayLapThe.Name = "lb_NgayLapThe";
            this.lb_NgayLapThe.Size = new System.Drawing.Size(203, 36);
            this.lb_NgayLapThe.TabIndex = 5;
            this.lb_NgayLapThe.Text = "Ngày lập thẻ:";
            // 
            // lb_TypeReader
            // 
            this.lb_TypeReader.AutoSize = true;
            this.lb_TypeReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TypeReader.Location = new System.Drawing.Point(32, 500);
            this.lb_TypeReader.Name = "lb_TypeReader";
            this.lb_TypeReader.Size = new System.Drawing.Size(198, 36);
            this.lb_TypeReader.TabIndex = 4;
            this.lb_TypeReader.Text = "Loại độc giả:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(32, 400);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(102, 36);
            this.lb_Email.TabIndex = 3;
            this.lb_Email.Text = "Email:";
            // 
            // lb_BirthDay
            // 
            this.lb_BirthDay.AutoSize = true;
            this.lb_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BirthDay.Location = new System.Drawing.Point(32, 300);
            this.lb_BirthDay.Name = "lb_BirthDay";
            this.lb_BirthDay.Size = new System.Drawing.Size(167, 36);
            this.lb_BirthDay.TabIndex = 2;
            this.lb_BirthDay.Text = "Ngày sinh:";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(32, 200);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(159, 36);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Họ và tên:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(32, 100);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(55, 36);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID:";
            // 
            // grb_Data
            // 
            this.grb_Data.Controls.Add(this.dgv_User);
            this.grb_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Data.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Data.Location = new System.Drawing.Point(819, 146);
            this.grb_Data.Name = "grb_Data";
            this.grb_Data.Size = new System.Drawing.Size(966, 766);
            this.grb_Data.TabIndex = 2;
            this.grb_Data.TabStop = false;
            this.grb_Data.Text = "Bảng thông tin độc giả";
            // 
            // dgv_User
            // 
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(28, 42);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.RowTemplate.Height = 28;
            this.dgv_User.Size = new System.Drawing.Size(789, 705);
            this.dgv_User.TabIndex = 0;
            // 
            // grb_Control
            // 
            this.grb_Control.Controls.Add(this.btn_Back);
            this.grb_Control.Controls.Add(this.btn_Delete);
            this.grb_Control.Controls.Add(this.btn_Fix);
            this.grb_Control.Controls.Add(this.btn_Add);
            this.grb_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Control.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grb_Control.Location = new System.Drawing.Point(412, 937);
            this.grb_Control.Name = "grb_Control";
            this.grb_Control.Size = new System.Drawing.Size(1088, 105);
            this.grb_Control.TabIndex = 3;
            this.grb_Control.TabStop = false;
            this.grb_Control.Text = "Xử lí";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(850, 40);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(153, 52);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(600, 40);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(153, 52);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Fix
            // 
            this.btn_Fix.Location = new System.Drawing.Point(350, 40);
            this.btn_Fix.Name = "btn_Fix";
            this.btn_Fix.Size = new System.Drawing.Size(153, 52);
            this.btn_Fix.TabIndex = 1;
            this.btn_Fix.Text = "Sửa";
            this.btn_Fix.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(100, 40);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(153, 52);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1653, 1089);
            this.Controls.Add(this.grb_Control);
            this.Controls.Add(this.grb_Data);
            this.Controls.Add(this.grb_Info);
            this.Controls.Add(this.lb_Info);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.grb_Info.ResumeLayout(false);
            this.grb_Info.PerformLayout();
            this.grb_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.grb_Control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Info;
        private System.Windows.Forms.GroupBox grb_Info;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_NgayLapThe;
        private System.Windows.Forms.Label lb_TypeReader;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_BirthDay;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapThe;
        private System.Windows.Forms.DateTimePicker dtp_BirthDay;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.GroupBox grb_Data;
        private System.Windows.Forms.GroupBox grb_Control;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Fix;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.ComboBox cbb_TypeReader;
    }
}