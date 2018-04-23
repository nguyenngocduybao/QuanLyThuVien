using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        SqlConnection con;
                
        private void frmAddBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
            HienThi();
        }

        private void frmAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM SACH";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_AddBook.DataSource = dt;
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (tb_IDDauSach.Text == "")
                MessageBox.Show("Vui lòng nhập ID đầu sách.");
            else
                if (tb_TenSach.Text == "") MessageBox.Show("Vui lòng nhập tên sách.");
            else
                if (cb_LoaiSach.Text == "") MessageBox.Show("Vui lòng không để trống loại sách.");
            else
                if (tb_IDSach.Text == "") MessageBox.Show("Vui lòng nhập ID sách.");
            else
                if (tb_NhaXuatBan.Text == "") MessageBox.Show("Vui lòng nhập nhà xuất bản.");
            else
                if (dtp_NXB.Text == "") MessageBox.Show("Vui lòng không để trống năm xuất bản.");
            else
                if (tb_SoLuongTon.Text == "") MessageBox.Show("Vui lòng nhập số lượng tồn.");
            else
                if (tb_GiaTien.Text == "") MessageBox.Show("Vui lòng nhập giá tiền.");
            else
            {
                string sqlInsertDauSach = "INSERT INTO TACGIA VALUES (@IDDauSach, @TenDauSach, @IDLoaiSach)";
                SqlCommand cmdDauSach = new SqlCommand(sqlInsertDauSach, con);
                cmdDauSach.Parameters.AddWithValue("IDDauSach", tb_IDDauSach.Text);
                cmdDauSach.Parameters.AddWithValue("TenDauSach", tb_TenSach.Text);
                cmdDauSach.Parameters.AddWithValue("IDLoaiSach", cb_LoaiSach.Text);
                string sqlInsertSach = "INSERT INTO TACGIA VALUES (@IDSach, @IDDauSach, @NhaXB, @NamXB, @SoLuongTon, @GiaTien)";
                SqlCommand cmdSach = new SqlCommand(sqlInsertSach, con);
                cmdSach.Parameters.AddWithValue("IDDauSach", tb_IDDauSach.Text);
                cmdSach.Parameters.AddWithValue("IDSach", tb_IDSach.Text);
                cmdSach.Parameters.AddWithValue("NhaXB", tb_NhaXuatBan.Text);
                cmdSach.Parameters.AddWithValue("NamXB", dtp_NXB.Text);
                cmdSach.Parameters.AddWithValue("SoLuongTon", tb_SoLuongTon.Text);
                cmdSach.Parameters.AddWithValue("GiaTien", tb_GiaTien.Text);
                HienThi();
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

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditBook_Click(object sender, EventArgs e)
        {

        }

        private void tb_TriGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_IDBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_IDDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
