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
            Image img = (Image)QuanLyNhanSu.Properties.Resources.NO_PHOTO;
            byte[] imgbyte = LOGIC_COMMON.Bitmap_To_Byte(img);
            HRM_EMPLOYEE entity = new HRM_EMPLOYEE();
            entity.EmployeeCode = "NV000003";
            entity = DAO_HRM_EMPLOYEE.Select_Record(entity);
            byte[] photo = entity.Photo;
         
        //    MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = pictureEdit1.Image;
            byte[] abc = LOGIC_COMMON.Bitmap_To_Byte(img);
            MessageBox.Show("Test");
        }
    }
}
