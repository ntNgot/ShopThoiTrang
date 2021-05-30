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
namespace GUI.V_NhapHang
{
    public partial class UserControl_ALLPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControl_ALLPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhap_BLLDAL phieuNhap_BLLDAL = new PhieuNhap_BLLDAL();
        private void UserControl_ALLPhieuNhap_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = phieuNhap_BLLDAL.list_PhieuNhap();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatBáoCáo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int maPN = int.Parse(gridView1.GetFocusedRowCellDisplayText("MAPHIEUNHAP"));
            if(MessageBox.Show("xuất báo cáo cho: "+maPN,"Thông báo!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using (Reporting.frmPrint frmPrint = new Reporting.frmPrint())
                {
                    frmPrint.PrintPhieuNhap(maPN);
                    frmPrint.ShowDialog();
                }
            }    

        }
    }
}
