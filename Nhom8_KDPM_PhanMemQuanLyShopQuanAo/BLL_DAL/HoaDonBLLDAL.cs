using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class HoaDonBLLDAL
    {
        QLShopDataContext dbContext = new QLShopDataContext();
        public IQueryable<HOADON> load_listHD()
        {
            return dbContext.HOADONs.Select(hd => hd);
        }
        public HOADON loadHD_Last()
        {
            return dbContext.HOADONs.ToList().Last();
        }
        public bool TaoHoaDon(HOADON hd)
        {
            try
            {
                dbContext.HOADONs.InsertOnSubmit(hd);
                dbContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public IQueryable<View_HoaDon> load_listHD()
        //{
        //    return dbContext.View_HoaDons.Select(hd => hd);
        //}
        public HOADON getMaHDMoi()
        {
            return dbContext.HOADONs.OrderByDescending(hd => hd.MAHOADON).First();
        }
    }
}
