using DevExpress.XtraBars;
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
using GUI.V_BaoHanh;
namespace GUI
{
    public partial class Menu_Ribbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu_Ribbon()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frStatistical qlsp = new frStatistical();
            qlsp.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.formTN = new FormTN();
            Program.formTN.Show();

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormQLSP qlsp = new FormQLSP();
            qlsp.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormNhanVien frm = new FormNhanVien();
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormGiamGia gg = new FormGiamGia();
            gg.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormNhapHang frm = new FormNhapHang();
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           if(Program.frmLogin.TaiKhoan.NHANVIEN.CHUCVU== "QuanLy")
            {
             FormNhanVien frm = new FormNhanVien();
             frm.Show();
                return;
            }
            MessageBox.Show("Chức năng này chỉ dành cho Quản Lý");           
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormBaoHanh frm = new FormBaoHanh();
            frm.Show();
        }
    }
}