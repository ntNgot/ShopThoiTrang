﻿using System;
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

        DateTime day = new DateTime();


        #region Thống kê
        public IQueryable thongKeSpTheoThang(int pThang, int pNam)
        {
            var ans = from sp in dbContext.CHITIETSANPHAMs
                      join cthd in dbContext.CHITIETHOADONs on sp.MACHITIETSP equals cthd.MACHITIETSP
                      join hd in dbContext.HOADONs on cthd.MAHOADON equals hd.MAHOADON
                      join spp in dbContext.SANPHAMs on sp.MASANPHAM equals spp.MASANPHAM
                      where Convert.ToInt32(hd.NGAYTAO.Value.Month.ToString()) == pThang && Convert.ToInt32(hd.NGAYTAO.Value.Year.ToString()) == pNam
                      select new
                      {
                          spp.TENSANPHAM,
                          cthd.SOLUONG
                      };
            return ans;
        }

        public IQueryable thongKeHoaDonTheoThang(int pThang, int pNam)
        {
            var ans = from sp in dbContext.CHITIETSANPHAMs
                      join cthd in dbContext.CHITIETHOADONs on sp.MACHITIETSP equals cthd.MACHITIETSP
                      join hd in dbContext.HOADONs on cthd.MAHOADON equals hd.MAHOADON
                      where Convert.ToInt32(hd.NGAYTAO.Value.Month.ToString()) == pThang && Convert.ToInt32(hd.NGAYTAO.Value.Year.ToString()) == pNam
                      join kh in dbContext.KHACHHANGs on hd.MAKHACHHANG equals kh.MAKHACHHANG
                      select new
                      {
                          hd.MAHOADON,
                          kh.TENKHACHHANG,
                          hd.NGAYTAO,
                          hd.THANHTIEN
                      };
            return ans;
        }
        #endregion
    }
}
