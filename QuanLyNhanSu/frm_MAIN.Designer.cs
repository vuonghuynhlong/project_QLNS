namespace QuanLyNhanSu
{
    partial class frm_MAIN
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bar_HOC_VAN = new DevExpress.XtraBars.BarButtonItem();
            this.bar_NGOAI_NGU = new DevExpress.XtraBars.BarButtonItem();
            this.bar_TIN_HOC = new DevExpress.XtraBars.BarButtonItem();
            this.bar_CHUC_VU = new DevExpress.XtraBars.BarButtonItem();
            this.bar_CHUYEN_MON = new DevExpress.XtraBars.BarButtonItem();
            this.bar_QUOC_TICH = new DevExpress.XtraBars.BarButtonItem();
            this.bar_DAN_TOC = new DevExpress.XtraBars.BarButtonItem();
            this.bar_TON_GIAO = new DevExpress.XtraBars.BarButtonItem();
            this.bar_NHAN_VIEN = new DevExpress.XtraBars.BarButtonItem();
            this.bar_HOP_DONG_LAO_DONG = new DevExpress.XtraBars.BarButtonItem();
            this.bar_PHONG_BAN = new DevExpress.XtraBars.BarButtonItem();
            this.rbPAGE = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rb_PAGE_GROUP_DANH_MUC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rb_QUAN_LY_NHAN_SU = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tab_MANAGER = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_MANAGER)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bar_HOC_VAN,
            this.bar_NGOAI_NGU,
            this.bar_TIN_HOC,
            this.bar_CHUC_VU,
            this.bar_CHUYEN_MON,
            this.bar_QUOC_TICH,
            this.bar_DAN_TOC,
            this.bar_TON_GIAO,
            this.bar_NHAN_VIEN,
            this.bar_HOP_DONG_LAO_DONG,
            this.bar_PHONG_BAN});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPAGE});
            this.ribbon.Size = new System.Drawing.Size(858, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bar_HOC_VAN
            // 
            this.bar_HOC_VAN.Caption = "Học Vấn";
            this.bar_HOC_VAN.Id = 1;
            this.bar_HOC_VAN.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.HOC_VAN;
            this.bar_HOC_VAN.Name = "bar_HOC_VAN";
            this.bar_HOC_VAN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_NGOAI_NGU
            // 
            this.bar_NGOAI_NGU.Caption = "Ngoại Ngữ";
            this.bar_NGOAI_NGU.Id = 2;
            this.bar_NGOAI_NGU.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.LANGUAGE;
            this.bar_NGOAI_NGU.Name = "bar_NGOAI_NGU";
            this.bar_NGOAI_NGU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_TIN_HOC
            // 
            this.bar_TIN_HOC.Caption = "Tin Học";
            this.bar_TIN_HOC.Id = 3;
            this.bar_TIN_HOC.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.Computer_icon;
            this.bar_TIN_HOC.Name = "bar_TIN_HOC";
            this.bar_TIN_HOC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_CHUC_VU
            // 
            this.bar_CHUC_VU.Caption = "Chức Vụ";
            this.bar_CHUC_VU.Id = 4;
            this.bar_CHUC_VU.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.POSITION;
            this.bar_CHUC_VU.Name = "bar_CHUC_VU";
            this.bar_CHUC_VU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_CHUYEN_MON
            // 
            this.bar_CHUYEN_MON.Caption = "Chuyên Môn";
            this.bar_CHUYEN_MON.Id = 5;
            this.bar_CHUYEN_MON.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.WORK;
            this.bar_CHUYEN_MON.Name = "bar_CHUYEN_MON";
            this.bar_CHUYEN_MON.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_QUOC_TICH
            // 
            this.bar_QUOC_TICH.Caption = "Quốc Tịch";
            this.bar_QUOC_TICH.Id = 6;
            this.bar_QUOC_TICH.Name = "bar_QUOC_TICH";
            this.bar_QUOC_TICH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_DAN_TOC
            // 
            this.bar_DAN_TOC.Caption = "Dân Tộc";
            this.bar_DAN_TOC.Id = 7;
            this.bar_DAN_TOC.Name = "bar_DAN_TOC";
            this.bar_DAN_TOC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_TON_GIAO
            // 
            this.bar_TON_GIAO.Caption = "Tôn Giáo";
            this.bar_TON_GIAO.Id = 8;
            this.bar_TON_GIAO.Name = "bar_TON_GIAO";
            this.bar_TON_GIAO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_NHAN_VIEN
            // 
            this.bar_NHAN_VIEN.Caption = "Danh Sách Nhân Viên";
            this.bar_NHAN_VIEN.Id = 9;
            this.bar_NHAN_VIEN.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.PEOPLE;
            this.bar_NHAN_VIEN.Name = "bar_NHAN_VIEN";
            this.bar_NHAN_VIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_HOP_DONG_LAO_DONG
            // 
            this.bar_HOP_DONG_LAO_DONG.Caption = "Hợp Đồng Lao Động";
            this.bar_HOP_DONG_LAO_DONG.Id = 10;
            this.bar_HOP_DONG_LAO_DONG.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.PAPER;
            this.bar_HOP_DONG_LAO_DONG.Name = "bar_HOP_DONG_LAO_DONG";
            this.bar_HOP_DONG_LAO_DONG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // bar_PHONG_BAN
            // 
            this.bar_PHONG_BAN.Caption = "Phòng Ban";
            this.bar_PHONG_BAN.Id = 11;
            this.bar_PHONG_BAN.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.DEPARTMENT;
            this.bar_PHONG_BAN.Name = "bar_PHONG_BAN";
            this.bar_PHONG_BAN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_ItemClick);
            // 
            // rbPAGE
            // 
            this.rbPAGE.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rb_PAGE_GROUP_DANH_MUC,
            this.rb_QUAN_LY_NHAN_SU});
            this.rbPAGE.Name = "rbPAGE";
            this.rbPAGE.Text = "Danh Sách Chức Năng";
            // 
            // rb_PAGE_GROUP_DANH_MUC
            // 
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_HOC_VAN);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_NGOAI_NGU);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_TIN_HOC);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_PHONG_BAN, true);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_CHUC_VU, true);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_CHUYEN_MON, true);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_QUOC_TICH, true);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_DAN_TOC);
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_TON_GIAO);
            this.rb_PAGE_GROUP_DANH_MUC.Name = "rb_PAGE_GROUP_DANH_MUC";
            this.rb_PAGE_GROUP_DANH_MUC.Text = "Danh Mục";
            // 
            // rb_QUAN_LY_NHAN_SU
            // 
            this.rb_QUAN_LY_NHAN_SU.ItemLinks.Add(this.bar_NHAN_VIEN);
            this.rb_QUAN_LY_NHAN_SU.ItemLinks.Add(this.bar_HOP_DONG_LAO_DONG, true);
            this.rb_QUAN_LY_NHAN_SU.Name = "rb_QUAN_LY_NHAN_SU";
            this.rb_QUAN_LY_NHAN_SU.Text = "Nghiệp Vụ";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 531);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(858, 31);
            // 
            // tab_MANAGER
            // 
            this.tab_MANAGER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_MANAGER.Location = new System.Drawing.Point(0, 143);
            this.tab_MANAGER.Name = "tab_MANAGER";
            this.tab_MANAGER.Size = new System.Drawing.Size(858, 388);
            this.tab_MANAGER.TabIndex = 2;
            this.tab_MANAGER.CloseButtonClick += new System.EventHandler(this.tab_MANAGER_CloseButtonClick);
            // 
            // frm_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 562);
            this.Controls.Add(this.tab_MANAGER);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frm_MAIN";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ NHÂN SỰ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_MANAGER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPAGE;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rb_PAGE_GROUP_DANH_MUC;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bar_HOC_VAN;
        private DevExpress.XtraBars.BarButtonItem bar_NGOAI_NGU;
        private DevExpress.XtraBars.BarButtonItem bar_TIN_HOC;
        private DevExpress.XtraBars.BarButtonItem bar_CHUC_VU;
        private DevExpress.XtraBars.BarButtonItem bar_CHUYEN_MON;
        private DevExpress.XtraBars.BarButtonItem bar_QUOC_TICH;
        private DevExpress.XtraBars.BarButtonItem bar_DAN_TOC;
        private DevExpress.XtraBars.BarButtonItem bar_TON_GIAO;
        private DevExpress.XtraBars.BarButtonItem bar_NHAN_VIEN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rb_QUAN_LY_NHAN_SU;
        private DevExpress.XtraBars.BarButtonItem bar_HOP_DONG_LAO_DONG;
        private DevExpress.XtraTab.XtraTabControl tab_MANAGER;
        private DevExpress.XtraBars.BarButtonItem bar_PHONG_BAN;
    }
}