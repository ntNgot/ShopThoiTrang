using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhieuNhap_BLLDAL
    {
        QLSHOPDataContext db = new QLSHOPDataContext();

        public List<PHIEUNHAP> list_PhieuNhap()
        {
            return db.PHIEUNHAPs.ToList();
        }
        public List<CHITIETPHIEUNHAP> list_CTPN(int maPN)
        {
            return db.CHITIETPHIEUNHAPs.Where(t=>t.MAPHIEUNHAP==maPN).ToList();
        }
        public void huy_PhieuNhap(int maPN)
        {
            PHIEUNHAP pn = db.PHIEUNHAPs.Where(t => t.MAPHIEUNHAP == maPN).FirstOrDefault();
            pn.TRANGTHAI = "HỦY";
            db.SubmitChanges();

        }
        public void nhapHang_vaoKho(int maPN)
        {
            PHIEUNHAP pn = db.PHIEUNHAPs.Where(t => t.MAPHIEUNHAP == maPN).FirstOrDefault();
            var ctpn = db.CHITIETPHIEUNHAPs.Where(t => t.MAPHIEUNHAP == pn.MAPHIEUNHAP).ToList();
            foreach(var item in ctpn)
            {
                CHITIETSANPHAM ctSP = db.CHITIETSANPHAMs.Where(t => t.MACHITIETSP == item.MACHITIETSP).FirstOrDefault();
                ctSP.SOLUONGTON += item.SOLUONG;
                db.SubmitChanges();
            }
            pn.TRANGTHAI = "Đã nhập hàng";
            db.SubmitChanges();
        }

        public void taoPhieuNhap(Cart dsPhieuNhap)
        {
            //Tao phieu nhap

            PHIEUNHAP pn = new PHIEUNHAP();
            pn.TRANGTHAI = "Chưa Nhập Hàng";
            pn.TONGTIEN = dsPhieuNhap.tongThanhTien();
            pn.NGAYLAP = DateTime.Now;
            db.PHIEUNHAPs.InsertOnSubmit(pn);

            db.SubmitChanges();
            //tao chi tiet phieu nhap
            foreach(var item in dsPhieuNhap.dsSP)
            {
                CHITIETPHIEUNHAP ctpn = new CHITIETPHIEUNHAP();
                ctpn.MAPHIEUNHAP = pn.MAPHIEUNHAP;
                ctpn.MACHITIETSP = item.iMaChiTietSP;
                ctpn.SOLUONG = item.iSoLuong;
                ctpn.DONGIA = item.iDonGia;
                ctpn.THANHTIEN = item.thanhTien;

                db.CHITIETPHIEUNHAPs.InsertOnSubmit(ctpn);
                db.SubmitChanges();

            }


        }
        public PHIEUNHAP getMaPNMoi()
        {
            return db.PHIEUNHAPs.OrderByDescending(hd => hd.MAPHIEUNHAP).First();
        }
    }
}
