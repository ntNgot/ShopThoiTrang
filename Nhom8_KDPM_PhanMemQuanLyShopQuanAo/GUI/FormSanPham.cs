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
namespace GUI
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        dbQLShopDataContext db = new dbQLShopDataContext();
        LoaiSanPham_BLLDAL loaiSP_BLL = new LoaiSanPham_BLLDAL();
        SanPham_BLLDAL sanPham_BLL = new SanPham_BLLDAL();
        
        

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLSHOPDataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.Fill(this.qLSHOPDataSet.DataTable1);
            //Load_SP();
        }
        public void Load_SP()
        {
            cbLoaiSP.DataSource = loaiSP_BLL.load_LoaiSP().ToList();
            cbLoaiSP.Tag = cbLoaiSP;
            
            
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LOAISANPHAM loaiSP = loaiSP_BLL.loaiSP_tenLoai(cbLoaiSP.Text);
            //var listSP = sanPham_BLL.loadSanPham_ForLoai(loaiSP.MALOAISANPHAM).Select(t => new {
            //    t.MASANPHAM,
            //    t.TENSANPHAM,
            //    t.SOLUONGTON,
            //    t.DONGIA,
            //    t.TRANGTHAI,
            //    t.MOTA
            //}).ToList();
            //dataGridView1.DataSource = listSP;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SANPHAM sanpham = sanPham_BLL.detailSanpham(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            //pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\sanpham\\" + sanpham.HINHANH);
            //txtMaSP.Text = sanpham.MASANPHAM.ToString();
            //txtTenSP.Text = sanpham.TENSANPHAM;
            //txtSoLuongTon.Text = sanpham.SOLUONGTON.ToString();
            //txtDonGia.Text = sanpham.DONGIA.ToString();
            //txtMoTa.Text = sanpham.MOTA;

            //if (sanpham.TRANGTHAI == true)
            //{
            //    txtTrangThai.Text = "Còn hàng";
            //}
            //else
            //    txtTrangThai.Text = "Hết hàng";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGioHang frmCart = new FormGioHang();
            frmCart.Show();
            this.Hide();
        }

        private void btnThemGH_Click(object sender, EventArgs e)
        {
            //try { SANPHAM sanpham = sanPham_BLL.detailSanpham(int.Parse(txtMaSP.Text));
            

            //if (sanPham_BLL.kiemTraSLTon(Program.dsGH, sanpham.MASANPHAM) == "duyệt")
            //{
            //    if (sanpham == null) return;
            //    Program.dsGH.Them(sanpham.MASANPHAM, 1);
            //    lbsubTB.Text = "Đã thêm sản phẩm:";
            //    lbThongBao.Text =sanpham.TENSANPHAM.ToString();
            //    lbSoLuongGioHang.Text = Program.dsGH.dsSP.Select(t => t.iSoLuong).Sum().ToString();
            //    return;
            //}
            //lbsubTB.Text = "";
            //lbThongBao.Text = sanPham_BLL.kiemTraSLTon(Program.dsGH, sanpham.MASANPHAM);
            //}

            //catch { }
           



        }
        int x = 354, y = 9, a = 2;
        //637, 8


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                if (lbThongBao.Text == "ĐÃ HẾT HÀNG")
                {
                    lbsubTB.Text = "";
                    if (lbThongBao.ForeColor == Color.Red)
                    {
                        lbThongBao.ForeColor = Color.White;
                        return;
                    }

                    lbThongBao.ForeColor = Color.Red;
                    return;
                }
                lbThongBao.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
