using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDay.DTO
{
    public class Account
    {
        private string username;
        private string email;
        private int id;
        public Account()
        {
            this.username = null;
            this.email = null;
        }
        public Account(DataRow row)
        {
            username = row["Username"].ToString();
            email = row["User_Email"].ToString();
            id = int.Parse(row["User_ID"].ToString());
        }
        public Account(Account account)
        {
            this.username = account.Username;
            this.email = account.Email;
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }
    }
}
