using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BLL_DAL;
using System.Collections.Generic;

namespace GUI.Reporting
{
    public partial class ReportPhieuBaoHanh : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportPhieuBaoHanh()
        {
            InitializeComponent();
        }
        BaoHanh_BLLDAL baoHanh_BLLDAL = new BaoHanh_BLLDAL();
        public void InitData(int maBaoHanh)
        {
            List<CHITIETBAOHANH> listctBH = baoHanh_BLLDAL.listCTBH(maBaoHanh);
            objectDataSource1.DataSource = listctBH;
        }

    }
}
