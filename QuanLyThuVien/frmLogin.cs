using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btn_Signin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            frmInfoUser dlg2 = new frmInfoUser();
            dlg2.ShowDialog();
        }

        private void btn_SigninAdmin_Click(object sender, EventArgs e)
        {
            frmMain dlg2 = new frmMain();
            dlg2.ShowDialog();
        }


        private void tb_Password_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Password.text = null;
            tb_UserName.text = null;
        }
    }
}
