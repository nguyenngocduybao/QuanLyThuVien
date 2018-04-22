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
        //Tạo kết nối với cơ sở dữ liệu
        public SqlConnection cn = new SqlConnection();
        public void Ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        //Phương thức truy vấn để xem dữ liệu
        public DataTable HienDL(string sql)
        {
            Ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            Ngatketnoi();
        }

        //Phương thức truy vấn dữ liệu: Insert, Update, Delete
        public SqlCommand ThucThiDl(string sql)
        {
            Ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            Ngatketnoi();
        }


        public frmSearchBook()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM SACH";
            SqlCommand cmd = new SqlCommand(sqlSELECT, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_SearchBook.DataSource = dt;
        }
        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            cn.Open();
            HienThi();
        }

        private void frmSearchBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (rd_IDSach.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where IDSach like '%" + tb_Search.Text.Trim() + "%' ");
            }
            if (rd_TenSach.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TenSach like N'%" + tb_Search.Text.Trim() + "%' ");
            }
            if (rd_NXB.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where NhaXB like N'%" + tb_Search.Text.Trim() + "%' ");
            }
            if (rd_TacGia.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TacGia like N'%" + tb_Search.Text.Trim() + "%' ");
            }
            if (rd_TheLoai.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TheLoai like N'%" + tb_Search.Text.Trim() + "%' ");
            }
            if (rd_TinhTrang.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TinhTranglike N'%" + tb_Search.Text.Trim() + "%' ");
            }
            if (rd_YXB.Checked==true)
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where NamXB like '%" + tb_Search.Text.Trim() + "%' ");
            }

        }
        private void btn_HienDL_Click(object sender, EventArgs e)
        {
            HienThi();
        }


    }
}
