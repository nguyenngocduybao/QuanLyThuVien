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
    public partial class frmInfoUser : Form
    {
        public frmInfoUser()
        {
            InitializeComponent();
        }

        SqlConnection con;

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
                string sqlINSERT = "INSERT INTO THEDOCGIA VALUES (@IDDocGia, @HoTenDG, @NgSinhDG, @DiachiDG, @EmailDG, @LoaiDG, @NgLapThe, NULL, NULL)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);

                cmd.Parameters.AddWithValue("IDDocGia", tb_ID.Text);
                cmd.Parameters.AddWithValue("HoTenDG", tb_Name.Text);
                cmd.Parameters.AddWithValue("NgSinhDG", dtp_BirthDay.Text);
                cmd.Parameters.AddWithValue("EmailDG", tb_Email.Text);
                cmd.Parameters.AddWithValue("LoaiDG", cbb_TypeReader.Text);
                cmd.Parameters.AddWithValue("DiaChiDG", tb_Address.Text);
                cmd.Parameters.AddWithValue("NgLapThe", dtp_NgayLapThe.Text);
                try
                {
                    cmd.ExecuteNonQuery();                    
                }
                catch (Exception ex)
                {
                    string str = ex.Message;
                    str = str.Substring(67);
                    MessageBox.Show(str, "Chú ý");
                }
            }
            DialogResult kq;
            kq = MessageBox.Show("Bạn đã chắc chắn thông tin trên là chính xác?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                frmSignupUser dlg2 = new frmSignupUser();
                dlg2.ShowDialog();
            }
        }

        private void frmInfoUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
        }

        private void frmInfoUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
