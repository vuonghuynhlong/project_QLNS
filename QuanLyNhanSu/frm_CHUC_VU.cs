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
            this.Load += frm_CHUC_VU_Load;
            this.gv_DATA.DoubleClick += gv_DATA_DoubleClick;
        }

        void gv_DATA_DoubleClick(object sender, EventArgs e)
        {
            DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
            string row_code = current_row.Row.ItemArray[0].ToString();
            
        }

        void frm_CHUC_VU_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_POSITION.Get_Data();
        }

        

       
    }
}
