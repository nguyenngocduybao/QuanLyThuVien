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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void frmUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
            HienThi();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM THEDOCGIA";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_User.DataSource = dt;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "") MessageBox.Show("Không được để trống ID độc giả.");
                else
                    if (tb_Name.Text == "") MessageBox.Show("Không được để trống tên độc giả.");
                else
                    if (dtp_BirthDay.Text == "") MessageBox.Show("Không được để trống ngày sinh");
                else
                    if (tb_Email.Text == "") MessageBox.Show("Không được để trống email.");
                else
                    if (tb_Email.Text != tb_Email.Text + "@gmail.com" || tb_Email.Text != tb_Email.Text + "@yahoo.com") MessageBox.Show("Không đúng định dạng email.");
                else
                    if (cbb_TypeReader.Text == "") MessageBox.Show("Vui lòng chọn loại độc giả.");
                else
                    if (dtp_NgayLapThe.Text == "") MessageBox.Show("Không được để trống ngày lập thẻ.");
                else
            {
                string sqlINSERT = "INSERT INTO THEDOCGIA VALUES (@IDDocGia, @HoTenDG, @NgSinhDG, @Diachi, @EmailDG, @LoaiDG, @NgLapThe, NULL, NULL)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);

                cmd.Parameters.AddWithValue("IDDocGia", tb_ID.Text);
                cmd.Parameters.AddWithValue("HoTenDG", tb_Name.Text);
                cmd.Parameters.AddWithValue("NgSinhDG", dtp_BirthDay.Text);
                cmd.Parameters.AddWithValue("EmailDG", tb_Email.Text);
                cmd.Parameters.AddWithValue("LoaiDG", cbb_TypeReader.Text);
                cmd.Parameters.AddWithValue("DiaChi", tb_Address.Text);
                cmd.Parameters.AddWithValue("NgLapThe", dtp_NgayLapThe.Text);
                cmd.ExecuteNonQuery();
                HienThi();
            }
            
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frmMain dlg2 = new frmMain();
            dlg2.ShowDialog();
        }    
    }
}
