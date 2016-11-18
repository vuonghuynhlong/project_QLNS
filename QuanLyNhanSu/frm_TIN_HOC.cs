﻿using System;
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
namespace QuanLyNhanSu
{
    public partial class frm_TIN_HOC : frm_TEMPLATE
    {
        public frm_TIN_HOC()
        {
            InitializeComponent();
            this.Load += frm_Load;
            this.gv_DATA.DoubleClick += edit_record;
            this.pic_UPDATE.Click += edit_record;
            this.pic_DELETE.Click += delete_record;
        }

        string column_code = "Mã Bằng Tin Học";
        void edit_record(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            if (current_row == null)
                return;
            string row_code = current_row.Row.ItemArray[0].ToString();
            frm_TIN_HOC_EDIT frm_edit = new frm_TIN_HOC_EDIT(row_code);
            if (frm_edit.ShowDialog() == DialogResult.OK)
            {
                dg_DATA.DataSource = DAO_DIC_INFORMATIC.Get_Data();
                int rowHandle = gv_DATA.LocateByValue(column_code, row_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gv_DATA.FocusedRowHandle = rowHandle;
            }
        }
        void frm_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_INFORMATIC.Get_Data(); ;
        }

        void delete_record(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            if (current_row == null)
                return;
            string row_code = current_row.Row.ItemArray[0].ToString();
            DialogResult dlg = XtraMessageBox.Show("Bạn có chắc xóa mã : " + row_code + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlg == DialogResult.Yes)
            {
                int rowHandle = gv_DATA.LocateByValue(column_code, row_code);

                DAO_DIC_INFORMATIC.Delete(row_code);
                dg_DATA.DataSource = DAO_DIC_INFORMATIC.Get_Data();

                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gv_DATA.FocusedRowHandle = rowHandle;
            }
        }
    }
}
