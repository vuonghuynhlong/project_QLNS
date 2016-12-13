using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.ENTITY;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace QuanLyNhanSu
{
    public partial class frm_NHAN_VIEN : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_NHAN_VIEN()
        {
            InitializeComponent();
            this.Load += frm_Load;
            this.gv_DATA.DoubleClick += edit_record;
            this.pic_UPDATE.Click += edit_record;
            this.pic_DELETE.Click += delete_record;
            this.pic_INSERT.Click += insert_record;
            this.pic_EXPORT.Click += export_data;
            this.pic_PRINT.Click += pic_PRINT_data;
        }

        private void export_data(object sender, EventArgs e)
        {
            frm_EXPORT frm = new frm_EXPORT(gv_DATA);
            frm.ShowDialog();
        }

        string column_code = "Mã Nhân Viên";
        void edit_record(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            if (current_row == null)
                return;
            string row_code = current_row.Row.ItemArray[1].ToString();
            frm_NHAN_VIEN_EDIT frm_edit = new frm_NHAN_VIEN_EDIT(row_code);
            if (frm_edit.ShowDialog() == DialogResult.OK)
            {
                dg_DATA.DataSource = DAO_HRM_EMPLOYEE.Get_Data();
                int rowHandle = gv_DATA.LocateByValue(column_code, row_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gv_DATA.FocusedRowHandle = rowHandle;
                Grid_Process();
            }
        }
        void Grid_Process() {
            GridView gridView = dg_DATA.FocusedView as GridView;
            gridView.PopulateColumns();
            gridView.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] { 
                  new GridColumnSortInfo(gridView.Columns["Phòng Ban"], DevExpress.Data.ColumnSortOrder.Ascending), 
             }, 2);
            gridView.BestFitColumns();
            gridView.Columns[1].Fixed = FixedStyle.Left;
            gridView.Columns[2].Fixed = FixedStyle.Left;
            gridView.Columns[3].Fixed = FixedStyle.Left;
            gridView.ExpandAllGroups();
        }
        void frm_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_HRM_EMPLOYEE.Get_Data();
            Grid_Process();
           
        }


        void delete_record(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            if (current_row == null)
                return;
            string row_code = current_row.Row.ItemArray[1].ToString();
            DialogResult dlg = XtraMessageBox.Show("Bạn có chắc xóa mã : " + row_code + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlg == DialogResult.Yes)
            {
                int rowHandle = gv_DATA.LocateByValue(column_code, row_code);

                DAO_HRM_EMPLOYEE.Delete(row_code);
                dg_DATA.DataSource = DAO_HRM_EMPLOYEE.Get_Data();

                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gv_DATA.FocusedRowHandle = Math.Min(rowHandle, gv_DATA.DataRowCount - 1);
                Grid_Process();
            }
        }
        void insert_record(object sender, EventArgs e)
        {
            frm_NHAN_VIEN_EDIT frm_edit = new frm_NHAN_VIEN_EDIT(this, true);
            frm_edit.ShowDialog();
            Grid_Process();
        }

        private void gv_DATA_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} ({2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
       
        }

        private void pic_PRINT_data(object sender, EventArgs e)
        {
            frm_QUAN_LY_IN frm_IN = new frm_QUAN_LY_IN(gv_DATA);
            frm_IN.ShowDialog();
        }  
    }
}
