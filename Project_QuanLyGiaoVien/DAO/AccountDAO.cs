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

namespace QuanLyLichDay.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get => instance == null ? new AccountDAO() : instance;
            set => instance = value;
        }

        private AccountDAO() { }

        public bool checkLogin(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password});

            return result.Rows.Count > 0;
        }
        public string getEmailByUsername(string username)
        {
            string query = "SELECT User_Email FROM Users Where Username = @Username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result.Rows[0]["User_Email"].ToString(); 
        }
        
        
    }
}
