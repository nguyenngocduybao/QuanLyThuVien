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
            if (tb_IDBook.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where IDSach like '%" + tb_IDBook.Text.Trim() + "%' ");
            }
            if (tb_NameBook.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TenSach like N'%" + tb_NameBook.Text.Trim() + "%' ");
            }
            if (tb_NXB.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where NhaXB like N'%" + tb_NXB.Text.Trim() + "%' ");
            }
            if (cbb_TacGia.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TacGia like N'%" + cbb_TacGia.Text.Trim() + "%' ");
            }
            if (cbb_TheLoai.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TheLoai like N'%" + cbb_TheLoai.Text.Trim() + "%' ");
            }
            if (cbb_TinhTrang.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where TinhTranglike N'%" + cbb_TinhTrang.Text.Trim() + "%' ");
            }
            if (cbb_YXB.Text != "")
            {
                dgv_SearchBook.DataSource = HienDL("select * from SACH where NamXB like '%" + cbb_YXB.Text.Trim() + "%' ");
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
                        tb_NameBook.Text = "";
                        cbb_TacGia.Text = null;
                        cbb_TheLoai.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = "";
                        break;
                    }
                case 1:
                    {
                        tb_IDBook.Text = "";
                        cbb_TacGia.Text = null;
                        cbb_TheLoai.Text = null;
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = "";
                        break;
                    }
                case 2:
                    {
                        tb_NameBook.Text = "";
                        cbb_TacGia.Text = null;
                        tb_IDBook.Text = "";
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = "";
                        break;
                    }
                case 3:
                    {
                        tb_NameBook.Text = "";
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = "";
                        cbb_TinhTrang.Text = null;
                        cbb_YXB.Text = null;
                        tb_NXB.Text = "";
                        break;
                }
                case 4:
                    {
                        tb_NameBook.Text = "";
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = "";
                        cbb_TinhTrang.Text = null;
                        cbb_TacGia.Text = null;
                        tb_NXB.Text = "";
                        break;
                    }
                case 5:
                    {
                        tb_NameBook.Text = "";
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = "";
                        cbb_TinhTrang.Text = null;
                        cbb_TacGia.Text = null;
                        cbb_YXB.Text = null;
                        break;
                    }
                case 6:
                    {
                        tb_NameBook.Text = "";
                        cbb_TheLoai.Text = null;
                        tb_IDBook.Text = "";
                        cbb_YXB.Text = null;
                        cbb_TacGia.Text = null;
                        tb_NXB.Text = "";
                        break;
                    }
            }
        }

        private void btn_HienDL_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void tb_IDBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
