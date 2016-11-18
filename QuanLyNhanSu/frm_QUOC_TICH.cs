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
    public partial class frm_QUOC_TICH : frm_TEMPLATE
    {
        public frm_QUOC_TICH()
        {
            InitializeComponent();
            this.Load += frm_QUOC_TICH_Load;
        }

        void frm_QUOC_TICH_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_NATIONALITY.Get_Data();
        }
    }
}
