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
    public partial class CaDay : UserControl
    {
        Account account;
        string className;
        DateTime day;
        int shift;
        string status; // Status có 3 giá trị (Đã dạy, Chưa dạy, Vắng)

        public CaDay(Class lopHoc, Account account)
        {
            InitializeComponent();
            this.account = account;
            this.className = lopHoc.ClassName;
            this.shift = lopHoc.Shift;
            this.day = lopHoc.Day;
            this.status = lopHoc.Status;
            lb_ClassName.Text = className;
            switch (status)
            {
                case "Chưa dạy":
                    {
                        this.ForeColor = Color.Black;
                        this.BackColor = Color.LightGray;
                        cb_Status.SelectedIndex = 0;
                        break;
                    }
                case "Đã dạy":
                    {
                        this.BackColor = Color.Green;
                        this.lb_ClassName.ForeColor = Color.White;
                        cb_Status.SelectedIndex = 1;
                        break;
                    }
                case "Vắng":
                    {
                        this.BackColor = Color.Red;
                        this.lb_ClassName.ForeColor = Color.White;
                        cb_Status.SelectedIndex = 2;
                        break;
                    }
            }
        }
        public void formatEmpty()
        {
            lb_ClassName.Text = "[Trống]";
            this.BackColor = Color.White;
            this.cb_Status.Enabled = false;
            this.cb_Status.SelectedIndex = -1;
            btn_Xoa.Visible = false;
            btn_Them.Visible = true;
        }
        private void formatAdd()
        {
            lb_ClassName.Text = tb_ClassName.Text;
            tb_ClassName.Visible = false;
            btn_Them.Visible = false;
            btn_Xoa.Visible = true;
            this.cb_Status.Enabled = true;
            cb_Status.SelectedIndex = 0;
        }
        public CaDay(DateTime day, int shift, Account account)
        {

            InitializeComponent();
            this.account = account;
            this.day = day;
            this.shift = shift;
            formatEmpty();
        }

        private void lb_ClassName_Click(object sender, EventArgs e)
        {
        }

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_Status.SelectedIndex)
            {
                case 0:
                    {
                        this.ForeColor = Color.Black;
                        this.BackColor = Color.LightGray;
                        this.status = "Chưa dạy";
                        break;
                    }
                case 1:
                    {
                        this.BackColor = Color.Green;
                        this.lb_ClassName.ForeColor = Color.White;
                        this.status = "Đã dạy";
                        break;
                    }
                case 2:
                    {
                        this.BackColor = Color.Red;
                        this.lb_ClassName.ForeColor = Color.White;
                        this.status = "Vắng";
                        break;
                    }
            }
        }

        private void cb_Status_SelectionChangeCommitted(object sender, EventArgs e)
        {

            CaDayDAO.Instance.updateStatusCaDay(className, status, shift, day, account.Username);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(status != "Chưa dạy")
            {
                MessageBox.Show("Chỉ có thể xoá những ca chưa dạy");
            }
            else
            {
                if (CaDayDAO.Instance.deleteCaDay(className, shift, day, account.Username))
                    formatEmpty();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(DateTime.Now.AddHours(23 - DateTime.Now.Hour) >= day)
            {
                MessageBox.Show("Chỉ được thêm ca dạy từ ngày sau trở đi");
                return;
            }
            tb_ClassName.Visible = true;
            tb_ClassName.Focus(); 
        }
        

        private void tb_ClassName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == Keys.Enter)
            {
                if(CaDayDAO.Instance.insertCaDay(tb_ClassName.Text, shift, day, account.Username))
                {
                    this.className = tb_ClassName.Text;
                    this.status = "Chưa dạy";
                    formatAdd();
                }
            }
        }
    }
}
