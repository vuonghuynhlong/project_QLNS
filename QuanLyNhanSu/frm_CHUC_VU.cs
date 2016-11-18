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
            this.gv_DATA.DoubleClick += gv_DoubleClick;
        }

        string column_code = "Mã Chức Vụ";
        void gv_DoubleClick(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            string row_code = current_row.Row.ItemArray[0].ToString();
            frm_CHUC_VU_EDIT frm_edit = new frm_CHUC_VU_EDIT(row_code);
            if (frm_edit.ShowDialog() == DialogResult.OK) {
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

        

       
    }
}
