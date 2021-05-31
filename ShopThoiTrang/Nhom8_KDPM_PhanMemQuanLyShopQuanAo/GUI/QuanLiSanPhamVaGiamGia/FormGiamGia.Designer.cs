
namespace GUI
{
    partial class FormGiamGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiamGia));
            this.gcGiamGia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAGIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENGIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIATRITOIDA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONHANGTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColuMUCGIAMGIAmn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaGG = new System.Windows.Forms.TextBox();
            this.txtTenGG = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.txtMucGG = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTaoMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuayLai = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcGiamGia
            // 
            this.gcGiamGia.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcGiamGia.Location = new System.Drawing.Point(13, 38);
            this.gcGiamGia.MainView = this.gridView1;
            this.gcGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.gcGiamGia.Name = "gcGiamGia";
            this.gcGiamGia.Size = new System.Drawing.Size(1091, 399);
            this.gcGiamGia.TabIndex = 0;
            this.gcGiamGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcGiamGia.Click += new System.EventHandler(this.gcGiamGia_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAGIAMGIA,
            this.TENGIAMGIA,
            this.MOTA,
            this.GIATRITOIDA,
            this.DONHANGTU,
            this.NGAYBD,
            this.NGAYKT,
            this.gridColuMUCGIAMGIAmn8});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcGiamGia;
            this.gridView1.Name = "gridView1";
            // 
            // MAGIAMGIA
            // 
            this.MAGIAMGIA.Caption = "Mã giảm giá";
            this.MAGIAMGIA.FieldName = "MAGIAMGIA";
            this.MAGIAMGIA.MinWidth = 25;
            this.MAGIAMGIA.Name = "MAGIAMGIA";
            this.MAGIAMGIA.OptionsColumn.AllowEdit = false;
            this.MAGIAMGIA.OptionsColumn.AllowFocus = false;
            this.MAGIAMGIA.OptionsColumn.ReadOnly = true;
            this.MAGIAMGIA.Visible = true;
            this.MAGIAMGIA.VisibleIndex = 0;
            this.MAGIAMGIA.Width = 94;
            // 
            // TENGIAMGIA
            // 
            this.TENGIAMGIA.Caption = "Tên giảm giá";
            this.TENGIAMGIA.FieldName = "TENGIAMGIA";
            this.TENGIAMGIA.MinWidth = 25;
            this.TENGIAMGIA.Name = "TENGIAMGIA";
            this.TENGIAMGIA.OptionsColumn.AllowEdit = false;
            this.TENGIAMGIA.OptionsColumn.AllowFocus = false;
            this.TENGIAMGIA.OptionsColumn.ReadOnly = true;
            this.TENGIAMGIA.Visible = true;
            this.TENGIAMGIA.VisibleIndex = 1;
            this.TENGIAMGIA.Width = 94;
            // 
            // MOTA
            // 
            this.MOTA.Caption = "Mô tả";
            this.MOTA.FieldName = "MOTA";
            this.MOTA.MinWidth = 25;
            this.MOTA.Name = "MOTA";
            this.MOTA.OptionsColumn.AllowEdit = false;
            this.MOTA.OptionsColumn.AllowFocus = false;
            this.MOTA.OptionsColumn.ReadOnly = true;
            this.MOTA.Visible = true;
            this.MOTA.VisibleIndex = 2;
            this.MOTA.Width = 94;
            // 
            // GIATRITOIDA
            // 
            this.GIATRITOIDA.Caption = "Giá trị tối đa";
            this.GIATRITOIDA.FieldName = "GIATRITOIDA";
            this.GIATRITOIDA.MinWidth = 25;
            this.GIATRITOIDA.Name = "GIATRITOIDA";
            this.GIATRITOIDA.OptionsColumn.AllowEdit = false;
            this.GIATRITOIDA.OptionsColumn.AllowFocus = false;
            this.GIATRITOIDA.OptionsColumn.ReadOnly = true;
            this.GIATRITOIDA.Visible = true;
            this.GIATRITOIDA.VisibleIndex = 3;
            this.GIATRITOIDA.Width = 94;
            // 
            // DONHANGTU
            // 
            this.DONHANGTU.Caption = "Yêu cầu đơn hàng";
            this.DONHANGTU.FieldName = "DONHANGTU";
            this.DONHANGTU.MinWidth = 25;
            this.DONHANGTU.Name = "DONHANGTU";
            this.DONHANGTU.OptionsColumn.AllowEdit = false;
            this.DONHANGTU.OptionsColumn.AllowFocus = false;
            this.DONHANGTU.OptionsColumn.ReadOnly = true;
            this.DONHANGTU.Visible = true;
            this.DONHANGTU.VisibleIndex = 4;
            this.DONHANGTU.Width = 94;
            // 
            // NGAYBD
            // 
            this.NGAYBD.Caption = "Ngày bắt đầu";
            this.NGAYBD.FieldName = "NGAYBD";
            this.NGAYBD.MinWidth = 25;
            this.NGAYBD.Name = "NGAYBD";
            this.NGAYBD.OptionsColumn.AllowEdit = false;
            this.NGAYBD.OptionsColumn.AllowFocus = false;
            this.NGAYBD.OptionsColumn.ReadOnly = true;
            this.NGAYBD.Visible = true;
            this.NGAYBD.VisibleIndex = 5;
            this.NGAYBD.Width = 94;
            // 
            // NGAYKT
            // 
            this.NGAYKT.Caption = "Ngày kết thúc";
            this.NGAYKT.FieldName = "NGAYKT";
            this.NGAYKT.MinWidth = 25;
            this.NGAYKT.Name = "NGAYKT";
            this.NGAYKT.OptionsColumn.AllowEdit = false;
            this.NGAYKT.OptionsColumn.AllowFocus = false;
            this.NGAYKT.OptionsColumn.ReadOnly = true;
            this.NGAYKT.Visible = true;
            this.NGAYKT.VisibleIndex = 6;
            this.NGAYKT.Width = 94;
            // 
            // gridColuMUCGIAMGIAmn8
            // 
            this.gridColuMUCGIAMGIAmn8.Caption = "Mức giảm giá";
            this.gridColuMUCGIAMGIAmn8.FieldName = "MUCGIAMGIA";
            this.gridColuMUCGIAMGIAmn8.MinWidth = 25;
            this.gridColuMUCGIAMGIAmn8.Name = "gridColuMUCGIAMGIAmn8";
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.AllowEdit = false;
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.AllowFocus = false;
            this.gridColuMUCGIAMGIAmn8.OptionsColumn.ReadOnly = true;
            this.gridColuMUCGIAMGIAmn8.Visible = true;
            this.gridColuMUCGIAMGIAmn8.VisibleIndex = 7;
            this.gridColuMUCGIAMGIAmn8.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên giảm giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá trị tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yêu cầu đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mức giảm giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(549, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(549, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày kết thúc";
            // 
            // txtMaGG
            // 
            this.txtMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGG.Location = new System.Drawing.Point(192, 461);
            this.txtMaGG.Name = "txtMaGG";
            this.txtMaGG.Size = new System.Drawing.Size(324, 28);
            this.txtMaGG.TabIndex = 9;
            // 
            // txtTenGG
            // 
            this.txtTenGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGG.Location = new System.Drawing.Point(192, 505);
            this.txtTenGG.Name = "txtTenGG";
            this.txtTenGG.Size = new System.Drawing.Size(324, 28);
            this.txtTenGG.TabIndex = 10;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(192, 549);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(324, 28);
            this.txtMoTa.TabIndex = 11;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTri.Location = new System.Drawing.Point(192, 593);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(324, 28);
            this.txtGiaTri.TabIndex = 12;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCau.Location = new System.Drawing.Point(721, 461);
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.Size = new System.Drawing.Size(313, 28);
            this.txtYeuCau.TabIndex = 13;
            // 
            // txtMucGG
            // 
            this.txtMucGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucGG.Location = new System.Drawing.Point(721, 505);
            this.txtMucGG.Name = "txtMucGG";
            this.txtMucGG.Size = new System.Drawing.Size(313, 28);
            this.txtMucGG.TabIndex = 14;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(721, 547);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(313, 28);
            this.dtpNgayBD.TabIndex = 15;
            this.dtpNgayBD.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(721, 592);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(313, 28);
            this.dtpNgayKT.TabIndex = 16;
            this.dtpNgayKT.Value = new System.DateTime(2021, 5, 24, 0, 0, 0, 0);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaoMoi,
            this.btnThem,
            this.btnSua,
            this.btnQuayLai});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1118, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 665);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1118, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 636);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1118, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 636);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuayLai)});
            this.bar1.Text = "Tools";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Caption = "Tạo mới";
            this.btnTaoMoi.Id = 0;
            this.btnTaoMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnTaoMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoMoi_ItemClick);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Hint = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Caption = "Quay lại";
            this.btnQuayLai.Id = 3;
            this.btnQuayLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.btnQuayLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnQuayLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuayLai_ItemClick);
            // 
            // FormGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 665);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txtMucGG);
            this.Controls.Add(this.txtYeuCau);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenGG);
            this.Controls.Add(this.txtMaGG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcGiamGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormGiamGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiamGia";
            this.Load += new System.EventHandler(this.FormGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcGiamGia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAGIAMGIA;
        private DevExpress.XtraGrid.Columns.GridColumn TENGIAMGIA;
        private DevExpress.XtraGrid.Columns.GridColumn MOTA;
        private DevExpress.XtraGrid.Columns.GridColumn GIATRITOIDA;
        private DevExpress.XtraGrid.Columns.GridColumn DONHANGTU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColuMUCGIAMGIAmn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaGG;
        private System.Windows.Forms.TextBox txtTenGG;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtYeuCau;
        private System.Windows.Forms.TextBox txtMucGG;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTaoMoi;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnQuayLai;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}