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
    public partial class frm_HOC_VAN : frm_TEMPLATE
    {
        public frm_HOC_VAN()
        {
            InitializeComponent();
            this.Load += frm_HOC_VAN_Load;
        }

        void frm_HOC_VAN_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_EDUCATION.Get_Data();
        }
    }
}
