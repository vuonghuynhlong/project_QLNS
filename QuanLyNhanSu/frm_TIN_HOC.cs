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
    public partial class frm_TIN_HOC : frm_TEMPLATE
    {
        public frm_TIN_HOC()
        {
            InitializeComponent();
            this.Load += frm_TIN_HOC_Load;
        }

        void frm_TIN_HOC_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_INFORMATIC.Get_Data(); ;
        }
    }
}
