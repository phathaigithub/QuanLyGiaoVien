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

namespace QuanLyLichDay
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        int gmailOTP;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string matkhau = txtMatKhau.Text;
            string otp = txtOTP.Text;
            
            if (email == "" || matkhau == "")
            {
                MessageBox.Show("Email hoặc mật khẩu không được để trống");
                return;
            }
            if (DangNhap(email, matkhau) )
            {
                if (VerifyEmail(otp))
                {
                    fHomePage fHomePage = new fHomePage();
                    fDangNhap fDangNhap = new fDangNhap();
                    fDangNhap.Hide();
                    fHomePage.Show();
                }
                else
                {
                    MessageBox.Show("Otp không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
            
        }
        private bool VerifyEmail(string otp)
        {
            if (gmailOTP.ToString().Equals(otp))
            {
                return true;
            }
            return false;
        }
        private bool DangNhap(string email, string matkhau)
        {
            return AccountDAO.Instance.Login(email, matkhau);
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

        private void btnGetOTP_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            gmailOTP = rd.Next(100000, 1000000);
            string mailSender = "dbmanagerteam@gmail.com";
            string fromPassword = "xvlsxthynqyrdvut";
            string mailReceiver = txtEmail.Text;
            MailMessage message = new MailMessage();
            message.From = new MailAddress(mailSender);
            message.Subject = "OTP Verify";
            message.To.Add(new MailAddress(mailReceiver));
            message.Body = "<html><body>" + gmailOTP + " </body></html>";
            message.IsBodyHtml = true;

            var stmpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(mailSender, fromPassword),
                EnableSsl = true,
            };

            stmpClient.Send(message);

            MessageBox.Show("OTP đã được gửi qua email");
        }
        
    }
}
