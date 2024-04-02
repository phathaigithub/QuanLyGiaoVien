using QuanLyLichDay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichDay
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string username = tb_TenDangNhap.Text;
            string password = tb_MatKhau.Text;
            string email = tb_Email.Text;
            

            if (username == "" || password == "" || email == "")
            {
                MessageBox.Show("Email hoặc mật khẩu hoặc tên đăng nhập không được để trống");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email phải có ký tự @");
                return;
            }
            if(AccountDAO.Instance.isExistUsernameAndEmail(username, email))
            {
                MessageBox.Show("Tên đăng nhập hoặc email đã tồn tại");
                return;
            }
            if (AccountDAO.Instance.regAccount(username, password, email)){
                MessageBox.Show("Đăng ký thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }

        private void tb_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_DangKy.PerformClick();
            }
        }
    }
}
