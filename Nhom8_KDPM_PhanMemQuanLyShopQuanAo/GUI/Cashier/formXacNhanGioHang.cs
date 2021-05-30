using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI.Cashier
{
    public partial class formXacNhanGioHang : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLLDAL hdBLL = new HoaDonBLLDAL();
        KhachHang_BLLDAL khBLL = new KhachHang_BLLDAL();
        public int maHoaDon;
        public formXacNhanGioHang()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            List<KHACHHANG> dsKH = khBLL.layDSKH().ToList();
            int maHD = hdBLL.loadHD_Last().MAHOADON+1;
            string ngayTao = DateTime.Now.Date.ToString();
            int tienThanhToan = Program.formTN.chiTietGioHang.Sum(t => t.THANHTIEN);
            string nhanVien = Program.frmLogin.TaiKhoan.NHANVIEN.TENNHANVIEN;
            //
            txtMaHoaDon.Text = maHD + "";
            cboKhachHang.DataSource = dsKH;
            cboKhachHang.DisplayMember = "TENKHACHHANG";
            cboKhachHang.ValueMember = "MAKHACHHANG";
            cboKhachHang.Text = "";
            txtNgayTao.Text = ngayTao;
            txtTienThanhToan.Text = tienThanhToan + "VNĐ";
            txtNhanVienTao.Text = nhanVien;
        }
        public void taoHoaDon()
        {
            HOADON hd = new HOADON();
            List<KHACHHANG> dsKH = khBLL.layDSKH().ToList();
            hd.MAHOADON = hdBLL.loadHD_Last().MAHOADON + 1;
            hd.NGAYTAO = DateTime.Now.Date;
            hd.THANHTIEN= Program.formTN.chiTietGioHang.Sum(t => t.THANHTIEN);
            hd.MANHANVIEN = Program.frmLogin.TaiKhoan.NHANVIEN.MANHANVIEN;
            if (!cboKhachHang.Text.Equals(""))
            {
                hd.MAKHACHHANG = int.Parse(cboKhachHang.SelectedValue.ToString());
            }
            maHoaDon = hd.MAHOADON;
            if (!hdBLL.TaoHoaDon(hd))
                MessageBox.Show("Tạo hóa đơn thất bại", "Thất bại");
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Program.formTN._frmCard.quayTroLai_Cart();
            Program.formTN._frmCard.btnThanhToan.Text = "TẠO HÓA ĐƠN";
        }
    }
}
