using QuanLyLichDay.DAO;
using QuanLyLichDay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        public void collapseUserControl()
        {
            ucXemLichDay1.Hide();
            ucTinhTienLuong1.Hide();
            ucThongKeBaoCao1.Hide();
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
    }
}
