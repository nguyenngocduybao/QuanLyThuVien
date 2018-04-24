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
    public partial class frmAddTacGia : Form
    {
        public frmAddTacGia()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void frmAddTacGia_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
            HienThi();
        }

        private void frmAddTacGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        public void HienThi()
        {
            string sqlSelect = "SELECT * FROM TACGIA";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_TacGia.DataSource = dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "") MessageBox.Show("Không được để trống ID tác giả.", "Chú ý");
            else
                    if (tb_Name.Text == "") MessageBox.Show("Không được để trống tên tác giả.", "Chú ý");
            else
                    if (dtp_NgaySinh.Text == "") MessageBox.Show("Không được để trống ngày sinh", "Chú ý");
            else
            {
                string sqlInsert = "INSERT INTO TACGIA VALUES (@IDTacGia, @TenTacGia, @NgaySinh)";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);

                cmd.Parameters.AddWithValue("IDTacGia", tb_ID.Text);
                cmd.Parameters.AddWithValue("TenTacGia", tb_Name.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtp_NgaySinh.Text);
                
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Chú ý");
                }
                catch (Exception ex)
                {
                    string str = ex.Message;
                    str = str.Substring(67);
                    MessageBox.Show(str, "Chú ý");
                }
                HienThi();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "") MessageBox.Show("Không được để trống ID tác giả.", "Chú ý");
            else
                    if (tb_Name.Text == "") MessageBox.Show("Không được để trống tên tác giả.", "Chú ý");
            else
                    if (dtp_NgaySinh.Text == "") MessageBox.Show("Không được để trống ngày sinh", "Chú ý");
            else
            {
                string sqlEdit = "UPDATE TACGIA SET TenTacGia = @TenTacGia, NgaySinh = @NgaySinh WHERE IDTacGia = @IDTacGia";
                SqlCommand cmd = new SqlCommand(sqlEdit, con);

                cmd.Parameters.AddWithValue("IDTacGia", tb_ID.Text);
                cmd.Parameters.AddWithValue("TenTacGia", tb_Name.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtp_NgaySinh.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Chú ý");
                }
                catch (Exception ex)
                {
                    string str = ex.Message;
                    str = str.Substring(67);
                    MessageBox.Show(str, "Chú ý");
                }
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM TACGIA WHERE IDTacGia = @IDTacGia";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);

            cmd.Parameters.AddWithValue("IDTacGia", tb_IDDel.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công", "Chú ý");
            HienThi();
        }

        
    }
}
