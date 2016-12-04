namespace QuanLyNhanSu
{
    partial class frm_SHOW_PHONG_BAN
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
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_PRINT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(20, 12);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Chọn một phòng ban";
            this.lookUpEdit1.Size = new System.Drawing.Size(252, 20);
            this.lookUpEdit1.TabIndex = 0;
            // 
            // btn_PRINT
            // 
            this.btn_PRINT.Image = global::QuanLyNhanSu.Properties.Resources.PRINT_;
            this.btn_PRINT.Location = new System.Drawing.Point(213, 43);
            this.btn_PRINT.Name = "btn_PRINT";
            this.btn_PRINT.Size = new System.Drawing.Size(59, 23);
            this.btn_PRINT.TabIndex = 1;
            this.btn_PRINT.Text = "In";
            this.btn_PRINT.Click += new System.EventHandler(this.btn_PRINT_Click);
            // 
            // frm_SHOW_PHONG_BAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 75);
            this.Controls.Add(this.btn_PRINT);
            this.Controls.Add(this.lookUpEdit1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SHOW_PHONG_BAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHÒNG BAN";
            this.Load += new System.EventHandler(this.frm_SHOW_PHONG_BAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_PRINT;
    }
}