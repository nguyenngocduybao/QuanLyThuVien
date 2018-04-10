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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmMain dlg2 = new frmMain();
            dlg2.ShowDialog();
        }
    }
}
