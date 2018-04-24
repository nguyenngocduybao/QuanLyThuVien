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
    public partial class frmSignupUser : Form
    {
        public frmSignupUser()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "") MessageBox.Show("Không được để trống ID độc giả.", "Chú ý");
            else
            if (tb_UserName.Text == "") MessageBox.Show("Không được để trống tài khoản.", "Chú ý");
            else
            if (tb_Pwd.Text == "") MessageBox.Show("Không được để trống mật khẩu.", "Chú ý");
            else
            {
                string sqlINSERT = "INSERT INTO USERS VALUES (@UserName,@IDDocGia,@Pwd)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);

                cmd.Parameters.AddWithValue("IDDocGia", "DG" + tb_ID.Text);
                cmd.Parameters.AddWithValue("UserName", tb_UserName.Text);
                cmd.Parameters.AddWithValue("Pwd", tb_Pwd.Text);
                cmd.ExecuteNonQuery();
                DialogResult kq;
                kq = MessageBox.Show("Bạn đã chắc chắn thông tin trên là chính xác?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    DialogResult changeform;
                    changeform = MessageBox.Show("Bạn đã đăng kí thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (changeform == DialogResult.OK)
                    {
                        frmLogin dlg2 = new frmLogin();
                        dlg2.ShowDialog();
                        this.Close();
                    }
                        
                }
            }
        }

        private void frmSignupUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            con.Open();
        }

        private void frmSignupUser_FormClosing(object sender, FormClosingEventArgs e)
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
