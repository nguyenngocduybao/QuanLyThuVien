using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmDeleteBook : Form
    {
        public frmDeleteBook()
        {
            InitializeComponent();
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM SACH WHERE IDSach="+tb_DeleteBook.Text.Trim()+"";
                SqlCommand cmd = new SqlCommand(sqlDelete, con);
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
        SqlConnection con;

        private void frmDeleteBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
        }

        private void frmDeleteBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();

        }

        private void tb_DeleteBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
