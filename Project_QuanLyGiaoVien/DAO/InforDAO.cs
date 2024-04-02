using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_DBManager.DAO;
using QuanLyLichDay.DTO;
using QuanLyLichDay.GUI;

namespace QuanLyLichDay.DAO
{
    public class InforDAO
    {

        public static InforDAO instance;

        public static InforDAO Instance
        {
            get => instance == null ? instance = new InforDAO() : instance;
            set => instance = value;
        }

        private InforDAO() { }




    }


}
