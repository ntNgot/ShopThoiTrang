
namespace GUI.Cashier
{
    partial class formTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTaiKhoan));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbTenNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.lbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.lbSDT = new DevExpress.XtraEditors.LabelControl();
            this.lbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.lbCMND = new DevExpress.XtraEditors.LabelControl();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.picHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureEdit1.TabIndex = 3;
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
            this.tablePanel1.SetColumnSpan(this.labelControl1, 9);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 203);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 5);
            this.labelControl1.Size = new System.Drawing.Size(1030, 60);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "THÔNG TIN TÀI KHOẢN NHÂN VIÊN";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbTenNhanVien.Appearance.Options.UseFont = true;
            this.lbTenNhanVien.Appearance.Options.UseTextOptions = true;
            this.lbTenNhanVien.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tablePanel1.SetColumn(this.lbTenNhanVien, 5);
            this.tablePanel1.SetColumnSpan(this.lbTenNhanVien, 3);
            this.lbTenNhanVien.Location = new System.Drawing.Point(665, 428);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.tablePanel1.SetRow(this.lbTenNhanVien, 10);
            this.lbTenNhanVien.Size = new System.Drawing.Size(127, 24);
            this.lbTenNhanVien.TabIndex = 5;
            this.lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbNgaySinh.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbNgaySinh, 5);
            this.tablePanel1.SetColumnSpan(this.lbNgaySinh, 3);
            this.lbNgaySinh.Location = new System.Drawing.Point(665, 502);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.tablePanel1.SetRow(this.lbNgaySinh, 12);
            this.lbNgaySinh.Size = new System.Drawing.Size(87, 24);
            this.lbNgaySinh.TabIndex = 6;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbSDT
            // 
            this.lbSDT.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbSDT.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbSDT, 5);
            this.tablePanel1.SetColumnSpan(this.lbSDT, 3);
            this.lbSDT.Location = new System.Drawing.Point(665, 640);
            this.lbSDT.Name = "lbSDT";
            this.tablePanel1.SetRow(this.lbSDT, 16);
            this.lbSDT.Size = new System.Drawing.Size(92, 24);
            this.lbSDT.TabIndex = 8;
            this.lbSDT.Text = "Điện thoại";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbGioiTinh.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbGioiTinh, 5);
            this.tablePanel1.SetColumnSpan(this.lbGioiTinh, 3);
            this.lbGioiTinh.Location = new System.Drawing.Point(665, 571);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.tablePanel1.SetRow(this.lbGioiTinh, 14);
            this.lbGioiTinh.Size = new System.Drawing.Size(74, 24);
            this.lbGioiTinh.TabIndex = 9;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbCMND
            // 
            this.lbCMND.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbCMND.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbCMND, 5);
            this.tablePanel1.SetColumnSpan(this.lbCMND, 3);
            this.lbCMND.Location = new System.Drawing.Point(665, 709);
            this.lbCMND.Name = "lbCMND";
            this.tablePanel1.SetRow(this.lbCMND, 18);
            this.lbCMND.Size = new System.Drawing.Size(54, 24);
            this.lbCMND.TabIndex = 10;
            this.lbCMND.Text = "CMND";
            // 
            // lbEmail
            // 
            this.lbEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbEmail.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.lbEmail, 5);
            this.tablePanel1.SetColumnSpan(this.lbEmail, 3);
            this.lbEmail.Location = new System.Drawing.Point(665, 778);
            this.lbEmail.Name = "lbEmail";
            this.tablePanel1.SetRow(this.lbEmail, 20);
            this.lbEmail.Size = new System.Drawing.Size(49, 24);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // picHinhAnh
            // 
            this.tablePanel1.SetColumn(this.picHinhAnh, 1);
            this.tablePanel1.SetColumnSpan(this.picHinhAnh, 2);
            this.picHinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHinhAnh.Location = new System.Drawing.Point(41, 363);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Properties.ReadOnly = true;
            this.picHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.picHinhAnh, 9);
            this.tablePanel1.SetRowSpan(this.picHinhAnh, 12);
            this.picHinhAnh.Size = new System.Drawing.Size(366, 448);
            this.picHinhAnh.TabIndex = 12;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 16.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 117.56F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 16.76F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 94.08F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.76F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60.96F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.36F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.picHinhAnh);
            this.tablePanel1.Controls.Add(this.lbEmail);
            this.tablePanel1.Controls.Add(this.lbCMND);
            this.tablePanel1.Controls.Add(this.lbGioiTinh);
            this.tablePanel1.Controls.Add(this.lbSDT);
            this.tablePanel1.Controls.Add(this.lbNgaySinh);
            this.tablePanel1.Controls.Add(this.lbTenNhanVien);
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
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 66.00003F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 14F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 53.3333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 23.33334F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 21.33333F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1946, 1106);
            this.tablePanel1.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl7, 4);
            this.labelControl7.Location = new System.Drawing.Point(451, 778);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 20);
            this.labelControl7.Size = new System.Drawing.Size(56, 24);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Email:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl6, 4);
            this.labelControl6.Location = new System.Drawing.Point(451, 709);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 18);
            this.labelControl6.Size = new System.Drawing.Size(61, 24);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "CMND:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl5, 4);
            this.labelControl5.Location = new System.Drawing.Point(451, 640);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 16);
            this.labelControl5.Size = new System.Drawing.Size(99, 24);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Điện thoại:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl4, 4);
            this.labelControl4.Location = new System.Drawing.Point(451, 571);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 14);
            this.labelControl4.Size = new System.Drawing.Size(81, 24);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Giới tính:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.labelControl3, 4);
            this.labelControl3.Location = new System.Drawing.Point(451, 502);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 12);
            this.labelControl3.Size = new System.Drawing.Size(94, 24);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Ngày sinh:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.tablePanel1.SetColumn(this.labelControl2, 4);
            this.labelControl2.Location = new System.Drawing.Point(451, 428);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 10);
            this.labelControl2.Size = new System.Drawing.Size(134, 24);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên nhân viên:";
            // 
            // formTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "formTaiKhoan";
            this.Size = new System.Drawing.Size(1946, 1106);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit picHinhAnh;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl lbCMND;
        private DevExpress.XtraEditors.LabelControl lbGioiTinh;
        private DevExpress.XtraEditors.LabelControl lbSDT;
        private DevExpress.XtraEditors.LabelControl lbNgaySinh;
        private DevExpress.XtraEditors.LabelControl lbTenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
