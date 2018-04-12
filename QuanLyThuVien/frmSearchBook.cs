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
    public partial class frmSearchBook : Form
    {
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
            HienThi();
        }
        SqlConnection con;
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM SACH";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_SearchBook.DataSource = dt;
        }

        private void frmSearchBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
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
        private DataTable timkiemtheoTinhTrang(string TinhTrang)
        {
            string chuoikn = "select * from SACH where TinhTrang=@TinhTrang";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);
            return sach;
        }
        private DataTable timkiemtheoIDSach(string IDBook)
        {
            string chuoikn = "select * from SACH where IDSach=@IDSach";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDSach",IDBook);
            return sach;
        }
        private DataTable timkiemtheoTenSach(string NameBook)
        {
            string chuoikn = "select * from SACH where TenSach=@TenSach";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenSach", NameBook);
            return sach;
        }
        private DataTable timkiemtheoTheLoai(string TheLoai)
        {
            string chuoikn = "SELECT * FROM SACH WHERE TheLoai=@TheLoai";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TheLoai", TheLoai);
            return sach;
        }
        private DataTable timkiemtheoTacGia(string TacGia)
        {
            string chuoikn = "select * from SACH where TacGia=@TacGia";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TacGia", TacGia);
            return sach;
        }
        private DataTable timkiemtheoNamXB(string YXB)
        {
            string chuoikn = "select * from SACH where NamXB=@NamXB";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NamXB", YXB);
            return sach;
        }
        private DataTable timkiemtheoNhaXB(string NXB)
        {
            string chuoikn = "select * from SACH where NhaXB=@NhaXB";
            SqlCommand cmd = new SqlCommand(chuoikn, con);
            DataTable sach = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhaXB", NXB);
            return sach;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_IDBook.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoIDSach(tb_IDBook.Text);
            }
            if (tb_NameBook.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoTenSach(tb_NameBook.Text);
            }
            if (tb_NXB.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoNhaXB(tb_NXB.Text);
            }
            if (cbb_TacGia.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoTacGia(cbb_TacGia.Text);
            }
            if (cbb_TheLoai.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoTheLoai(cbb_TheLoai.Text);
            }
            if (cbb_TinhTrang.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoTinhTrang(cbb_TinhTrang.Text);
            }
            if (cbb_YXB.Text != null)
            {
                dgv_SearchBook.DataSource = timkiemtheoNamXB(cbb_YXB.Text);
            }
            if (tb_IDBook.Text == "" && tb_NameBook.Text == "" && tb_NXB.Text == "" && cbb_TacGia.Text == "" && cbb_TheLoai.Text == "" && cbb_TinhTrang.Text == "" && cbb_YXB.Text == "")
            {
                DialogResult kq;
                kq = MessageBox.Show("Bạn chưa nhập giá trị để tìm kiếm.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void tab_SearchBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tab_SearchBook.SelectedIndex)
            {
                case 0:
                    {
                        tb_NameBook.Text = null;
                        cbb_TacGia.Text = null;
                        cbb_TheLoai.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = null;
                        break;
                    }
                case 1:
                    {
                        tb_IDBook.Text = null;
                        cbb_TacGia.Text = null;
                        cbb_TheLoai.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = null;
                        break;
                    }
                case 2:
                    {
                        tb_NameBook.Text = null;
                        cbb_TacGia.Text = null;
                        tb_IDBook.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = null;
                        break;
                    }
                case 3:
                    {
                        tb_NameBook.Text = null;
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = null;
                        break;
                }
                case 4:
                    {
                        tb_NameBook.Text = null;
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_TacGia.Text = null;
                        tb_NXB.Text = null;
                        break;
                    }
                case 5:
                    {
                        tb_NameBook.Text = null;
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_TacGia.Text = null;
                        cbb_YXB.Text = null;
                        break;
                    }
                case 6:
                    {
                        tb_NameBook.Text = null;
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = null;
                        cbb_YXB.Text = null;
                        cbb_TacGia.Text = null;
                        tb_NXB.Text = null;
                        break;
                    }
            }
        }
    }
}
