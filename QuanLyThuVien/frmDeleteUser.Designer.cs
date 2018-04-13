namespace QuanLyThuVien
{
    partial class frmDeleteUser
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.tb_DeleteUser = new System.Windows.Forms.TextBox();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Back.Location = new System.Drawing.Point(374, 193);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(115, 44);
            this.btn_Back.TabIndex = 7;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_DeleteUser.Location = new System.Drawing.Point(178, 193);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(110, 44);
            this.btn_DeleteUser.TabIndex = 6;
            this.btn_DeleteUser.Text = "Xóa";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // tb_DeleteUser
            // 
            this.tb_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DeleteUser.Location = new System.Drawing.Point(203, 122);
            this.tb_DeleteUser.Name = "tb_DeleteUser";
            this.tb_DeleteUser.Size = new System.Drawing.Size(260, 41);
            this.tb_DeleteUser.TabIndex = 5;
            this.tb_DeleteUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_DeleteUser_KeyPress);
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Delete.Location = new System.Drawing.Point(172, 69);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(351, 36);
            this.lb_Delete.TabIndex = 4;
            this.lb_Delete.Text = "Nhập mã độc giả cần xóa";
            // 
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 307);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.tb_DeleteUser);
            this.Controls.Add(this.lb_Delete);
            this.Name = "frmDeleteUser";
            this.Text = "frmDeleteUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeleteUser_FormClosing);
            this.Load += new System.EventHandler(this.frmDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.TextBox tb_DeleteUser;
        private System.Windows.Forms.Label lb_Delete;
    }
}