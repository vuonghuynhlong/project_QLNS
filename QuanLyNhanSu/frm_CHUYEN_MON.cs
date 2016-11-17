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
    public partial class frm_CHUYEN_MON : frm_TEMPLATE
    {
        public frm_CHUYEN_MON()
        {
            InitializeComponent();
            this.Load += frm_CHUYEN_MON_Load;

        }

        void frm_CHUYEN_MON_Load(object sender, EventArgs e)
        {
            dg_DATA.DataSource = DAO_DIC_PROFESSIONAL.Get_Data();
        }


    }
}
