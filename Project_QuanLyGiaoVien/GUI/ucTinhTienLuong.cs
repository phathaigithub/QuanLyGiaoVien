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

namespace QuanLyLichDay
{
    public partial class ucTinhTienLuong : UserControl
    {
        Account account;

        public Account Account { get => account; set => account = value; }
        public ucTinhTienLuong()
        {
            InitializeComponent();
        }

        private double getSalaryBasedOnRank(int rank)
        {
            if (rank == 1) return 60000;
            if (rank == 2) return 67000;
            if (rank == 3) return 74000;
            if (rank == 4) return 81000;
            if (rank == 5) return 88000;
            if (rank == 6) return 95000;
            if (rank == 7) return 103000;
            if (rank == 8) return 111000;
            if (rank == 9) return 119000;
            return 0;
        }

        private void btTinhLuongMD_Click(object sender, EventArgs e)
        {
            double soGioDay = ClassDAO.Instance.getNumOfShift(account.Username) * 2.5;
            int rank = AccountDAO.Instance.getRank(account.Username, account.Email);

            double luong = getSalaryBasedOnRank(rank) * soGioDay;
            string format = string.Format("{0:N}", luong);
            labelHienTienLuongMD.Text = format + " VNĐ";
        }

        private void btTinhLuongTC_Click(object sender, EventArgs e)
        {
            double soGioDay;
            if (tbSoCaDay.Text == null)
            {
                soGioDay = ClassDAO.Instance.getNumOfShift(account.Username) * 2.5;
            } 
            else
            {
                soGioDay = Convert.ToDouble(tbSoCaDay.Text.ToString()) * 2.5;
            }

            int rank = 1;

            if (cbBacLuong.SelectedItem.ToString() == "Bậc 1") rank = 1;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 2") rank = 2;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 3") rank = 3;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 4") rank = 4;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 5") rank = 5;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 6") rank = 6;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 7") rank = 7;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 8") rank = 8;
            else if (cbBacLuong.SelectedItem.ToString() == "Bậc 9") rank = 9;


            double luong = getSalaryBasedOnRank(rank) * soGioDay;
            string format = string.Format("{0:N}", luong); // 1.000.000.00
            labelHienTienLuongTC.Text = format + " VNĐ";
        }

        private void panelTinhLuongMacDinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbSoCaDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBacLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucTinhTienLuong_Load(object sender, EventArgs e)
        {

        }
    }
}
