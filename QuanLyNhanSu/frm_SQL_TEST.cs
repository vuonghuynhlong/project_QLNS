using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
namespace QuanLyNhanSu
{
    public partial class frm_SQL_TEST : Form
    {
        public frm_SQL_TEST()
        {
            InitializeComponent();
        }

        private void frm_SQL_TEST_Load(object sender, EventArgs e)
        {
            ENTITY.DIC_DEGREE entity = new ENTITY.DIC_DEGREE();
            entity.DegreeCode = "BC000001";
            entity = DAO_DIC_DEGREE.Select_Record(entity);
            MessageBox.Show(entity.DegreeCode+"    sss" + entity.DegreeName);

        }
    }
}
