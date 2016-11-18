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
    public partial class frm_DAN_TOC : frm_TEMPLATE
    {
        public frm_DAN_TOC()
        {
            InitializeComponent();
            this.Load += frm_DAN_TOC_Load;
        }

        void frm_DAN_TOC_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_ETHNIC.Get_Data();
        }
    }
}
