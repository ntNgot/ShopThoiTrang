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
namespace GUI.V_BaoHanh
{
    public partial class UserControls_DSDaBHXong : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControls_DSDaBHXong()
        {
            InitializeComponent();
        }
        BaoHanh_BLLDAL BaoHanh_BLLDAL = new BaoHanh_BLLDAL();
        private void UserControls_DSDaBHXong_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = BaoHanh_BLLDAL.listBH().Where(t => t.TRANGTHAI == "Đã Bảo Hành").ToList();

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xuất báo cáo cho sp này?", "Question?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maPHBH = int.Parse(gridView1.GetFocusedRowCellValue("MAPHIEUBH").ToString());
                using (Reporting.frmPrint frmPrint = new Reporting.frmPrint())
                {
                    frmPrint.PrintPhieuBaoHanh(maPHBH);
                    frmPrint.ShowDialog();
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
