namespace QuanLyNhanSu
{
    partial class frm_TEMPLATE_EDIT
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
            this.group_PARENT = new DevExpress.XtraEditors.GroupControl();
            this.layout_CONTROL = new DevExpress.XtraLayout.LayoutControl();
            this.btn_SAVE = new DevExpress.XtraEditors.SimpleButton();
            this.panel_CONTROLS = new DevExpress.XtraEditors.PanelControl();
            this.layout_GROUP = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.group_PARENT)).BeginInit();
            this.group_PARENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).BeginInit();
            this.layout_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CONTROLS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_PARENT
            // 
            this.group_PARENT.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.group_PARENT.AppearanceCaption.Options.UseFont = true;
            this.group_PARENT.Controls.Add(this.layout_CONTROL);
            this.group_PARENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_PARENT.Location = new System.Drawing.Point(0, 0);
            this.group_PARENT.Name = "group_PARENT";
            this.group_PARENT.Size = new System.Drawing.Size(314, 329);
            this.group_PARENT.TabIndex = 0;
            this.group_PARENT.Text = "Thông tin bắt buộc";
            // 
            // layout_CONTROL
            // 
            this.layout_CONTROL.Controls.Add(this.btn_SAVE);
            this.layout_CONTROL.Controls.Add(this.panel_CONTROLS);
            this.layout_CONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_CONTROL.Location = new System.Drawing.Point(2, 20);
            this.layout_CONTROL.Name = "layout_CONTROL";
            this.layout_CONTROL.Padding = new System.Windows.Forms.Padding(2);
            this.layout_CONTROL.Root = this.layout_GROUP;
            this.layout_CONTROL.Size = new System.Drawing.Size(310, 307);
            this.layout_CONTROL.TabIndex = 0;
            this.layout_CONTROL.Text = "layoutControl1";
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SAVE.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_SAVE.Appearance.Options.UseFont = true;
            this.btn_SAVE.Image = global::QuanLyNhanSu.Properties.Resources.SAVE;
            this.btn_SAVE.Location = new System.Drawing.Point(230, 274);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(77, 30);
            this.btn_SAVE.StyleController = this.layout_CONTROL;
            this.btn_SAVE.TabIndex = 0;
            this.btn_SAVE.Text = "Lưu";
            // 
            // panel_CONTROLS
            // 
            this.panel_CONTROLS.Location = new System.Drawing.Point(3, 3);
            this.panel_CONTROLS.Name = "panel_CONTROLS";
            this.panel_CONTROLS.Size = new System.Drawing.Size(304, 267);
            this.panel_CONTROLS.TabIndex = 4;
            // 
            // layout_GROUP
            // 
            this.layout_GROUP.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layout_GROUP.GroupBordersVisible = false;
            this.layout_GROUP.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.layout_GROUP.Location = new System.Drawing.Point(0, 0);
            this.layout_GROUP.Name = "layout_GROUP";
            this.layout_GROUP.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layout_GROUP.Size = new System.Drawing.Size(310, 307);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel_CONTROLS;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(308, 271);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_SAVE;
            this.layoutControlItem3.Location = new System.Drawing.Point(227, 271);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(81, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 271);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(227, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_TEMPLATE_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 329);
            this.Controls.Add(this.group_PARENT);
            this.Name = "frm_TEMPLATE_EDIT";
            this.Text = "frm_TEMPLATE_EDIT";
            this.Load += new System.EventHandler(this.frm_TEMPLATE_EDIT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group_PARENT)).EndInit();
            this.group_PARENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).EndInit();
            this.layout_CONTROL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_CONTROLS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.GroupControl group_PARENT;
        protected DevExpress.XtraLayout.LayoutControl layout_CONTROL;
        protected DevExpress.XtraLayout.LayoutControlGroup layout_GROUP;
        public DevExpress.XtraEditors.PanelControl panel_CONTROLS;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected DevExpress.XtraEditors.SimpleButton btn_SAVE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}