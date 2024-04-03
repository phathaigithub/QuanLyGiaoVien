using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyLichDay.DAO;

namespace QuanLyLichDay
{
    public partial class OTPAuthorizeForm : Form
    {
        bool isChecked = false;
        string username;
        int OTP;
        public OTPAuthorizeForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public void generateOTP()
        {
            try
            {
                lb_YourOTP.Text = "Mã OTP đã được gửi qua Email:";
                lb_YourOTP.ForeColor = Color.Green;
                Random rd = new Random();
                OTP = rd.Next(100000, 1000000);
                string mailSender = "dbmanagerteam@gmail.com";
                string fromPassword = "xvlsxthynqyrdvut";
                string mailReceiver = AccountDAO.Instance.getEmailByUsername(username);
                lb_Email.Text = "Email: " + mailReceiver;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mailSender);
                message.Subject = "OTP Verify";
                message.To.Add(new MailAddress(mailReceiver));
                message.Body = "<html><body>Your OTP is: " + OTP + " </body></html>";
                message.IsBodyHtml = true;

                var stmpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(mailSender, fromPassword),
                    EnableSsl = true,
                };

                stmpClient.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_KiemTraOTP_Click(object sender, EventArgs e)
        {
            if(int.Parse(tb_OTP.Text) == OTP)
            {
                isChecked = true;
                this.Close();
            }
            else
            {
                lb_YourOTP.Text = "Mã OTP không hợp lệ";
                lb_YourOTP.ForeColor = Color.Red;
            }
        }

        private void btn_GuiLaiOTP_Click(object sender, EventArgs e)
        {
            generateOTP();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OTPAuthorizeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tb_OTP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_KiemTraOTP.PerformClick();
            }
        }
    }
}
