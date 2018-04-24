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
            string sqlSelect = "SELECT * FROM THEDOCGIA";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_User.DataSource = dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý");
            else
                    if (tb_Name.Text == "") MessageBox.Show("Không được để trống tên độc giả.", "Chú ý");
            else
                    if (dtp_BirthDay.Text == "") MessageBox.Show("Không được để trống ngày sinh", "Chú ý");
            else
                    if (tb_Email.Text == "") MessageBox.Show("Không được để trống email.", "Chú ý");
            else
                    if (tb_Email.Text.Length < 11 || (tb_Email.Text.Substring(tb_Email.Text.Length - 10) != "@gmail.com" && tb_Email.Text.Substring(tb_Email.Text.Length - 10) != "@yahoo.com")) MessageBox.Show("Không đúng định dạng email.", "Chú ý");
            else
                    if (cbb_TypeReader.Text == "") MessageBox.Show("Vui lòng chọn loại độc giả.", "Chú ý");
            else
                    if (dtp_NgayLapThe.Text == "") MessageBox.Show("Không được để trống ngày lập thẻ.", "Chú ý");
            else
            {
                string sqlInsert = "INSERT INTO THEDOCGIA VALUES (@IDDocGia, @HoTenDG, @NgSinhDG, @DiachiDG, @EmailDG, @IDLoaiDG, @NgLapThe, NULL, NULL)";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);

                cmd.Parameters.AddWithValue("IDDocGia", "DG" + tb_ID.Text);
                cmd.Parameters.AddWithValue("HoTenDG", tb_Name.Text);
                cmd.Parameters.AddWithValue("NgSinhDG", dtp_BirthDay.Text);
                cmd.Parameters.AddWithValue("EmailDG", tb_Email.Text);
                cmd.Parameters.AddWithValue("IDLoaiDG", cbb_TypeReader.Text);
                cmd.Parameters.AddWithValue("DiaChiDG", tb_Address.Text);
                cmd.Parameters.AddWithValue("NgLapThe", dtp_NgayLapThe.Text);
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
            string sqlDeleteUser = "DELETE FROM USERS WHERE IDDocGia = @IDDocGia";
            string sqlDeleteDocGia = "DELETE FROM THEDOCGIA WHERE IDDocGia = @IDDocGia";
            SqlCommand cmd1 = new SqlCommand(sqlDeleteUser, con);
            SqlCommand cmd2 = new SqlCommand(sqlDeleteDocGia, con);

            cmd1.Parameters.AddWithValue("IDDocGia", "DG" + tb_IDDel.Text);
            cmd2.Parameters.AddWithValue("IDDocGia", "DG" + tb_IDDel.Text);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Xoá thành công", "Chú ý");
            HienThi();
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý");
            else
                    if (tb_Name.Text == "") MessageBox.Show("Không được để trống tên độc giả.", "Chú ý");
            else
                    if (dtp_BirthDay.Text == "") MessageBox.Show("Không được để trống ngày sinh", "Chú ý");
            else
                    if (tb_Email.Text == "") MessageBox.Show("Không được để trống email.", "Chú ý");
            else
                    if (tb_Email.Text.Length < 11 || (tb_Email.Text.Substring(tb_Email.Text.Length - 10) != "@gmail.com" && tb_Email.Text.Substring(tb_Email.Text.Length - 10) != "@yahoo.com")) MessageBox.Show("Không đúng định dạng email.", "Chú ý");
            else
                    if (cbb_TypeReader.Text == "") MessageBox.Show("Vui lòng chọn loại độc giả.", "Chú ý");
            else
                    if (dtp_NgayLapThe.Text == "") MessageBox.Show("Không được để trống ngày lập thẻ.", "Chú ý");
            else
            {
                string sqlEdit = "UPDATE THEDOCGIA SET HoTenDG = @HoTenDG, NgSinhDG = @NgSinhDG, DiaChiDG = @DiachiDG, EmailDG = @EmailDG, IDLoaiDG = @IDLoaiDG, NgLapThe = @NgLapThe WHERE IDDocGia = @IDDocGia";
                SqlCommand cmd = new SqlCommand(sqlEdit, con);

                cmd.Parameters.AddWithValue("IDDocGia", "DG" + tb_ID.Text);
                cmd.Parameters.AddWithValue("HoTenDG", tb_Name.Text);
                cmd.Parameters.AddWithValue("NgSinhDG", dtp_BirthDay.Text);
                cmd.Parameters.AddWithValue("EmailDG", tb_Email.Text);
                cmd.Parameters.AddWithValue("IDLoaiDG", cbb_TypeReader.Text);
                cmd.Parameters.AddWithValue("DiaChiDG", tb_Address.Text);
                cmd.Parameters.AddWithValue("NgLapThe", dtp_NgayLapThe.Text);
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

        private void tb_IDDel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
