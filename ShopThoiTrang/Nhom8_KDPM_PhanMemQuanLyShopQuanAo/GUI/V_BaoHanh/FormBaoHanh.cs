using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.V_BaoHanh;
namespace GUI.V_BaoHanh
{
    public partial class FormBaoHanh : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormBaoHanh()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            UserControl_LapPhieuBH frm= new UserControl_LapPhieuBH();
            pnMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void FormBaoHanh_Load(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            UserControl_LapPhieuBH frm = new UserControl_LapPhieuBH();
            pnMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            UserControls_DSPhieuBaoHanh frm = new UserControls_DSPhieuBaoHanh();
            pnMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            UserControls_DSDaBHXong frm = new UserControls_DSDaBHXong();
            pnMain.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
        }
    }
}
