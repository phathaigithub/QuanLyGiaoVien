using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLichDay.DTO
{
    public class Class
    {
        private string className;
        private DateTime day;
        private int shift;

        public string ClassName { get => className; set => className = value; }
        public DateTime Day { get => day; set => day = value; }
        public int Shift { get => shift; set => shift = value; }
        public Class(DataRow row)
        {

        }
    }
}
