﻿using DevExpress.XtraEditors;
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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace GUI
{
    public partial class FormBillsSold : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLLDAL hoaDonBLL = new HoaDonBLLDAL();
        public FormBillsSold()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            vw_HoaDonsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().vw_HoaDons;
            // This line of code is generated by Data Source Configuration Wizard
            vw_CTHDsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().vw_CTHDs;
        }


        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            vw_CTHDsBindingSource.DataSource = new BLL_DAL.QLShopDataContext().vw_CTHDs.Where(t=>t.MAHOADON == (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
            gridControl2.DataSource = vw_CTHDsBindingSource.DataSource;
        }
    }
}
