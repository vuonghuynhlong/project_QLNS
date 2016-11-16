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
            //ENTITY.DIC_DEGREE entity = new ENTITY.DIC_DEGREE();
            //entity.DegreeCode = "BC000001";
            //entity = DAO_DIC_DEGREE.Select_Record(entity);
            //MessageBox.Show(entity.DegreeCode+"    sss" + entity.DegreeName);

            //ENTITY.DIC_EDUCATION entity = new ENTITY.DIC_EDUCATION();
            //entity.EducationCode = "HV000001";
            //entity = DAO_DIC_EDUCATION.Select_Record(entity);
            //MessageBox.Show(entity.EducationName);

            //ENTITY.DIC_ETHNIC entity = new ENTITY.DIC_ETHNIC();
            //entity.EthnicCode = "DT000001";
            //entity = DAO_DIC_ETHNIC.Select_Record(entity);
            //MessageBox.Show(entity.EthnicName);

            //ENTITY.DIC_INFORMATIC entity = new ENTITY.DIC_INFORMATIC();
            //entity.InformaticCode = "TH000001";
            //entity = DAO_DIC_INFORMATIC.Select_Record(entity);
            //MessageBox.Show(entity.InformaticName);

            //ENTITY.DIC_LANGUAGE entity = new ENTITY.DIC_LANGUAGE();
            //entity.LanguageCode = "NN000001";
            //entity = DAO_DIC_LANGUAGE.Select_Record(entity);
            //MessageBox.Show(entity.LanguageName);

            ENTITY.DIC_POSITION entity = new ENTITY.DIC_POSITION();
            entity.PositionCode = "CV000001";
            entity = DAO_DIC_POSITION.Select_Record(entity);
            MessageBox.Show(entity.PositionName);
        }

        public ENTITY.DIC_EDUCATION DAO_ { get; set; }

        public ENTITY.DIC_EDUCATION DAO_DIC { get; set; }
    }
}
