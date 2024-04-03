using QuanLyLichDay.DAO;
using QuanLyLichDay.DTO;
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
using static System.Net.WebRequestMethods;

namespace QuanLyLichDay.GUI
{
    public partial class MainForm : Form
    {
        private Account account;
        public MainForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            loadUcXemLichDay();
            loadUcTinhTienLuong();
            loadUcBaoCaoThongKe();
            loadUcThongTin();
            collapseUserControl();
            ucThongTin1.Show();
            sendNotiMail();
        }
        public void sendNotiMail()
        {
            List<Class> list = ClassDAO.Instance.getClassesByDayAndUsername(account.Username, DateTime.Today.AddDays(1));
            if (list.Count == 0)
                return;
            string classListText = "";
            foreach (Class c in list)
            {
                classListText += "Lớp: " + c.ClassName + " | Ca: " + c.Shift + "<br>";
            }
            try
            {
                Random rd = new Random();
                string mailSender = "dbmanagerteam@gmail.com";
                string fromPassword = "xvlsxthynqyrdvut";
                string mailReceiver = account.Email;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mailSender);
                message.Subject = "Thông báo ca học";
                message.To.Add(new MailAddress(mailReceiver));
                message.Body = string.Format("<html><body>Bạn có các da dạy vào ngày mai ({0}): <br>{1}</body></html>",DateTime.Today.AddDays(1).ToString("dd/MM"), classListText);
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
        public void collapseUserControl()
        {
            ucXemLichDay1.Hide();
            ucTinhTienLuong1.Hide();
            ucThongKeBaoCao1.Hide();
            ucThongTin1.Hide();
        }
        private void loadUcThongTin()
        {
            ucThongTin1.Account = this.account;
            ucThongTin1.loadInformation(ucThongTin1.Account.Username);
        }
        private void loadUcXemLichDay()
        {
            ucXemLichDay1.Account = account;
            ucXemLichDay1.loadWeek(ucXemLichDay1.CurrentWeek);
            ucXemLichDay1.Hide();
        }
        private void loadUcTinhTienLuong()
        {
            ucTinhTienLuong1.Account = account;
            ucTinhTienLuong1.Hide();
        }

        private void loadUcBaoCaoThongKe()
        {
            ucThongKeBaoCao1.Account = account;
            ucThongKeBaoCao1.Hide();
        }

        private void ucXemLichDay1_Load(object sender, EventArgs e)
        {

        }

        private void tínhToánTiềnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucTinhTienLuong1.Show();   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucThongKeBaoCao1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void ucThongKeBaoCao1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucXemLichDay1.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            collapseUserControl();
            ucThongTin1.Show();
        }
    }
}
