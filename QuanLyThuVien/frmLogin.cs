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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-UKUNBAP\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True");
            try
            {
                con.Open();
                string tk = tb_UserName.text;
                string pwd = tb_Pwd.Text;
                string sql = "Select *from USERS where UserName='" + tk + "' and Pwd='" + pwd + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain dlg2 = new frmMain();
                    dlg2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại, vui lòng đăng nhập lại.", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối.", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            frmInfoUser dlg2 = new frmInfoUser();
            dlg2.ShowDialog();
        }

        private void btn_SigninAdmin_Click(object sender, EventArgs e)
        {
            if (tb_UserName.text == "admin" && tb_Pwd.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain dlg2 = new frmMain();
                dlg2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng đăng nhập lại.", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_UserName_MouseClick(object sender, MouseEventArgs e)
        {
            tb_UserName.text = null;
        }

        private void tb_Pwd_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Pwd.Text = null;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }        
    }
}