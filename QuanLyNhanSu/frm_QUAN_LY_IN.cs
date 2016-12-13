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
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyNhanSu
{
    public partial class frm_QUAN_LY_IN : DevExpress.XtraEditors.XtraForm
    {
        GridView gv_DATA;
        public frm_QUAN_LY_IN(GridView grid)
        {
            InitializeComponent();
            this.gv_DATA = grid;
        }

        private void tree_HS_NHAN_VIEN_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_PREVIEW_Click(object sender, EventArgs e)
        {
            string node_text = tree_HS_NHAN_VIEN.SelectedNode.Text;
            
            if (node_text == "In nhân viên được chọn")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();
                ReportPrintTool printTool;
                REPORT.DANH_SACH_TUNG_NHAN_VIEN rpt = new REPORT.DANH_SACH_TUNG_NHAN_VIEN();
                rpt.FilterString = "[EmployeeCode] = '" + row_code + "'";
                printTool = new ReportPrintTool(rpt);
              
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }

            if (node_text == "Danh sách tất cả nhân viên")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();
                ReportPrintTool printTool;
                REPORT.DANH_SACH_NHAN_VIEN rpt = new REPORT.DANH_SACH_NHAN_VIEN();
                printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }

            if (node_text == "Danh sách nhân viên đang làm")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();
                ReportPrintTool printTool;
                REPORT.DANH_SACH_NHAN_VIEN rpt = new REPORT.DANH_SACH_NHAN_VIEN();
                rpt.FilterString = "[WorkStateCode] IN ('TT000001', 'TT000003')";
                rpt.xr_TITLE.Text = rpt.xr_TITLE.Text  + " ĐANG LÀM";
                printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);

            }

            if (node_text == "Danh sách nhân viên nghỉ làm")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();
                ReportPrintTool printTool;
                REPORT.DANH_SACH_NHAN_VIEN rpt = new REPORT.DANH_SACH_NHAN_VIEN();
                rpt.xr_TITLE.Text = rpt.xr_TITLE.Text + " NGHỈ LÀM";
                rpt.FilterString = "[WorkStateCode] IN ('TT000004')";
                printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);

            }

            if (node_text == "Danh sách nhân viên theo phòng ban")
            {
                frm_SHOW_PHONG_BAN frm = new frm_SHOW_PHONG_BAN();
                frm.ShowDialog();
            }

            if (node_text == "In hợp đồng tất cả nhân viên")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();
                ReportPrintTool printTool;
                REPORT.HOP_DONG_LAO_DONG rpt = new REPORT.HOP_DONG_LAO_DONG();
                printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }

            if (node_text == "In hợp đồng nhân viên được chọn")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();

                ReportPrintTool printTool;
                REPORT.HOP_DONG_LAO_DONG rpt = new REPORT.HOP_DONG_LAO_DONG();
                rpt.FilterString = "[EmployeeCode] = '" + row_code + "'";
                printTool = new ReportPrintTool(rpt);
                printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }

            if (node_text == "In hợp đồng tất cả nhân viên")
            {
                DataRowView current_row = (DataRowView)gv_DATA.GetFocusedRow();
                if (current_row == null)
                    return;
                string row_code = current_row.Row.ItemArray[1].ToString();
                ReportPrintTool printTool;
                REPORT.HOP_DONG_LAO_DONG rpt = new REPORT.HOP_DONG_LAO_DONG();
                printTool = new ReportPrintTool(rpt);
            }

            
        }

        private void frm_QUAN_LY_IN_Load(object sender, EventArgs e)
        {
            tree_HS_NHAN_VIEN.ExpandAll();
        }

        private void btn_QUIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}