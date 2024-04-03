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
    public partial class ucThongTin : UserControl
    {
        Account account;

        
        public Account Account { get => account; set => account = value; }
        public ucThongTin()
        {
            InitializeComponent();
            pn_CapNhat.Hide();
            btnCapNhat.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void loadInformation(string username)
        {
            DataRow userInfo = AccountDAO.Instance.getUserInfoByUsername(username);
            if (userInfo.IsNull("Name")) { userInfo.SetField("Name", "Không có"); }
            if (userInfo.IsNull("Gender")) { userInfo.SetField("Gender", "Không có"); }
            if (userInfo.IsNull("Birth")) { userInfo.SetField("Birth", DateTime.MinValue); }
            if (userInfo.IsNull("CCCD")) { userInfo.SetField("CCCD", DataEncoder.Instance.encodeBase64("Không có")); }
            if (userInfo.IsNull("PhoneNum")) { userInfo.SetField("PhoneNum", DataEncoder.Instance.encodeBase64("Không có")); }
            if (userInfo.IsNull("Address")) { userInfo.SetField("Address", DataEncoder.Instance.encodeBase64("Không có")); }
            lb_TenGV.Text = userInfo["Name"].ToString();
            lb_GioiTinh.Text = userInfo["Gender"].ToString();
            lb_NgaySinh.Text = Convert.ToDateTime(userInfo["Birth"]).ToString("dd-MM-yyyy");
            lb_CCCD.Text = DataEncoder.Instance.decodeBase64(userInfo["CCCD"].ToString());
            lb_SDT.Text = DataEncoder.Instance.decodeBase64(userInfo["PhoneNum"].ToString());
            lb_DiaChi.Text = DataEncoder.Instance.decodeBase64(userInfo["Address"].ToString());
            tb_TenGV.Text = userInfo["Name"].ToString();
            switch (userInfo["Gender"].ToString())
            {
                case "Nam": rbtn_Nam.Checked = true; break;
                case "Nữ": rbtn_Nu.Checked = true; break;
            }
            dtpk_Ngaysinh.Value = Convert.ToDateTime(userInfo["Birth"]);
            tb_CCCD.Text = DataEncoder.Instance.decodeBase64(userInfo["CCCD"].ToString());
            tb_SDT.Text = DataEncoder.Instance.decodeBase64(userInfo["PhoneNum"].ToString());
            tb_DiaChi.Text = DataEncoder.Instance.decodeBase64(userInfo["Address"].ToString());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnCapNhat.Show();
            pn_CapNhat.Show();
        }

        private void ucThongTin_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = tb_TenGV.Text;
            string cccd = tb_CCCD.Text;
            string sdt = tb_SDT.Text;
            string diaChi = tb_DiaChi.Text;
            string gioiTinh = "Nam";
            if (rbtn_Nam.Checked)
                gioiTinh = "Nam";
            if (rbtn_Nu.Checked)
                gioiTinh = "Nữ";
            string ngaySinh = dtpk_Ngaysinh.Value.ToString("MM-dd-yyyy");
            if(hoTen == "" || cccd == "" || sdt == "" || diaChi == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            bool isUpdate = AccountDAO.Instance.insertUserInfoByUsername(account.Username, hoTen, cccd, sdt, diaChi, gioiTinh, ngaySinh);
            if (isUpdate)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            loadInformation(account.Username);
            pn_CapNhat.Hide();
            btnCapNhat.Hide();
            
        }
    }
}
