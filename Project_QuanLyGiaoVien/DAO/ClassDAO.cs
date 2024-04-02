﻿using Project_DBManager.DAO;
using QuanLyLichDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyLichDay.DAO
{
    public class ClassDAO
    {
        private static ClassDAO instance;

        public static ClassDAO Instance { get => instance == null ? new ClassDAO() : instance; set => instance = value; }
        public List<Class> getClassesByWeekAndUsername(string username, DateTime day)
        {
            string monday = DateDAO.Instance.firstDayOfWeek(day).ToString("yyyy-MM-dd");
            string sunday= DateDAO.Instance.lastDayOfWeek(day).ToString("yyyy-MM-dd");
            string query = "SELECT Class_Name, Shift_ID, FORMAT(DayOfClass, 'yyyy-MM-dd') as Day, Status " +
                "FROM Users U, (SELECT * from Class Where DayOfClass >= @Monday AND DayOfClass <= @Sunday ) as Class " +
                "WHERE U.User_ID = Class.User_ID and U.Username = @Username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { monday, sunday, username});
            List<Class> classes = new List<Class>();
            foreach(DataRow row in result.Rows)
            {
                classes.Add(new Class(row));
            }
            return classes;
        }

        public double getNumOfShift(string username)
        {
            string query = "SELECT COUNT(Shift_ID) AS 'COUNT' FROM Users U, Class WHERE U.User_ID = Class.User_ID " +
                "and U.Username = @Username and Class.Status = N'Đã dạy' and MONTH(GETDATE()) = MONTH(DayOfClass) " +
                "and YEAR(GETDATE()) = YEAR(DayOfClass)";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            if(result != null)
            {
                double numOfShift = Convert.ToDouble(result.Rows[0]["COUNT"].ToString());
                return numOfShift;
            }
            return 0;
        }

        public int totalShiftInMonth(int userid, string fromDate, string toDate)
        {
            string query = "SET DATEFORMAT DMY SELECT COUNT(*) FROM Class WHERE User_ID = @userid AND DayOfClass >= @fromDate AND DayOfClass <= @toDate";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userid, fromDate, toDate});
            if (result != null)
            {
                int totalShift = Convert.ToInt32(result.Rows[0][0].ToString());
                return totalShift;
            }
            return 0;
        }

        public List<Class> getClasses(int userid)
        {
            string query = "SELECT Class_Name, Shift_ID, FORMAT(DayOfClass, 'yyyy-MM-dd') as Day, Status FROM Class WHERE User_ID = @User_ID";
            List<Class> classes = new List<Class>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { userid });
            foreach (DataRow row in table.Rows)
            {
                classes.Add(new Class(row));
            }
            return classes;
        }

        public int totalShiftInDay(string day)
        {
            string query = "SET DATEFORMAT DMY SELECT COUNT(*) FROM Class WHERE DayOfClass = @day";
            DataTable table = DataProvider.Instance.ExecuteQuery (query, new object[] { day });
            if (table != null)
            {
                int totalShift = Convert.ToInt32(table.Rows[0][0].ToString());
                return totalShift;
            }
            return 0;
        }
    }
}
