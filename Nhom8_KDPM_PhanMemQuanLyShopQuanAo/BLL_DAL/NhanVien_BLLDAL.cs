using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NhanVien_BLLDAL
    {
        QLShopDataContext db = new QLShopDataContext();
        public NHANVIEN load_OnlyNhanVien(int maTaiKhoan)
        {
            try
            {
                return db.NHANVIENs.Single(nv => nv.MANHANVIEN == maTaiKhoan);
            }
            catch
            {
                return null;
            }
        }
        public bool ThemNhanVien(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Attach(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
