using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class CartItem
    {
        public int iMaSanPham { get; set; }
        public string iTenSanPham { get; set; }
        //public int imaSize { get; set; }
        //public string imauSac { get; set; }
        public int iDonGia { get; set; }
        public string iHinhAnh { get; set; }
        public int iSoLuong { get; set; }
        public int thanhTien
        {
            get { return iSoLuong * iDonGia; }
        }
        //tạo giỏ hàng
        QLSHOPDataContext db = new QLSHOPDataContext();
        public CartItem()
        {
            this.iMaSanPham = 0;
        }
        public CartItem(int maSP)
        {
            SANPHAM sp = db.SANPHAMs.Single(n => n.MASANPHAM == maSP);

            if (sp != null)
            {
                iMaSanPham = maSP;
                iTenSanPham = sp.TENSANPHAM;
                // imaSize = sp.SIZE.MASIZE;
                // imauSac = sp.MAUSAC;
                iDonGia = int.Parse(sp.DONGIA.ToString());
                iHinhAnh = sp.HINHANH;
                iSoLuong = 1;
            }

        }
    }
}
