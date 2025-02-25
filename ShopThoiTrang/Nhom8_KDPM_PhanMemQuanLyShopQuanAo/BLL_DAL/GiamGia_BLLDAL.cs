﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class GiamGia_BLLDAL
    {
        QLShopDataContext dbContext = new QLShopDataContext();
        public List<GIAMGIA> layDSGG()
        {
            return dbContext.GIAMGIAs.ToList();
        }
        public GIAMGIA layGG(int maGG)
        {
            return dbContext.GIAMGIAs.FirstOrDefault(s => s.MAGIAMGIA == maGG);
        }
        public void themGG(GIAMGIA g)
        {
            dbContext.GIAMGIAs.InsertOnSubmit(g);
            dbContext.SubmitChanges();
        }
        public void suaGG(GIAMGIA g)
        {
            GIAMGIA gg = dbContext.GIAMGIAs.FirstOrDefault(t => t.MAGIAMGIA == g.MAGIAMGIA);
            gg.MOTA = g.MOTA;
            gg.NGAYBD = g.NGAYBD;
            gg.DONHANGTU = g.DONHANGTU;
            gg.GIATRITOIDA = g.GIATRITOIDA;
            gg.MUCGIAMGIA = g.MUCGIAMGIA;
            gg.TENGIAMGIA = g.TENGIAMGIA;
            gg.NGAYKT = g.NGAYKT;
            dbContext.SubmitChanges();
        }
    }
}
