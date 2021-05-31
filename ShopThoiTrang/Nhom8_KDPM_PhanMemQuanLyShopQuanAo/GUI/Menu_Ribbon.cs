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
            FormNhanVien frm = new FormNhanVien();
            frm.Show();
        }
    }
}