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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyLichDay.GUI
{
    public partial class ucThongKeBaoCao : UserControl
    {
        Account account;
        public Account Account { get => account; set => account = value; }

        public ucThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void ucThongKeBaoCao_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            c_Salary.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string month = cb.SelectedItem as string;
            string numMonth = month.Split(' ')[1];
            double totalShift = ClassDAO.Instance.totalShiftInMonth(account.Id, "01-02-2024", "30-04-2024");
            MessageBox.Show(totalShift + "");
        }

        private void lb_From_Click(object sender, EventArgs e)
        {

        }

        private void lb_To_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime fromDate = dtpk_From.Value;
            DateTime toDate = dtpk_To.Value;
            int rank = AccountDAO.Instance.getRank(account.Username, account.Email);
            double totalShift = ClassDAO.Instance.totalShiftInMonth(account.Id, fromDate.ToString(), toDate.ToString());
            double totalShiftTime = totalShift * 2.5;
            double totalSalary = getSalaryBasedOnRank(rank) * totalShiftTime;
            string formatedTotalSalary = string.Format("{0:N}", totalSalary);

            tb_TongCaDay.Text = totalShift.ToString();
            tb_TongGioDay.Text = totalShiftTime.ToString();
            tb_TongThuNhap.Text = formatedTotalSalary;
        }

        private void tb_TongGioDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TongThuNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_BaoCaoThongKe_Click(object sender, EventArgs e)
        {

        }

        private void c_Salary_Click(object sender, EventArgs e)
        {

        }

        private void thongKe()
        {
            c_Salary.Show();
            c_Salary.ChartAreas[0].AxisX.Title = "Ngày";
            c_Salary.ChartAreas[0].AxisY.Title = "Lương (VNĐ)";
            c_Salary.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            c_Salary.ChartAreas[0].AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            c_Salary.Series["Lương"].Points.Clear();
            DateTime fromDate = dtpk_From.Value;
            DateTime toDate = dtpk_To.Value;
            List<Class> list = ClassDAO.Instance.getClasses(account.Id);
            int rank = AccountDAO.Instance.getRank(account.Username, account.Email);
            int daDay = 0;
            int chuaDay = 0;
            int vang = 0;
            int totalShift = ClassDAO.Instance.totalShiftInMonth(account.Id, fromDate.ToString(), toDate.ToString());

            foreach (Class c in list)
            {
                if (c.Day >= fromDate && c.Day <= toDate)
                {
                    if ((c.Status).Equals("Đã dạy"))
                    {
                        int totalShiftInDay = ClassDAO.Instance.totalShiftInDay(c.Day.ToString());
                        daDay += 1;
                        double totalSalryInDay = totalShiftInDay * getSalaryBasedOnRank(rank);
                        string formatedTotalSalaryInDay = string.Format("{0:N}", totalSalryInDay);
                        c_Salary.Series["Lương"].Points.AddXY(c.Day.ToString("dd/MM/yyyy"), formatedTotalSalaryInDay);
                    }
                    else if ((c.Status).Equals("Chưa dạy"))
                    {
                        int totalShiftInDay = ClassDAO.Instance.totalShiftInDay(c.Day.ToString());
                        chuaDay += 1;
                    }
                }
            }

            //Hiển thị thông tin ra màn hình
            double totalShiftTime = daDay * 2.5;
            double totalSalary = getSalaryBasedOnRank(rank) * totalShiftTime;
            string formatedTotalSalary = string.Format("{0:N}", totalSalary);
            vang = totalShift - (daDay + chuaDay);
            tb_TongCaDay.Text = totalShift.ToString();
            tb_DaDay.Text = daDay.ToString();
            tb_ChuaDay.Text = chuaDay.ToString();
            tb_Vang.Text = vang.ToString();
            tb_TongGioDay.Text = totalShiftTime.ToString();
            tb_TongThuNhap.Text = formatedTotalSalary;

            //Lưu thông tin vào datagridview
            DataTable dt = new DataTable();
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Từ ngày");
            dt.Columns.Add("Đến ngày");
            dt.Columns.Add("Tổng số ca");
            dt.Columns.Add("Đã dạy");
            dt.Columns.Add("Chưa dạy");
            dt.Columns.Add("Báo vắng");
            dt.Columns.Add("Tổng giờ dạy");
            dt.Columns.Add("Lương");
            string name = AccountDAO.Instance.getNameByUserId(account.Id);
            dt.Rows.Add(name, fromDate.ToString("dd/MM/yyyy"), toDate.ToString("dd/MM/yyyy"), totalShift, daDay, chuaDay, vang, totalShiftTime, formatedTotalSalary + " VNĐ");
            dataGridView1.DataSource = dt;
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            thongKe();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Tong_Click(object sender, EventArgs e)
        {

        }

        private void exportToExcel()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    MExcel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        MExcel.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MExcel.Columns.Font.Size = 12;
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XuatDuKieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xuất dữ liệu thành file Excel?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                thongKe();
                exportToExcel();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_BaoCao_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
