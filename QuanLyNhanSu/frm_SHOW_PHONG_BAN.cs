using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frm_SHOW_PHONG_BAN : DevExpress.XtraEditors.XtraForm
    {
        public frm_SHOW_PHONG_BAN()
        {
            InitializeComponent();
        }

        private void frm_SHOW_PHONG_BAN_Load(object sender, EventArgs e)
        {
           DataTable dt =  DAO.DAO_DIC_DEPARTMENT.Get_View_Data();
           lookUpEdit1.Properties.DataSource = dt;
           lookUpEdit1.Properties.DisplayMember = "Tên Phòng Ban";
           lookUpEdit1.Properties.ValueMember = "Mã Phòng Ban";
        }

        private void btn_PRINT_Click(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn phòng ban !!");
            }
            else
            {
                ReportPrintTool printTool;
                REPORT.DANH_SACH_NHAN_VIEN rpt = new REPORT.DANH_SACH_NHAN_VIEN();
                rpt.FilterString = "[DepartmentCode] = '" + lookUpEdit1.EditValue.ToString() + "'";
                printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }
            
        }
    }
}
