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
using QuanLyNhanSu.ENTITY;
using QuanLyNhanSu.LOGIC;
namespace QuanLyNhanSu
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            //DataTable dt = DAO_DIC_RELIGION.Get_Data();
           
            //lookUpEdit1.Properties.DataSource = dt;
            //lookUpEdit1.Properties.DisplayMember = "Tên Tôn Giáo";
            //lookUpEdit1.Properties.ValueMember = "Mã Tôn Giáo";
            //lookUpEdit1.EditValue = "TG000004";
            //lookUpEdit1.Properties.PopulateColumns();
            //lookUpEdit1.Properties.Columns["Mô Tả"].Visible = false;
         //   LOGIC_COMMON.Init_Lookup_Edit_DataSource(lookUpEdit1, DAO_DIC_RELIGION.Get_Data(), "Mã Tôn Giáo", "Tên Tôn Giáo", new String[] { "Mô Tả" });
        
        }
    }
}
