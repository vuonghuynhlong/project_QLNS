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
            this.rbPAGE = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rb_PAGE_GROUP_DANH_MUC = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bar_HOC_VAN = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bar_HOC_VAN});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPAGE});
            this.ribbon.Size = new System.Drawing.Size(858, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // rbPAGE
            // 
            this.rbPAGE.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rb_PAGE_GROUP_DANH_MUC});
            this.rbPAGE.Name = "rbPAGE";
            this.rbPAGE.Text = "Danh Sach Chuc Nang";
            // 
            // rb_PAGE_GROUP_DANH_MUC
            // 
            this.rb_PAGE_GROUP_DANH_MUC.ItemLinks.Add(this.bar_HOC_VAN);
            this.rb_PAGE_GROUP_DANH_MUC.Name = "rb_PAGE_GROUP_DANH_MUC";
            this.rb_PAGE_GROUP_DANH_MUC.Text = "Danh Muc";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 530);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(858, 32);
            // 
            // bar_HOC_VAN
            // 
            this.bar_HOC_VAN.Caption = "Hoc Van";
            this.bar_HOC_VAN.Id = 1;
            this.bar_HOC_VAN.LargeGlyph = global::QuanLyNhanSu.Properties.Resources.HOC_VAN;
            this.bar_HOC_VAN.Name = "bar_HOC_VAN";
            // 
            // frm_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 562);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frm_MAIN";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frm_MAIN";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPAGE;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rb_PAGE_GROUP_DANH_MUC;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bar_HOC_VAN;
    }
}