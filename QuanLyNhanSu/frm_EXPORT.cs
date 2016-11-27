using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frm_EXPORT : Form
    {

        GridView grid;
        public frm_EXPORT(GridView grid)
        {
            InitializeComponent();
            this.grid = grid;
        }

        private void btn_EXPORT_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg_save = new SaveFileDialog();
            string file_type = cb_FILE_TYPE.Text;
            dlg_save.Filter =string.Format("(*.{0})|*.{0}",file_type);
            if (dlg_save.ShowDialog() == DialogResult.OK){
                string file_path = dlg_save.FileName;
             
                if (file_type == "Excel")
                {
                    grid.ExportToXls(file_path);
                }

          

            }
            
            
        }
    }
}
