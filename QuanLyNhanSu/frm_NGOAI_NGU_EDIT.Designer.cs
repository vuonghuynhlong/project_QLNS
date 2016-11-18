namespace QuanLyNhanSu
{
    partial class frm_NGOAI_NGU_EDIT
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
            this.txt_DESCRIPTION = new DevExpress.XtraEditors.TextEdit();
            this.txt_LANGUAGE_NAME = new DevExpress.XtraEditors.TextEdit();
            this.txt_LANGUAGE_CODE = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.group_PARENT)).BeginInit();
            this.group_PARENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).BeginInit();
            this.layout_CONTROL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CONTROLS)).BeginInit();
            this.panel_CONTROLS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DESCRIPTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LANGUAGE_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LANGUAGE_CODE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_PARENT
            // 
            this.group_PARENT.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.group_PARENT.AppearanceCaption.Options.UseFont = true;
            this.group_PARENT.Size = new System.Drawing.Size(314, 186);
            // 
            // layout_CONTROL
            // 
            this.layout_CONTROL.Size = new System.Drawing.Size(310, 164);
            this.layout_CONTROL.Controls.SetChildIndex(this.panel_CONTROLS, 0);
            this.layout_CONTROL.Controls.SetChildIndex(this.btn_SAVE, 0);
            // 
            // layout_GROUP
            // 
            this.layout_GROUP.Size = new System.Drawing.Size(310, 164);
            // 
            // panel_CONTROLS
            // 
            this.panel_CONTROLS.Controls.Add(this.layoutControl1);
            this.panel_CONTROLS.Size = new System.Drawing.Size(304, 124);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Size = new System.Drawing.Size(308, 128);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_SAVE.Appearance.Options.UseFont = true;
            this.btn_SAVE.Location = new System.Drawing.Point(230, 131);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_DESCRIPTION);
            this.layoutControl1.Controls.Add(this.txt_LANGUAGE_NAME);
            this.layoutControl1.Controls.Add(this.txt_LANGUAGE_CODE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.AllowHotTrack = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(300, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_DESCRIPTION
            // 
            this.txt_DESCRIPTION.Location = new System.Drawing.Point(78, 52);
            this.txt_DESCRIPTION.Name = "txt_DESCRIPTION";
            this.txt_DESCRIPTION.Size = new System.Drawing.Size(218, 20);
            this.txt_DESCRIPTION.StyleController = this.layoutControl1;
            this.txt_DESCRIPTION.TabIndex = 6;
            // 
            // txt_LANGUAGE_NAME
            // 
            this.txt_LANGUAGE_NAME.Location = new System.Drawing.Point(78, 28);
            this.txt_LANGUAGE_NAME.Name = "txt_LANGUAGE_NAME";
            this.txt_LANGUAGE_NAME.Size = new System.Drawing.Size(218, 20);
            this.txt_LANGUAGE_NAME.StyleController = this.layoutControl1;
            this.txt_LANGUAGE_NAME.TabIndex = 5;
            // 
            // txt_LANGUAGE_CODE
            // 
            this.txt_LANGUAGE_CODE.Location = new System.Drawing.Point(78, 4);
            this.txt_LANGUAGE_CODE.Name = "txt_LANGUAGE_CODE";
            this.txt_LANGUAGE_CODE.Size = new System.Drawing.Size(218, 20);
            this.txt_LANGUAGE_CODE.StyleController = this.layoutControl1;
            this.txt_LANGUAGE_CODE.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(300, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_LANGUAGE_CODE;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem2.Text = "Mã Ngoại Ngữ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_LANGUAGE_NAME;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem3.Text = "Tên Ngoại Ngữ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_DESCRIPTION;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(296, 24);
            this.layoutControlItem4.Text = "Mô Tả\r\n";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(71, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(296, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_NGOAI_NGU_EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 186);
            this.Name = "frm_NGOAI_NGU_EDIT";
            this.Text = "CẬP NHẬT NGOẠI NGỮ";
            ((System.ComponentModel.ISupportInitialize)(this.group_PARENT)).EndInit();
            this.group_PARENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout_CONTROL)).EndInit();
            this.layout_CONTROL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layout_GROUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CONTROLS)).EndInit();
            this.panel_CONTROLS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DESCRIPTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LANGUAGE_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LANGUAGE_CODE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txt_DESCRIPTION;
        private DevExpress.XtraEditors.TextEdit txt_LANGUAGE_NAME;
        private DevExpress.XtraEditors.TextEdit txt_LANGUAGE_CODE;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}