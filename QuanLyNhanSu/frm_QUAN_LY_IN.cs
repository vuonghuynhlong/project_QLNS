using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

namespace QuanLyNhanSu
{
    public partial class frm_QUAN_LY_IN : DevExpress.XtraEditors.XtraForm
    {
        public frm_QUAN_LY_IN()
        {
            InitializeComponent();
        }

        private void tree_HS_NHAN_VIEN_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_PREVIEW_Click(object sender, EventArgs e)
        {
            string node_text = tree_HS_NHAN_VIEN.SelectedNode.Text;
            if (node_text == "Danh sách nhân viên nghỉ làm")
            {
                //ReportPrintTool printTool;
                //REPORT.RPT_DANH_SACH_NHAN_VIEN rpt = new REPORT.RPT_DANH_SACH_NHAN_VIEN();
                //printTool = new ReportPrintTool(rpt);
                //printTool.ShowPreviewDialog();
                //printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }
             if (node_text == "Danh sách nhân viên theo phòng ban")
            {
                frm_SHOW_PHONG_BAN frm = new frm_SHOW_PHONG_BAN();
                frm.ShowDialog();
            }


          


            
        }
    }
}