using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BLL_DAL;
using System.Collections.Generic;

namespace GUI.Reporting
{
    public partial class ReportPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        PhieuNhap_BLLDAL phieuNhap_BLLDAL = new PhieuNhap_BLLDAL();

        public ReportPhieuNhap()
        {
            InitializeComponent();
        }
        public void InitData(int maPN)
        {
            List<CHITIETPHIEUNHAP> listctPN = phieuNhap_BLLDAL.list_CTPN(maPN);
            objectDataSource1.DataSource = listctPN;
        }

    }
}
