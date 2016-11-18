namespace QuanLyNhanSu
{
    partial class frm_CHUC_VU_EDIT
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chk_IS_MANAGER = new DevExpress.XtraEditors.CheckEdit();
            this.txt_DESCRIPTION = new DevExpress.XtraEditors.TextEdit();
            this.txt_POSITION_NAME = new DevExpress.XtraEditors.TextEdit();
            this.txt_POSITION_CODE = new DevExpress.XtraEditors.TextEdit();
            this.frmControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutITEM2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutITEM4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutITEM5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutITEM3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emp1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.group_PARENT)).BeginInit();
            this.group_PARENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).BeginInit();
            this.layout_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CONTROLS)).BeginInit();
            this.panel_CONTROLS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_IS_MANAGER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DESCRIPTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_POSITION_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_POSITION_CODE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_PARENT
            // 
            this.group_PARENT.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.group_PARENT.AppearanceCaption.Options.UseFont = true;
            this.group_PARENT.Size = new System.Drawing.Size(348, 156);
            // 
            // layout_CONTROL
            // 
            this.layout_CONTROL.Size = new System.Drawing.Size(344, 134);
            this.layout_CONTROL.Controls.SetChildIndex(this.panel_CONTROLS, 0);
            this.layout_CONTROL.Controls.SetChildIndex(this.btn_SAVE, 0);
            // 
            // layout_GROUP
            // 
            this.layout_GROUP.Size = new System.Drawing.Size(344, 134);
            // 
            // panel_CONTROLS
            // 
            this.panel_CONTROLS.Controls.Add(this.layoutControl1);
            this.panel_CONTROLS.Size = new System.Drawing.Size(338, 94);
            // 
            // layoutControlItem1
            // 
            this.layout_1.Size = new System.Drawing.Size(342, 98);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_SAVE.Appearance.Options.UseFont = true;
            this.btn_SAVE.Location = new System.Drawing.Point(251, 101);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chk_IS_MANAGER);
            this.layoutControl1.Controls.Add(this.txt_DESCRIPTION);
            this.layoutControl1.Controls.Add(this.txt_POSITION_NAME);
            this.layoutControl1.Controls.Add(this.txt_POSITION_CODE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.AllowHotTrack = true;
            this.layoutControl1.Root = this.frmControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(334, 90);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chk_IS_MANAGER
            // 
            this.chk_IS_MANAGER.Location = new System.Drawing.Point(68, 52);
            this.chk_IS_MANAGER.Name = "chk_IS_MANAGER";
            this.chk_IS_MANAGER.Properties.Caption = "";
            this.chk_IS_MANAGER.Size = new System.Drawing.Size(262, 19);
            this.chk_IS_MANAGER.StyleController = this.layoutControl1;
            this.chk_IS_MANAGER.TabIndex = 3;
            // 
            // txt_DESCRIPTION
            // 
            this.txt_DESCRIPTION.EnterMoveNextControl = true;
            this.txt_DESCRIPTION.Location = new System.Drawing.Point(68, 28);
            this.txt_DESCRIPTION.Name = "txt_DESCRIPTION";
            this.txt_DESCRIPTION.Size = new System.Drawing.Size(262, 20);
            this.txt_DESCRIPTION.StyleController = this.layoutControl1;
            this.txt_DESCRIPTION.TabIndex = 2;
            // 
            // txt_POSITION_NAME
            // 
            this.txt_POSITION_NAME.EnterMoveNextControl = true;
            this.txt_POSITION_NAME.Location = new System.Drawing.Point(68, 4);
            this.txt_POSITION_NAME.Name = "txt_POSITION_NAME";
            this.txt_POSITION_NAME.Size = new System.Drawing.Size(153, 20);
            this.txt_POSITION_NAME.StyleController = this.layoutControl1;
            this.txt_POSITION_NAME.TabIndex = 1;
            // 
            // txt_POSITION_CODE
            // 
            this.txt_POSITION_CODE.EditValue = "";
            this.txt_POSITION_CODE.EnterMoveNextControl = true;
            this.txt_POSITION_CODE.Location = new System.Drawing.Point(225, 4);
            this.txt_POSITION_CODE.Name = "txt_POSITION_CODE";
            this.txt_POSITION_CODE.Properties.ReadOnly = true;
            this.txt_POSITION_CODE.Size = new System.Drawing.Size(105, 20);
            this.txt_POSITION_CODE.StyleController = this.layoutControl1;
            this.txt_POSITION_CODE.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.frmControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.frmControlGroup1.GroupBordersVisible = false;
            this.frmControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutITEM2,
            this.layoutITEM4,
            this.layoutITEM5,
            this.layoutITEM3,
            this.emp1});
            this.frmControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.frmControlGroup1.Name = "Root";
            this.frmControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.frmControlGroup1.Size = new System.Drawing.Size(334, 90);
            this.frmControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutITEM2.Control = this.txt_POSITION_CODE;
            this.layoutITEM2.Location = new System.Drawing.Point(221, 0);
            this.layoutITEM2.Name = "layoutControlItem2";
            this.layoutITEM2.Size = new System.Drawing.Size(109, 24);
            this.layoutITEM2.Text = "Mã Chức Vụ";
            this.layoutITEM2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutITEM2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutITEM4.Control = this.txt_DESCRIPTION;
            this.layoutITEM4.Location = new System.Drawing.Point(0, 24);
            this.layoutITEM4.Name = "layoutControlItem4";
            this.layoutITEM4.Size = new System.Drawing.Size(330, 24);
            this.layoutITEM4.Text = "Mô Tả\r\n";
            this.layoutITEM4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutITEM5.Control = this.chk_IS_MANAGER;
            this.layoutITEM5.Location = new System.Drawing.Point(0, 48);
            this.layoutITEM5.Name = "layoutControlItem5";
            this.layoutITEM5.Size = new System.Drawing.Size(330, 23);
            this.layoutITEM5.Text = "Là Quản Lý";
            this.layoutITEM5.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutITEM3.Control = this.txt_POSITION_NAME;
            this.layoutITEM3.Location = new System.Drawing.Point(0, 0);
            this.layoutITEM3.Name = "layoutControlItem3";
            this.layoutITEM3.Size = new System.Drawing.Size(221, 24);
            this.layoutITEM3.Text = "Tên Chức Vụ\r\n";
            this.layoutITEM3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // emptySpaceItem1
            // 
            this.emp1.AllowHotTrack = false;
            this.emp1.Location = new System.Drawing.Point(0, 71);
            this.emp1.Name = "emptySpaceItem1";
            this.emp1.Size = new System.Drawing.Size(330, 15);
            this.emp1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_CHUC_VU_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 156);
            this.Name = "frm_CHUC_VU_EDIT";
            this.Text = "CẬP NHẬT CHỨC VỤ";
            ((System.ComponentModel.ISupportInitialize)(this.group_PARENT)).EndInit();
            this.group_PARENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).EndInit();
            this.layout_CONTROL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CONTROLS)).EndInit();
            this.panel_CONTROLS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_IS_MANAGER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DESCRIPTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_POSITION_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_POSITION_CODE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutITEM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit chk_IS_MANAGER;
        private DevExpress.XtraEditors.TextEdit txt_DESCRIPTION;
        private DevExpress.XtraEditors.TextEdit txt_POSITION_NAME;
        private DevExpress.XtraEditors.TextEdit txt_POSITION_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup frmControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutITEM2;
        private DevExpress.XtraLayout.LayoutControlItem layoutITEM3;
        private DevExpress.XtraLayout.LayoutControlItem layoutITEM4;
        private DevExpress.XtraLayout.LayoutControlItem layoutITEM5;
        private DevExpress.XtraLayout.EmptySpaceItem emp1;
    }
}