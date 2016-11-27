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
namespace QuanLyNhanSu
{
    public partial class frm_CHUC_VU : frm_TEMPLATE
    {
        public frm_CHUC_VU()
        {
            InitializeComponent();
            this.Load += frm_Load;
            this.gv_DATA.DoubleClick += edit_record;
            this.pic_UPDATE.Click += edit_record;
            this.pic_DELETE.Click += delete_record;
            this.pic_INSERT.Click += insert_record;
            this.pic_EXPORT.Click += export_data;
        }

        private void export_data(object sender, EventArgs e)
        {
            frm_EXPORT frm = new frm_EXPORT(gv_DATA);
            frm.ShowDialog();
        }

       

        string column_code = "Mã Chức Vụ";
        void edit_record(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            if (current_row == null)
                return;
            string row_code = current_row.Row.ItemArray[0].ToString();
            frm_CHUC_VU_EDIT frm_edit = new frm_CHUC_VU_EDIT(row_code);
            if (frm_edit.ShowDialog() == DialogResult.OK)
            {
                dg_DATA.DataSource = DAO_DIC_POSITION.Get_Data();
                int rowHandle = gv_DATA.LocateByValue(column_code, row_code);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gv_DATA.FocusedRowHandle = rowHandle;
            }
        }

        void frm_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_POSITION.Get_Data();
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

                DAO_DIC_POSITION.Delete(row_code);
                dg_DATA.DataSource = DAO_DIC_POSITION.Get_Data();
              
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gv_DATA.FocusedRowHandle = Math.Min(rowHandle, gv_DATA.DataRowCount - 1);
            }
        }

        void insert_record(object sender, EventArgs e)
        {
            frm_CHUC_VU_EDIT frm_edit = new frm_CHUC_VU_EDIT(this,true);
            frm_edit.ShowDialog();
        }
       
    }
}
