using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CartItem
    {
        public int MASANPHAM { get; set; }
        public int MACHITIETSANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public string HINHANH { get; set; }
        //public int imaSize { get; set; }
        //public string imauSac { get; set; }
        public int DONGIA { get; set; }
        public int SOLUONG { get; set; }
        public string MAVACH { get; set; }
        public string TENMAU { get; set; }
        public string TENSIZE { get; set; }
        public int THANHTIEN
        {
            get { return SOLUONG * DONGIA; }
        }
    }
}
