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
            if (tb_IDBook.Text == "") MessageBox.Show("Không được để trống ID sách.");
            else
            if (tb_NameBook.Text == "") MessageBox.Show("Không được để trống tên sách.");
            else
            if (cbb_TypeBook.Text == "") MessageBox.Show("Không được để trống thể loại sách");
            else
            if (cbb_Authors.Text == "") MessageBox.Show("Không được để trống tên tác giả.");
            else
            if (cbb_NamXB.Text == "") MessageBox.Show("Vui lòng chọn năm xuất bản.");
            else
            if (tb_NhaXB.Text == "") MessageBox.Show("Không được để trống nhà xuất bản.");
            else
            if (dtp_NgayNhap.Text == "") MessageBox.Show("Không được để trống ngày nhập.");
            else
            if (tb_TriGia.Text == "") MessageBox.Show("Không được để trống trị giá.");
            else
            if (cbb_TinhTrang.Text == "") MessageBox.Show("Không được để trống tình trạng.");
            else
            {
                string sqlINSERT = "INSERT INTO SACH VALUES (@IDSach, @TenSach, @TheLoai, @TacGia, @NamXB, @NhaXB, @NgNhap, @TriGia, @TinhTrang)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);

                cmd.Parameters.AddWithValue("IDSach", tb_IDBook.Text);
                cmd.Parameters.AddWithValue("TenSach", tb_NameBook.Text);
                cmd.Parameters.AddWithValue("TheLoai", cbb_TypeBook.Text);
                cmd.Parameters.AddWithValue("TacGia", cbb_Authors.Text);
                cmd.Parameters.AddWithValue("NamXB", cbb_NamXB.Text);
                cmd.Parameters.AddWithValue("NhaXB", tb_NhaXB.Text);
                cmd.Parameters.AddWithValue("NgNhap", dtp_NgayNhap.Text);
                cmd.Parameters.AddWithValue("TriGia", tb_TriGia.Text);
                cmd.Parameters.AddWithValue("TinhTrang", cbb_TinhTrang.Text);
                cmd.ExecuteNonQuery();
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
            frmDeleteBook dlg2 = new frmDeleteBook();
            dlg2.ShowDialog();
        }

        private void btn_EditBook_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE SACH SET IDSach=@IDSach, TenSach=@TenSach, TheLoai=@TheLoai, TacGia=@TacGia, NamXB=@NamXB, NhaXB=@NhaXB, NgNhap=@NgNhap, TriGia=@TriGia, TinhTrang=@TinhTrang)";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);

            cmd.Parameters.AddWithValue("IDSach", tb_IDBook.Text);
            cmd.Parameters.AddWithValue("TenSach", tb_NameBook.Text);
            cmd.Parameters.AddWithValue("TheLoai", cbb_TypeBook.Text);
            cmd.Parameters.AddWithValue("TacGia", cbb_Authors.Text);
            cmd.Parameters.AddWithValue("NamXB", cbb_NamXB.Text);
            cmd.Parameters.AddWithValue("NhaXB", tb_NhaXB.Text);
            cmd.Parameters.AddWithValue("NgNhap", dtp_NgayNhap.Text);
            cmd.Parameters.AddWithValue("TriGia", tb_TriGia.Text);
            cmd.Parameters.AddWithValue("TinhTrang", cbb_TinhTrang.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
