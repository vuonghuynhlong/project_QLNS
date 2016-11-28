﻿namespace QuanLyNhanSu
{
    partial class frm_QUAN_LY_IN
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Danh sách tất cả nhân viên");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Danh sách nhân viên theo phòng ban");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Danh sách nhân viên được chọn");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Danh sách nhân viên đang làm");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Danh sách nhân viên nghỉ làm");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Hồ sơ nhân viên", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_PREVIEW = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QUIT = new DevExpress.XtraEditors.SimpleButton();
            this.tree_HS_NHAN_VIEN = new System.Windows.Forms.TreeView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_PREVIEW);
            this.layoutControl1.Controls.Add(this.btn_QUIT);
            this.layoutControl1.Controls.Add(this.tree_HS_NHAN_VIEN);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(779, 196, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(389, 179);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_PREVIEW
            // 
            this.btn_PREVIEW.Image = global::QuanLyNhanSu.Properties.Resources.LOOK;
            this.btn_PREVIEW.Location = new System.Drawing.Point(204, 145);
            this.btn_PREVIEW.Name = "btn_PREVIEW";
            this.btn_PREVIEW.Size = new System.Drawing.Size(84, 22);
            this.btn_PREVIEW.StyleController = this.layoutControl1;
            this.btn_PREVIEW.TabIndex = 6;
            this.btn_PREVIEW.Text = "Xem trước";
            this.btn_PREVIEW.Click += new System.EventHandler(this.btn_PREVIEW_Click);
            // 
            // btn_QUIT
            // 
            this.btn_QUIT.Image = global::QuanLyNhanSu.Properties.Resources.QUIT2;
            this.btn_QUIT.Location = new System.Drawing.Point(302, 145);
            this.btn_QUIT.Name = "btn_QUIT";
            this.btn_QUIT.Size = new System.Drawing.Size(75, 22);
            this.btn_QUIT.StyleController = this.layoutControl1;
            this.btn_QUIT.TabIndex = 5;
            this.btn_QUIT.Text = "Đóng";
            // 
            // tree_HS_NHAN_VIEN
            // 
            this.tree_HS_NHAN_VIEN.Location = new System.Drawing.Point(12, 12);
            this.tree_HS_NHAN_VIEN.Name = "tree_HS_NHAN_VIEN";
            treeNode7.Name = "Node_DS_TAT_CA_NHAN_VIEN";
            treeNode7.Text = "Danh sách tất cả nhân viên";
            treeNode8.Name = "Node_DS_NHAN_VIEN_THEO_PHONG_BAN";
            treeNode8.Text = "Danh sách nhân viên theo phòng ban";
            treeNode9.Name = "Node_DS_NHAN_VIEN_DUOC_CHON";
            treeNode9.Text = "Danh sách nhân viên được chọn";
            treeNode10.Name = "Node_DS_NHAN_VIEN_DANG_LAM";
            treeNode10.Text = "Danh sách nhân viên đang làm";
            treeNode11.Name = "Node_DS_NHAN_VIEN_DANG_LAM";
            treeNode11.Text = "Danh sách nhân viên nghỉ làm";
            treeNode12.Name = "Node_HS_NHAN_VIEN";
            treeNode12.Text = "Hồ sơ nhân viên";
            this.tree_HS_NHAN_VIEN.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.tree_HS_NHAN_VIEN.Size = new System.Drawing.Size(365, 119);
            this.tree_HS_NHAN_VIEN.TabIndex = 4;
            this.tree_HS_NHAN_VIEN.Click += new System.EventHandler(this.tree_HS_NHAN_VIEN_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(389, 179);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tree_HS_NHAN_VIEN;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(369, 123);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_QUIT;
            this.layoutControlItem2.Location = new System.Drawing.Point(290, 133);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(79, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_PREVIEW;
            this.layoutControlItem3.Location = new System.Drawing.Point(192, 133);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(88, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 133);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(192, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(280, 133);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 123);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(369, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_QUAN_LY_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 179);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_QUAN_LY_IN";
            this.Text = "TÙY CHỌN IN";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.TreeView tree_HS_NHAN_VIEN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btn_PREVIEW;
        private DevExpress.XtraEditors.SimpleButton btn_QUIT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}