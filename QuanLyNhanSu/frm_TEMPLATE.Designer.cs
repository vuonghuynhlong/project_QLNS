namespace QuanLyNhanSu
{
    partial class frm_TEMPLATE
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
            this.dg_DATA = new DevExpress.XtraGrid.GridControl();
            this.gv_DATA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layout_CONTROL = new DevExpress.XtraLayout.LayoutControl();
            this.pic_EXPORT = new DevExpress.XtraEditors.PictureEdit();
            this.pic_DELETE = new DevExpress.XtraEditors.PictureEdit();
            this.pic_UPDATE = new DevExpress.XtraEditors.PictureEdit();
            this.pic_INSERT = new DevExpress.XtraEditors.PictureEdit();
            this.layout_GROUP = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout_GRID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_INSERT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_EXPORT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_UPDATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_DELETE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).BeginInit();
            this.layout_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_EXPORT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DELETE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UPDATE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_INSERT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_INSERT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_EXPORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_UPDATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_DELETE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_DATA
            // 
            this.dg_DATA.Location = new System.Drawing.Point(12, 72);
            this.dg_DATA.MainView = this.gv_DATA;
            this.dg_DATA.Name = "dg_DATA";
            this.dg_DATA.Size = new System.Drawing.Size(660, 377);
            this.dg_DATA.TabIndex = 0;
            this.dg_DATA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DATA});
            // 
            // gv_DATA
            // 
            this.gv_DATA.GridControl = this.dg_DATA;
            this.gv_DATA.Name = "gv_DATA";
            this.gv_DATA.OptionsBehavior.Editable = false;
            this.gv_DATA.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gv_DATA.OptionsView.ShowAutoFilterRow = true;
            this.gv_DATA.OptionsView.ShowGroupPanel = false;
            // 
            // layout_CONTROL
            // 
            this.layout_CONTROL.Controls.Add(this.pic_EXPORT);
            this.layout_CONTROL.Controls.Add(this.pic_DELETE);
            this.layout_CONTROL.Controls.Add(this.pic_UPDATE);
            this.layout_CONTROL.Controls.Add(this.pic_INSERT);
            this.layout_CONTROL.Controls.Add(this.dg_DATA);
            this.layout_CONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_CONTROL.Location = new System.Drawing.Point(0, 0);
            this.layout_CONTROL.Name = "layout_CONTROL";
            this.layout_CONTROL.OptionsView.AllowHotTrack = true;
            this.layout_CONTROL.Root = this.layout_GROUP;
            this.layout_CONTROL.Size = new System.Drawing.Size(684, 461);
            this.layout_CONTROL.TabIndex = 1;
            this.layout_CONTROL.Text = "layoutControl1";
            // 
            // pic_EXPORT
            // 
            this.pic_EXPORT.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_EXPORT.EditValue = global::QuanLyNhanSu.Properties.Resources.EXPORT;
            this.pic_EXPORT.Location = new System.Drawing.Point(385, 12);
            this.pic_EXPORT.Name = "pic_EXPORT";
            this.pic_EXPORT.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_EXPORT.Properties.ZoomAccelerationFactor = 1D;
            this.pic_EXPORT.Size = new System.Drawing.Size(117, 56);
            this.pic_EXPORT.StyleController = this.layout_CONTROL;
            this.pic_EXPORT.TabIndex = 6;
            this.pic_EXPORT.ToolTip = "Xuất dữ liệu";
            // 
            // pic_DELETE
            // 
            this.pic_DELETE.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_DELETE.EditValue = global::QuanLyNhanSu.Properties.Resources.DELETE;
            this.pic_DELETE.Location = new System.Drawing.Point(261, 12);
            this.pic_DELETE.Name = "pic_DELETE";
            this.pic_DELETE.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_DELETE.Properties.ZoomAccelerationFactor = 1D;
            this.pic_DELETE.Size = new System.Drawing.Size(120, 56);
            this.pic_DELETE.StyleController = this.layout_CONTROL;
            this.pic_DELETE.TabIndex = 7;
            this.pic_DELETE.ToolTip = "Xóa";
            // 
            // pic_UPDATE
            // 
            this.pic_UPDATE.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_UPDATE.EditValue = global::QuanLyNhanSu.Properties.Resources.UPDATE;
            this.pic_UPDATE.Location = new System.Drawing.Point(133, 12);
            this.pic_UPDATE.Name = "pic_UPDATE";
            this.pic_UPDATE.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_UPDATE.Properties.ZoomAccelerationFactor = 1D;
            this.pic_UPDATE.Size = new System.Drawing.Size(124, 56);
            this.pic_UPDATE.StyleController = this.layout_CONTROL;
            this.pic_UPDATE.TabIndex = 5;
            this.pic_UPDATE.ToolTip = "Sửa";
            // 
            // pic_INSERT
            // 
            this.pic_INSERT.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_INSERT.EditValue = global::QuanLyNhanSu.Properties.Resources.INSERT;
            this.pic_INSERT.Location = new System.Drawing.Point(12, 12);
            this.pic_INSERT.Name = "pic_INSERT";
            this.pic_INSERT.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_INSERT.Properties.ZoomAccelerationFactor = 1D;
            this.pic_INSERT.Size = new System.Drawing.Size(117, 56);
            this.pic_INSERT.StyleController = this.layout_CONTROL;
            this.pic_INSERT.TabIndex = 4;
            this.pic_INSERT.ToolTip = "Thêm mới";
            // 
            // layout_GROUP
            // 
            this.layout_GROUP.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layout_GROUP.GroupBordersVisible = false;
            this.layout_GROUP.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout_GRID,
            this.layout_INSERT,
            this.layout_EXPORT,
            this.layout_UPDATE,
            this.layout_DELETE,
            this.emptySpaceItem1});
            this.layout_GROUP.Location = new System.Drawing.Point(0, 0);
            this.layout_GROUP.Name = "Root";
            this.layout_GROUP.Size = new System.Drawing.Size(684, 461);
            this.layout_GROUP.TextVisible = false;
            // 
            // layout_GRID
            // 
            this.layout_GRID.Control = this.dg_DATA;
            this.layout_GRID.Location = new System.Drawing.Point(0, 60);
            this.layout_GRID.Name = "layout_GRID";
            this.layout_GRID.Size = new System.Drawing.Size(664, 381);
            this.layout_GRID.TextSize = new System.Drawing.Size(0, 0);
            this.layout_GRID.TextVisible = false;
            // 
            // layout_INSERT
            // 
            this.layout_INSERT.Control = this.pic_INSERT;
            this.layout_INSERT.Location = new System.Drawing.Point(0, 0);
            this.layout_INSERT.MaxSize = new System.Drawing.Size(121, 60);
            this.layout_INSERT.MinSize = new System.Drawing.Size(121, 60);
            this.layout_INSERT.Name = "layout_INSERT";
            this.layout_INSERT.Size = new System.Drawing.Size(121, 60);
            this.layout_INSERT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_INSERT.TextSize = new System.Drawing.Size(0, 0);
            this.layout_INSERT.TextVisible = false;
            // 
            // layout_EXPORT
            // 
            this.layout_EXPORT.Control = this.pic_EXPORT;
            this.layout_EXPORT.Location = new System.Drawing.Point(373, 0);
            this.layout_EXPORT.MaxSize = new System.Drawing.Size(121, 60);
            this.layout_EXPORT.MinSize = new System.Drawing.Size(121, 60);
            this.layout_EXPORT.Name = "layout_EXPORT";
            this.layout_EXPORT.Size = new System.Drawing.Size(121, 60);
            this.layout_EXPORT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_EXPORT.TextSize = new System.Drawing.Size(0, 0);
            this.layout_EXPORT.TextVisible = false;
            // 
            // layout_UPDATE
            // 
            this.layout_UPDATE.Control = this.pic_UPDATE;
            this.layout_UPDATE.Location = new System.Drawing.Point(121, 0);
            this.layout_UPDATE.MaxSize = new System.Drawing.Size(128, 60);
            this.layout_UPDATE.MinSize = new System.Drawing.Size(128, 60);
            this.layout_UPDATE.Name = "layout_UPDATE";
            this.layout_UPDATE.Size = new System.Drawing.Size(128, 60);
            this.layout_UPDATE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_UPDATE.TextSize = new System.Drawing.Size(0, 0);
            this.layout_UPDATE.TextVisible = false;
            // 
            // layout_DELETE
            // 
            this.layout_DELETE.Control = this.pic_DELETE;
            this.layout_DELETE.Location = new System.Drawing.Point(249, 0);
            this.layout_DELETE.MaxSize = new System.Drawing.Size(124, 60);
            this.layout_DELETE.MinSize = new System.Drawing.Size(124, 60);
            this.layout_DELETE.Name = "layout_DELETE";
            this.layout_DELETE.Size = new System.Drawing.Size(124, 60);
            this.layout_DELETE.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_DELETE.TextSize = new System.Drawing.Size(0, 0);
            this.layout_DELETE.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(494, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(170, 60);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_TEMPLATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout_CONTROL);
            this.Name = "frm_TEMPLATE";
            this.Size = new System.Drawing.Size(684, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).EndInit();
            this.layout_CONTROL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_EXPORT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DELETE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UPDATE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_INSERT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_INSERT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_EXPORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_UPDATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_DELETE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.Views.Grid.GridView gv_DATA;
        protected DevExpress.XtraEditors.PictureEdit pic_INSERT;
        protected DevExpress.XtraLayout.LayoutControlGroup layout_GROUP;
        protected DevExpress.XtraLayout.LayoutControlItem layout_GRID;
        protected DevExpress.XtraLayout.LayoutControlItem layout_INSERT;
        protected DevExpress.XtraEditors.PictureEdit pic_UPDATE;
        protected DevExpress.XtraLayout.LayoutControlItem layout_UPDATE;
        protected DevExpress.XtraEditors.PictureEdit pic_DELETE;
        protected DevExpress.XtraEditors.PictureEdit pic_EXPORT;
        protected DevExpress.XtraLayout.LayoutControlItem layout_EXPORT;
        protected DevExpress.XtraLayout.LayoutControlItem layout_DELETE;
        protected DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        protected DevExpress.XtraLayout.LayoutControl layout_CONTROL;
        public DevExpress.XtraGrid.GridControl dg_DATA;
    }
}
