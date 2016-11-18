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
    public partial class frm_DANH_SACH_NHAN_VIEN : frm_TEMPLATE
    {
        public frm_DANH_SACH_NHAN_VIEN()
        {
            InitializeComponent();
            this.Load+=frm_DANH_SACH_NHAN_VIEN_Load;
        }

        private void frm_DANH_SACH_NHAN_VIEN_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_HRM_EMPLOYEE.Get_Data();
        }
    }
}
