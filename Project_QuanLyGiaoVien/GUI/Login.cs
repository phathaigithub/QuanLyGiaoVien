using QuanLyLichDay.DAO;
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
using QuanLyLichDay.GUI;
using System.Net.Mail;
using System.Net;
using QuanLyLichDay.DTO;

namespace QuanLyLichDay
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;


            if (username == "" || password == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống");
                return;
            }
            if (AccountDAO.Instance.checkLogin(username, password))
            {
                OTPAuthorizeForm authForm = new OTPAuthorizeForm(username);
                authForm.Show();
                authForm.generateOTP();
                authForm.FormClosed += (s, args) =>
                {
                    if (authForm.IsChecked)
                    {
                        authForm.Hide();
                        MainForm mainForm = new MainForm(AccountDAO.Instance.getAccountByUsername(username));
                        AccountDAO.Acc = AccountDAO.Instance.getAccountByUsername(username);
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận không thành công");
                    }
                };
                
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

        }

        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }
    }
}
