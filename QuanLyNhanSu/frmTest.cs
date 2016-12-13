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
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

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
            Image img = (Image)QuanLyNhanSu.Properties.Resources.NO_PHOTO;
            byte[] imgbyte = LOGIC_COMMON.Bitmap_To_Byte(img);
            HRM_EMPLOYEE entity = new HRM_EMPLOYEE();
            entity.EmployeeCode = "NV000003";
            entity = DAO_HRM_EMPLOYEE.Select_Record(entity);
            byte[] photo = entity.Photo;
            textEdit1.Text = Get_Day() + "/" + Get_Month() + "/" + Get_Year();
        //    MessageBox.Show("Test");
        }
        public static string Get_Day()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(0, 2);
            return str;
        }
        public static string Get_Month()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(3, 2);
            return str;
        }
        public static string Get_Year()
        {
            string str = DateTime.Now.ToString().Trim();
            str = str.Substring(6, 4);
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
