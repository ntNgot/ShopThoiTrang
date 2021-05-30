using BLL_DAL;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using GUI.Cashier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        
        public static FormLogin frmLogin = null;
        public static string linkURL_Image = @"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\";
        public static string linkURL_SanPham = @"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\sanpham\";
        public static string linkURL_LoaiSP = @"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\loaisanpham\";
        public static string linkURL_KhachHang = @"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\KhachHang\";
        public static string linkURL_NhanVien = @"D:\CongNghePhanMem\ShopThoiTrang\Nhom8_KDPM_PhanMemQuanLyShopQuanAo\Image\nhanvien\";
        public static FormTN formTN = null;
       
        public static Cart dsGH = new Cart();
        public static int soLuong = Program.dsGH.tongSoLuong();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FormLogin();
            //  Application.Run(new FormCart());
            //using (Reporting.frmPrint frmPrint = new Reporting.frmPrint())
            //{
            //    frmPrint.PrintBillThuNgan(8);
            //    frmPrint.ShowDialog();
            //}
            Application.Run(frmLogin);
            //Application.Run(new FormTN());
        }
    }
}
