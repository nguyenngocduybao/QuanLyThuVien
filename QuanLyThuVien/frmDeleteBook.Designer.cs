namespace QuanLyThuVien
{
    partial class frmDeleteBook
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
            this.lb_Delete = new System.Windows.Forms.Label();
            this.tb_DeleteBook = new System.Windows.Forms.TextBox();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Delete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Delete.Location = new System.Drawing.Point(198, 70);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(317, 36);
            this.lb_Delete.TabIndex = 0;
            this.lb_Delete.Text = "Nhập mã sách cần xóa";
            // 
            // tb_DeleteBook
            // 
            this.tb_DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DeleteBook.Location = new System.Drawing.Point(229, 123);
            this.tb_DeleteBook.Name = "tb_DeleteBook";
            this.tb_DeleteBook.Size = new System.Drawing.Size(260, 41);
            this.tb_DeleteBook.TabIndex = 1;
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteBook.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_DeleteBook.Location = new System.Drawing.Point(204, 194);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(110, 44);
            this.btn_DeleteBook.TabIndex = 2;
            this.btn_DeleteBook.Text = "Xóa";
            this.btn_DeleteBook.UseVisualStyleBackColor = true;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Back.Location = new System.Drawing.Point(400, 194);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(115, 44);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Trở về";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // frmDeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 275);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_DeleteBook);
            this.Controls.Add(this.tb_DeleteBook);
            this.Controls.Add(this.lb_Delete);
            this.Name = "frmDeleteBook";
            this.Text = "frmDeleteBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDeleteBook_FormClosing);
            this.Load += new System.EventHandler(this.frmDeleteBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Delete;
        private System.Windows.Forms.TextBox tb_DeleteBook;
        private System.Windows.Forms.Button btn_DeleteBook;
        private System.Windows.Forms.Button btn_Back;
    }
}