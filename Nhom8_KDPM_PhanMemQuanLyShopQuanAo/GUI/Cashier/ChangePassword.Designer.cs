
namespace GUI.Cashier
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtNhapMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.picHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnHienThiMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnHienThiCu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThayDoi = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.tablePanel1.SetColumnSpan(this.labelControl1, 7);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 203);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 5);
            this.labelControl1.Size = new System.Drawing.Size(896, 65);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "THÔNG TIN TÀI KHOẢN NHÂN VIÊN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(45, 714);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 18);
            this.labelControl2.Size = new System.Drawing.Size(108, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mật khẩu cũ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(45, 785);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 20);
            this.labelControl3.Size = new System.Drawing.Size(127, 24);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Mật khẩu mới ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(45, 855);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 22);
            this.labelControl4.Size = new System.Drawing.Size(163, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Nhập lại mật khẩu";
            // 
            // txtMatKhauCu
            // 
            this.tablePanel1.SetColumn(this.txtMatKhauCu, 2);
            this.tablePanel1.SetColumnSpan(this.txtMatKhauCu, 4);
            this.txtMatKhauCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhauCu.Enabled = false;
            this.txtMatKhauCu.Location = new System.Drawing.Point(242, 708);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMatKhauCu.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauCu.Properties.UseSystemPasswordChar = true;
            this.tablePanel1.SetRow(this.txtMatKhauCu, 18);
            this.txtMatKhauCu.Size = new System.Drawing.Size(480, 37);
            this.txtMatKhauCu.TabIndex = 9;
            // 
            // txtMatKhauMoi
            // 
            this.tablePanel1.SetColumn(this.txtMatKhauMoi, 2);
            this.tablePanel1.SetColumnSpan(this.txtMatKhauMoi, 4);
            this.txtMatKhauMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhauMoi.Enabled = false;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(242, 778);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMatKhauMoi.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauMoi.Properties.UseSystemPasswordChar = true;
            this.tablePanel1.SetRow(this.txtMatKhauMoi, 20);
            this.txtMatKhauMoi.Size = new System.Drawing.Size(480, 39);
            this.txtMatKhauMoi.TabIndex = 10;
            // 
            // txtNhapMatKhau
            // 
            this.tablePanel1.SetColumn(this.txtNhapMatKhau, 2);
            this.tablePanel1.SetColumnSpan(this.txtNhapMatKhau, 4);
            this.txtNhapMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapMatKhau.Enabled = false;
            this.txtNhapMatKhau.Location = new System.Drawing.Point(242, 848);
            this.txtNhapMatKhau.Name = "txtNhapMatKhau";
            this.txtNhapMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNhapMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtNhapMatKhau.Properties.UseSystemPasswordChar = true;
            this.tablePanel1.SetRow(this.txtNhapMatKhau, 22);
            this.txtNhapMatKhau.Size = new System.Drawing.Size(480, 38);
            this.txtNhapMatKhau.TabIndex = 11;
            // 
            // picHinhAnh
            // 
            this.tablePanel1.SetColumn(this.picHinhAnh, 2);
            this.tablePanel1.SetColumnSpan(this.picHinhAnh, 3);
            this.picHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHinhAnh.Location = new System.Drawing.Point(242, 283);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Properties.ReadOnly = true;
            this.picHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.picHinhAnh, 7);
            this.tablePanel1.SetRowSpan(this.picHinhAnh, 8);
            this.picHinhAnh.Size = new System.Drawing.Size(336, 335);
            this.picHinhAnh.TabIndex = 12;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 18.42F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 86.58F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.68F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 87.06F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36.26F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 63.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 77.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 8.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.btnHienThiMoi);
            this.tablePanel1.Controls.Add(this.btnHienThiCu);
            this.tablePanel1.Controls.Add(this.txtTenTaiKhoan);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.btnLuu);
            this.tablePanel1.Controls.Add(this.btnThayDoi);
            this.tablePanel1.Controls.Add(this.picHinhAnh);
            this.tablePanel1.Controls.Add(this.txtNhapMatKhau);
            this.tablePanel1.Controls.Add(this.txtMatKhauMoi);
            this.tablePanel1.Controls.Add(this.txtMatKhauCu);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.pictureEdit1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 71.33335F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 8.666664F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60.66668F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 19.33334F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24.66667F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 43.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.66667F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 44.66666F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24.66668F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 44F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 29.33332F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 61.33336F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 61.33337F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50.66667F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F)});
            this.tablePanel1.Size = new System.Drawing.Size(1946, 1106);
            this.tablePanel1.TabIndex = 0;
            // 
            // btnHienThiMoi
            // 
            this.btnHienThiMoi.AutoSize = true;
            this.tablePanel1.SetColumn(this.btnHienThiMoi, 6);
            this.btnHienThiMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiMoi.ImageOptions.Image")));
            this.btnHienThiMoi.Location = new System.Drawing.Point(728, 778);
            this.btnHienThiMoi.Name = "btnHienThiMoi";
            this.btnHienThiMoi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel1.SetRow(this.btnHienThiMoi, 20);
            this.btnHienThiMoi.Size = new System.Drawing.Size(44, 39);
            this.btnHienThiMoi.TabIndex = 26;
            this.btnHienThiMoi.Click += new System.EventHandler(this.btnHienThiMoi_Click);
            // 
            // btnHienThiCu
            // 
            this.btnHienThiCu.AutoSize = true;
            this.tablePanel1.SetColumn(this.btnHienThiCu, 6);
            this.btnHienThiCu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHienThiCu.ImageOptions.Image")));
            this.btnHienThiCu.Location = new System.Drawing.Point(728, 708);
            this.btnHienThiCu.Name = "btnHienThiCu";
            this.btnHienThiCu.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.tablePanel1.SetRow(this.btnHienThiCu, 18);
            this.btnHienThiCu.Size = new System.Drawing.Size(44, 37);
            this.btnHienThiCu.TabIndex = 25;
            this.btnHienThiCu.Click += new System.EventHandler(this.btnHienThiCu_Click);
            // 
            // txtTenTaiKhoan
            // 
            this.tablePanel1.SetColumn(this.txtTenTaiKhoan, 2);
            this.tablePanel1.SetColumnSpan(this.txtTenTaiKhoan, 4);
            this.txtTenTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTaiKhoan.EditValue = "";
            this.txtTenTaiKhoan.Enabled = false;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(242, 643);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.tablePanel1.SetRow(this.txtTenTaiKhoan, 16);
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(480, 34);
            this.txtTenTaiKhoan.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl5, 1);
            this.labelControl5.Location = new System.Drawing.Point(45, 648);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 16);
            this.labelControl5.Size = new System.Drawing.Size(123, 24);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Tên tài khoản";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.btnLuu, 5);
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(583, 921);
            this.btnLuu.Name = "btnLuu";
            this.tablePanel1.SetRow(this.btnLuu, 24);
            this.btnLuu.Size = new System.Drawing.Size(139, 55);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "LƯU ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThayDoi
            // 
            this.tablePanel1.SetColumn(this.btnThayDoi, 3);
            this.btnThayDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThayDoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThayDoi.ImageOptions.SvgImage")));
            this.btnThayDoi.Location = new System.Drawing.Point(303, 921);
            this.btnThayDoi.Name = "btnThayDoi";
            this.tablePanel1.SetRow(this.btnThayDoi, 24);
            this.btnThayDoi.Size = new System.Drawing.Size(192, 55);
            this.btnThayDoi.TabIndex = 13;
            this.btnThayDoi.Text = "THAY ĐỔI";
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // pictureEdit1
            // 
            this.tablePanel1.SetColumn(this.pictureEdit1, 0);
            this.tablePanel1.SetColumnSpan(this.pictureEdit1, 17);
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.tablePanel1.SetRow(this.pictureEdit1, 0);
            this.tablePanel1.SetRowSpan(this.pictureEdit1, 5);
            this.pictureEdit1.Size = new System.Drawing.Size(1940, 194);
            this.pictureEdit1.TabIndex = 4;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(1946, 1106);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnThayDoi;
        private DevExpress.XtraEditors.PictureEdit picHinhAnh;
        private DevExpress.XtraEditors.TextEdit txtNhapMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txtMatKhauCu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHienThiMoi;
        private DevExpress.XtraEditors.SimpleButton btnHienThiCu;
    }
}
