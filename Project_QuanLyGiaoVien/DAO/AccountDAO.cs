using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using QuanLyLichDay.GUI;
using Project_DBManager.DAO;
using Microsoft.Identity.Client;
using QuanLyLichDay.DTO;
using System.Windows.Forms;

namespace QuanLyLichDay.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private static Account acc;
        
        public static AccountDAO Instance
        {
            get => instance == null ? new AccountDAO() : instance;
            set => instance = value;
        }
        public static Account Acc { get => acc; set => acc = value; }

        private AccountDAO() { }
        public bool isExistUsernameAndEmail(string username, string email)
        {
            string query = string.Format("SELECT* FROM Users WHERE Username = '{0}' or User_Email = '{1}'", username, email);
            return DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0;

        }
        public bool regAccount(string username, string password, string email)
        {
            password = DataEncoder.Instance.stringHash(password);
            string queryUser = string.Format("INSERT INTO Users (Username, Password, User_Email) VALUES ('{0}', '{1}', '{2}')", username, password, email);
            string queryUserInfo = "INSERT INTO User_Info(User_ID) VALUES ((SELECT User_ID FROM Users WHERE Username = @Username ))";
            bool insertUser = DataProvider.Instance.ExecuteNonQuery(queryUser) > 0;
            bool insertUserInfo = DataProvider.Instance.ExecuteNonQuery(queryUserInfo, new object[] {username}) > 0;
            return insertUser && insertUserInfo;
        }

        public bool checkLogin(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] {username});
            if(table.Rows.Count == 0)
            {
                return false;
            }
            DataRow row = table.Rows[0];
            string hashedPassword = row["Password"].ToString();

            return DataEncoder.Instance.isHashTo(password, hashedPassword);
        }
        public Account getAccountByUsername(string username)
        {
            string query = "SELECT * FROM Users as U WHERE U.Username = @Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            if (data.Rows.Count != 0)
                return new Account(data.Rows[0]);
            return null;
        }
        public string getEmailByUsername(string username)
        {
            string query = "SELECT User_Email FROM Users Where Username = @Username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result.Rows[0]["User_Email"].ToString(); 
        }
        public int getRank(string username, string email)
        {
            string query = "SELECT Rank FROM User_Info UI, Users WHERE Users.Username = @Username AND Users.User_ID = UI.User_ID " +
                "AND Users.User_Email = @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, email });
            int rank = Convert.ToInt32(result.Rows[0]["Rank"].ToString());
            return rank;
        }

        public string getNameByUserId(int userid)
        {
            string query = "SELECT Name FROM User_Info WHERE User_ID = @User_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { userid });
            if (dt != null)
            {
                string name = dt.Rows[0][0].ToString();
                return name;
            }
            return null;
        }
        public DataRow getUserInfoByUsername(string username)
        {
            string query = "SELECT * From User_Info WHERE User_ID = (SELECT User_ID FROM Users WHERE Username = @Username )";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return table.Rows[0];
        }
        public bool insertUserInfoByUsername(string username, string hoTen, string cccd, string sdt, string diaChi, string gioiTinh, string ngaySinh)
        {
            cccd = DataEncoder.Instance.encodeBase64(cccd);
            sdt = DataEncoder.Instance.encodeBase64(sdt);
            diaChi = DataEncoder.Instance.encodeBase64(diaChi);
            string query = string.Format("UPDATE User_Info SET Name = N'{1}', Birth = '{6}', Gender = N'{5}', Address = N'{4}', CCCD = '{2}', PhoneNum = '{3}' WHERE User_ID = (SELECT User_ID From Users WHERE Username = '{0}')", username, hoTen, cccd, sdt, diaChi, gioiTinh, ngaySinh);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
