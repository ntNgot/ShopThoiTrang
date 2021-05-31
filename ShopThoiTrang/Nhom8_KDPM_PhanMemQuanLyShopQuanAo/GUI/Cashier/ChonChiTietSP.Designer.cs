
namespace GUI.Cashier
{
    partial class ChonChiTietSP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.lbTenSP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.lbDonGia = new DevExpress.XtraEditors.LabelControl();
            this.lbMoTa = new DevExpress.XtraEditors.LabelControl();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.linkReturn = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lbSL = new DevExpress.XtraEditors.LabelControl();
            this.cboChonSize = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboChonMau = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picHinhAnh
            // 
            this.tablePanel1.SetColumn(this.picHinhAnh, 0);
            this.tablePanel1.SetColumnSpan(this.picHinhAnh, 4);
            this.picHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHinhAnh.Location = new System.Drawing.Point(3, 83);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.picHinhAnh, 2);
            this.tablePanel1.SetRowSpan(this.picHinhAnh, 13);
            this.picHinhAnh.Size = new System.Drawing.Size(261, 494);
            this.picHinhAnh.TabIndex = 0;
            // 
            // lbTenSP
            // 
            this.lbTenSP.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbTenSP.Appearance.Options.UseFont = true;
            this.lbTenSP.Appearance.Options.UseTextOptions = true;
            this.lbTenSP.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbTenSP.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbTenSP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.lbTenSP, 0);
            this.tablePanel1.SetColumnSpan(this.lbTenSP, 9);
            this.lbTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTenSP.Location = new System.Drawing.Point(3, 3);
            this.lbTenSP.Name = "lbTenSP";
            this.tablePanel1.SetRow(this.lbTenSP, 0);
            this.tablePanel1.SetRowSpan(this.lbTenSP, 2);
            this.lbTenSP.Size = new System.Drawing.Size(763, 74);
            this.lbTenSP.TabIndex = 1;
            this.lbTenSP.Text = "Tên Sản Phẩm";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl1, 4);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl1.Location = new System.Drawing.Point(349, 123);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 3);
            this.labelControl1.Size = new System.Drawing.Size(76, 24);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Đơn giá:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tablePanel1.SetColumn(this.labelControl2, 4);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(270, 163);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 4);
            this.labelControl2.Size = new System.Drawing.Size(155, 34);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mô tả:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl3, 4);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl3.Location = new System.Drawing.Point(340, 83);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(85, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Số lượng:";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbSoLuong.Appearance.Options.UseFont = true;
            this.lbSoLuong.Appearance.Options.UseTextOptions = true;
            this.lbSoLuong.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbSoLuong.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.lbSoLuong, 5);
            this.tablePanel1.SetColumnSpan(this.lbSoLuong, 4);
            this.lbSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSoLuong.Location = new System.Drawing.Point(431, 83);
            this.lbSoLuong.Name = "lbSoLuong";
            this.tablePanel1.SetRow(this.lbSoLuong, 2);
            this.lbSoLuong.Size = new System.Drawing.Size(335, 34);
            this.lbSoLuong.TabIndex = 5;
            this.lbSoLuong.Text = "labelControl4";
            // 
            // lbDonGia
            // 
            this.lbDonGia.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDonGia.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbDonGia.Appearance.Options.UseFont = true;
            this.lbDonGia.Appearance.Options.UseForeColor = true;
            this.lbDonGia.Appearance.Options.UseTextOptions = true;
            this.lbDonGia.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbDonGia.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.lbDonGia, 5);
            this.tablePanel1.SetColumnSpan(this.lbDonGia, 4);
            this.lbDonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDonGia.Location = new System.Drawing.Point(431, 123);
            this.lbDonGia.Name = "lbDonGia";
            this.tablePanel1.SetRow(this.lbDonGia, 3);
            this.lbDonGia.Size = new System.Drawing.Size(335, 34);
            this.lbDonGia.TabIndex = 6;
            this.lbDonGia.Text = "labelControl5";
            // 
            // lbMoTa
            // 
            this.lbMoTa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbMoTa.Appearance.Options.UseFont = true;
            this.lbMoTa.Appearance.Options.UseTextOptions = true;
            this.lbMoTa.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbMoTa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.tablePanel1.SetColumn(this.lbMoTa, 5);
            this.tablePanel1.SetColumnSpan(this.lbMoTa, 4);
            this.lbMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMoTa.Location = new System.Drawing.Point(431, 163);
            this.lbMoTa.Name = "lbMoTa";
            this.tablePanel1.SetRow(this.lbMoTa, 4);
            this.tablePanel1.SetRowSpan(this.lbMoTa, 4);
            this.lbMoTa.Size = new System.Drawing.Size(335, 154);
            this.lbMoTa.TabIndex = 7;
            this.lbMoTa.Text = "labelControl6";
            this.lbMoTa.DoubleClick += new System.EventHandler(this.lbMoTa_DoubleClick);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.btnXacNhan, 5);
            this.tablePanel1.SetColumnSpan(this.btnXacNhan, 2);
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXacNhan.Location = new System.Drawing.Point(431, 516);
            this.btnXacNhan.Name = "btnXacNhan";
            this.tablePanel1.SetRow(this.btnXacNhan, 13);
            this.tablePanel1.SetRowSpan(this.btnXacNhan, 2);
            this.btnXacNhan.Size = new System.Drawing.Size(156, 61);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl8, 4);
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl8.Location = new System.Drawing.Point(328, 410);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 9);
            this.labelControl8.Size = new System.Drawing.Size(97, 24);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Chọn màu:";
            // 
            // linkReturn
            // 
            this.linkReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linkReturn.Appearance.Options.UseFont = true;
            this.linkReturn.Appearance.Options.UseTextOptions = true;
            this.linkReturn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablePanel1.SetColumn(this.linkReturn, 7);
            this.linkReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkReturn.Location = new System.Drawing.Point(594, 516);
            this.linkReturn.Name = "linkReturn";
            this.tablePanel1.SetRow(this.linkReturn, 13);
            this.tablePanel1.SetRowSpan(this.linkReturn, 2);
            this.linkReturn.Size = new System.Drawing.Size(148, 61);
            this.linkReturn.TabIndex = 13;
            this.linkReturn.Text = "Quay lại";
            this.linkReturn.Click += new System.EventHandler(this.linkReturn_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59.6F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 128.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 124.12F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 123.37F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 19.91F)});
            this.tablePanel1.Controls.Add(this.lbSL);
            this.tablePanel1.Controls.Add(this.cboChonSize);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.cboChonMau);
            this.tablePanel1.Controls.Add(this.linkReturn);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.btnXacNhan);
            this.tablePanel1.Controls.Add(this.lbMoTa);
            this.tablePanel1.Controls.Add(this.lbDonGia);
            this.tablePanel1.Controls.Add(this.lbSoLuong);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.lbTenSP);
            this.tablePanel1.Controls.Add(this.picHinhAnh);
            this.tablePanel1.Controls.Add(this.txtSoLuong);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 86.66671F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 44.66663F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.55F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.75F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.27F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 64.43F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 39.8F)});
            this.tablePanel1.Size = new System.Drawing.Size(769, 613);
            this.tablePanel1.TabIndex = 0;
            // 
            // lbSL
            // 
            this.lbSL.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbSL.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbSL, 4);
            this.lbSL.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSL.Location = new System.Drawing.Point(340, 323);
            this.lbSL.Name = "lbSL";
            this.tablePanel1.SetRow(this.lbSL, 8);
            this.lbSL.Size = new System.Drawing.Size(85, 24);
            this.lbSL.TabIndex = 21;
            this.lbSL.Text = "Số lượng:";
            // 
            // cboChonSize
            // 
            this.cboChonSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tablePanel1.SetColumn(this.cboChonSize, 5);
            this.tablePanel1.SetColumnSpan(this.cboChonSize, 3);
            this.cboChonSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonSize.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboChonSize.FormattingEnabled = true;
            this.cboChonSize.Location = new System.Drawing.Point(431, 463);
            this.cboChonSize.Name = "cboChonSize";
            this.tablePanel1.SetRow(this.cboChonSize, 11);
            this.cboChonSize.Size = new System.Drawing.Size(311, 32);
            this.cboChonSize.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl4, 4);
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl4.Location = new System.Drawing.Point(333, 463);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 11);
            this.labelControl4.Size = new System.Drawing.Size(92, 24);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Chọn size:";
            // 
            // cboChonMau
            // 
            this.cboChonMau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tablePanel1.SetColumn(this.cboChonMau, 5);
            this.tablePanel1.SetColumnSpan(this.cboChonMau, 3);
            this.cboChonMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboChonMau.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboChonMau.FormattingEnabled = true;
            this.cboChonMau.Location = new System.Drawing.Point(431, 410);
            this.cboChonMau.Name = "cboChonMau";
            this.tablePanel1.SetRow(this.cboChonMau, 9);
            this.cboChonMau.Size = new System.Drawing.Size(311, 32);
            this.cboChonMau.TabIndex = 18;
            this.cboChonMau.SelectedIndexChanged += new System.EventHandler(this.cboChonMau_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.tablePanel1.SetColumn(this.txtSoLuong, 5);
            this.tablePanel1.SetColumnSpan(this.txtSoLuong, 3);
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoLuong.Location = new System.Drawing.Point(431, 323);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtSoLuong.Properties.Mask.EditMask = "d";
            this.tablePanel1.SetRow(this.txtSoLuong, 8);
            this.txtSoLuong.Size = new System.Drawing.Size(311, 32);
            this.txtSoLuong.TabIndex = 22;
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // ChonChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ChonChiTietSP";
            this.Size = new System.Drawing.Size(769, 613);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picHinhAnh;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkReturn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.LabelControl lbMoTa;
        private DevExpress.XtraEditors.LabelControl lbDonGia;
        private DevExpress.XtraEditors.LabelControl lbSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbTenSP;
        private System.Windows.Forms.ComboBox cboChonMau;
        private System.Windows.Forms.ComboBox cboChonSize;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lbSL;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
    }
}
