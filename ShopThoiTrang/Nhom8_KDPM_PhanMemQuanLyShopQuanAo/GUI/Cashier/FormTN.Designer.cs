
namespace GUI
{
    partial class FormTN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTN));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barButtonItemCart = new DevExpress.XtraBars.BarButtonItem();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            this.btnClearCart = new DevExpress.XtraBars.BarButtonItem();
            this.accordionControlContainer = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementListCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementBills = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementBill = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementInformation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementChangePassword = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.lbSPVuaChon = new System.Windows.Forms.Label();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::GUI.WaitForm1), true, true);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControlContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.fluentDesignFormControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(337, 42);
            this.container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1043, 743);
            this.container.TabIndex = 0;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1,
            this.barButtonItemCart,
            this.itemNav,
            this.btnClearCart});
            this.fluentFormDefaultManager1.MaxItemId = 7;
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barButtonItemCart
            // 
            this.barButtonItemCart.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItemCart.Caption = "CART(0)";
            this.barButtonItemCart.Id = 2;
            this.barButtonItemCart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemCart.ImageOptions.Image")));
            this.barButtonItemCart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemCart.ImageOptions.LargeImage")));
            this.barButtonItemCart.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.barButtonItemCart.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItemCart.ItemAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barButtonItemCart.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItemCart.ItemInMenuAppearance.Disabled.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemInMenuAppearance.Disabled.Options.UseForeColor = true;
            this.barButtonItemCart.ItemInMenuAppearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemInMenuAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItemCart.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemInMenuAppearance.Normal.Options.UseForeColor = true;
            this.barButtonItemCart.ItemInMenuAppearance.Pressed.ForeColor = System.Drawing.Color.White;
            this.barButtonItemCart.ItemInMenuAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItemCart.Name = "barButtonItemCart";
            this.barButtonItemCart.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItemCart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCart_ItemClick);
            // 
            // itemNav
            // 
            this.itemNav.Caption = "???";
            this.itemNav.Id = 4;
            this.itemNav.Name = "itemNav";
            this.itemNav.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnClearCart.Caption = "CLEAR CART";
            this.btnClearCart.Id = 6;
            this.btnClearCart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCart.ImageOptions.Image")));
            this.btnClearCart.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClearCart.ImageOptions.LargeImage")));
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnClearCart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClearCart_ItemClick);
            // 
            // accordionControlContainer
            // 
            this.accordionControlContainer.AllowDrop = true;
            this.accordionControlContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControlContainer.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementHome,
            this.accordionControlElementListCustomer,
            this.accordionControlElementCard,
            this.accordionControlElementProduct,
            this.accordionControlElementBills,
            this.accordionControlElementBill,
            this.accordionControlElementAccount,
            this.accordionControlElementLogOut});
            this.accordionControlContainer.Location = new System.Drawing.Point(0, 42);
            this.accordionControlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accordionControlContainer.Name = "accordionControlContainer";
            this.accordionControlContainer.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControlContainer.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControlContainer.Size = new System.Drawing.Size(337, 743);
            this.accordionControlContainer.TabIndex = 1;
            this.accordionControlContainer.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementHome
            // 
            this.accordionControlElementHome.ImageOptions.SvgImage = global::GUI.Properties.Resources.actions_home;
            this.accordionControlElementHome.Name = "accordionControlElementHome";
            this.accordionControlElementHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementHome.Text = "HOME";
            this.accordionControlElementHome.Click += new System.EventHandler(this.accordionControlElementHome_Click);
            // 
            // accordionControlElementListCustomer
            // 
            this.accordionControlElementListCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementListCustomer.ImageOptions.Image")));
            this.accordionControlElementListCustomer.Name = "accordionControlElementListCustomer";
            this.accordionControlElementListCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementListCustomer.Text = "LIST OF CUSTOMERS";
            this.accordionControlElementListCustomer.Click += new System.EventHandler(this.accordionControlElementListCustomer_Click);
            // 
            // accordionControlElementCard
            // 
            this.accordionControlElementCard.Expanded = true;
            this.accordionControlElementCard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementCard.ImageOptions.Image")));
            this.accordionControlElementCard.Name = "accordionControlElementCard";
            this.accordionControlElementCard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCard.Text = "CREATE CUSTOMER CARD";
            this.accordionControlElementCard.Click += new System.EventHandler(this.accordionControlElementCard_Click);
            // 
            // accordionControlElementProduct
            // 
            this.accordionControlElementProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementProduct.ImageOptions.SvgImage")));
            this.accordionControlElementProduct.Name = "accordionControlElementProduct";
            this.accordionControlElementProduct.Text = "PRODUCT";
            // 
            // accordionControlElementBills
            // 
            this.accordionControlElementBills.Expanded = true;
            this.accordionControlElementBills.ImageOptions.Image = global::GUI.Properties.Resources.edittask_32x32;
            this.accordionControlElementBills.Name = "accordionControlElementBills";
            this.accordionControlElementBills.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementBills.Text = "ALL BILLS SOLD";
            this.accordionControlElementBills.Click += new System.EventHandler(this.accordionControlElementBills_Click);
            // 
            // accordionControlElementBill
            // 
            this.accordionControlElementBill.Expanded = true;
            this.accordionControlElementBill.ImageOptions.Image = global::GUI.Properties.Resources.boorderitem_32x32;
            this.accordionControlElementBill.Name = "accordionControlElementBill";
            this.accordionControlElementBill.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementBill.Text = "BILL IS CREATING";
            this.accordionControlElementBill.Visible = false;
            this.accordionControlElementBill.Click += new System.EventHandler(this.accordionControlElementBill_Click);
            // 
            // accordionControlElementAccount
            // 
            this.accordionControlElementAccount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementInformation,
            this.accordionControlElementChangePassword});
            this.accordionControlElementAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementAccount.ImageOptions.Image")));
            this.accordionControlElementAccount.Name = "accordionControlElementAccount";
            this.accordionControlElementAccount.Text = "ACCOUNT";
            // 
            // accordionControlElementInformation
            // 
            this.accordionControlElementInformation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementInformation.ImageOptions.Image")));
            this.accordionControlElementInformation.Name = "accordionControlElementInformation";
            this.accordionControlElementInformation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementInformation.Text = "INFORMATION";
            this.accordionControlElementInformation.Click += new System.EventHandler(this.accordionControlElementInformation_Click);
            // 
            // accordionControlElementChangePassword
            // 
            this.accordionControlElementChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementChangePassword.ImageOptions.Image")));
            this.accordionControlElementChangePassword.Name = "accordionControlElementChangePassword";
            this.accordionControlElementChangePassword.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementChangePassword.Text = "CHANGE PASSWORD";
            this.accordionControlElementChangePassword.Click += new System.EventHandler(this.accordionControlElementChangePassword_Click);
            // 
            // accordionControlElementLogOut
            // 
            this.accordionControlElementLogOut.Expanded = true;
            this.accordionControlElementLogOut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementLogOut.ImageOptions.Image")));
            this.accordionControlElementLogOut.Name = "accordionControlElementLogOut";
            this.accordionControlElementLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementLogOut.Text = "LOG OUT";
            this.accordionControlElementLogOut.Click += new System.EventHandler(this.accordionControlElementLogOut_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Controls.Add(this.lbSPVuaChon);
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1,
            this.barButtonItemCart,
            this.itemNav,
            this.btnClearCart});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1380, 42);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinDropDownButtonItem1);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItemCart);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav, true);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btnClearCart);
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // lbSPVuaChon
            // 
            this.lbSPVuaChon.AutoSize = true;
            this.lbSPVuaChon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSPVuaChon.Location = new System.Drawing.Point(309, 12);
            this.lbSPVuaChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSPVuaChon.Name = "lbSPVuaChon";
            this.lbSPVuaChon.Size = new System.Drawing.Size(0, 29);
            this.lbSPVuaChon.TabIndex = 0;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 785);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControlContainer);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTN";
            this.NavigationControl = this.accordionControlContainer;
            this.Text = "FormTN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTN_FormClosed);
            this.Load += new System.EventHandler(this.FormThuNgan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControlContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.fluentDesignFormControl1.ResumeLayout(false);
            this.fluentDesignFormControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlContainer;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProduct;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementBill;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCart;
        private DevExpress.XtraBars.BarStaticItem itemNav;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementLogOut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementBills;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementHome;
        private System.Windows.Forms.Label lbSPVuaChon;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementListCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementInformation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnClearCart;
    }
}