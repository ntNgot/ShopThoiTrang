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
    public partial class UserControls_DSPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControls_DSPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhap_BLLDAL phieuNhap_BLLDAL = new PhieuNhap_BLLDAL();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControls_DSPhieuNhap_Load(object sender, EventArgs e)
        {
            Load_DL();

        }

       public void Load_DL()
        {
            gridControl1.DataSource = phieuNhap_BLLDAL.list_PhieuNhap().Where(t => t.TRANGTHAI == "Chưa Nhập Hàng").ToList();
            chitietphieunhapTableAdapter2.Fill(shopThoiTrang_DataSet.CHITIETPHIEUNHAP);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int maPN = int.Parse(gridView1.GetFocusedRowCellDisplayText("MAPHIEUNHAP"));
            if (MessageBox.Show("Bán có muốn Hủy phiếu nhập này!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                phieuNhap_BLLDAL.huy_PhieuNhap(maPN);
                MessageBox.Show("Đã chuyển Trạng thái thành HỦY");
                Load_DL();

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int maPN = int.Parse(gridView1.GetFocusedRowCellDisplayText("MAPHIEUNHAP"));
            if (MessageBox.Show("Bạn có chắc là đã nhập những mặt hàng này vào Kho?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                phieuNhap_BLLDAL.nhapHang_vaoKho(maPN);
                MessageBox.Show("Đã nhập hàng thành công!");
                Load_DL();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
