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
    public partial class frm_TON_GIAO : frm_TEMPLATE
    {
        public frm_TON_GIAO()
        {
            InitializeComponent();
            this.Load += frm_TON_GIAO_Load;
        }

        void frm_TON_GIAO_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_RELIGION.Get_Data();
        }
    }
}
