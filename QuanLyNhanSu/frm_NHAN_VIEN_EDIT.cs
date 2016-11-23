using DevExpress.XtraLayout;
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
using DevExpress.XtraEditors;
namespace QuanLyNhanSu
{
    public partial class frm_NHAN_VIEN_EDIT : Form
    {
        string CODE;
        HRM_EMPLOYEE old_entity;
        HRM_EMPLOYEE new_entity;
        //DataTable dt_RELIGION = null;
        private void Init_Reference_Data(){

            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_RELIGION, DAO_DIC_RELIGION.Get_View_Data(), "Mã Tôn Giáo", "Tên Tôn Giáo");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_NATIONALITY, DAO_DIC_NATIONALITY.Get_View_Data(), "Mã Quốc Tịch", "Tên Quốc Tịch");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_ETHNIC, DAO_DIC_ETHNIC.Get_View_Data(), "Mã Dân Tộc", "Tên Dân Tộc");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_LANGUAGE, DAO_DIC_LANGUAGE.Get_View_Data(), "Mã Ngôn Ngữ", "Tên Ngôn Ngữ");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_INFORMATIC, DAO_DIC_INFORMATIC.Get_View_Data(), "Mã Bằng Tin Học", "Tên Bằng Tin Học");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_PROFESSIONAL, DAO_DIC_PROFESSIONAL.Get_View_Data(), "Mã Chuyên Môn", "Tên Chuyên Môn");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_SCHOOL, DAO_DIC_SCHOOL.Get_View_Data(), "Mã Trường", "Tên Trường");
            LOGIC_COMMON.Init_Lookup_Edit_DataSource(cbo_EDUCATION, DAO_DIC_EDUCATION.Get_View_Data(), "Mã Học Vấn", "Tên Học Vấn");
        }
        public frm_NHAN_VIEN_EDIT(string code)
        {
            InitializeComponent();
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;

            Init_Reference_Data();
            CODE = code;
            // BEGIN EDIT BEGIN EDIT BEGIN EDIT BEGIN EDIT
            LayoutControlItem item_insert_continue = layout_CONTROL.GetItemByControl(btn_INSERT_CONTINUE);
            LayoutControlItem item_insert = layout_CONTROL.GetItemByControl(btn_INSERT);
            item_insert_continue.Parent.Remove(item_insert_continue);
            item_insert.Parent.Remove(item_insert);
            // END EDIT END EDIT END EDIT END EDIT END EDIT END EDIT
        }

         private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new HRM_EMPLOYEE();

            old_entity.EmployeeCode = CODE;
            old_entity = DAO_HRM_EMPLOYEE.Select_Record(old_entity);
            txt_EMPLOYEE_CODE.Text = old_entity.EmployeeCode;
            txt_FIRST_NAME.Text = old_entity.FirstName;
            txt_LAST_NAME.Text = old_entity.LastName;
            txt_ALIAS.Text = old_entity.Alias;
            bool sex = (bool) old_entity.Sex;

            chk_SEX.Checked = sex;
            date_BIRTHDAY.DateTime =(DateTime) old_entity.Birthday;
            txt_BIRTH_PLACE.Text = old_entity.BirthPlace;
            txt_ALIAS.Text = old_entity.Alias;
            cbo_MARRIAGE.Text = old_entity.Marriage;
            txt_IDCARD.Text = old_entity.IDCard;
            date_IDCARD.DateTime = (DateTime)old_entity.IDCardDate;
            txt_IDCARD_PLACE.Text = old_entity.IDCardPlace;
            txt_MAIN_ADDRESS.Text = old_entity.MainAddress;
            txt_CONTACT_ADDRESS.Text = old_entity.ContactAddress;
            txt_CELL_PHONE.Text = old_entity.CellPhone;
            txt_EMAIL.Text = old_entity.Email;
            cbo_NATIONALITY.EditValue = old_entity.Nationality;
            cbo_ETHNIC.EditValue = old_entity.Ethnic;
            cbo_RELIGION.EditValue = old_entity.Religion;
            cbo_EDUCATION.EditValue = old_entity.Education;
            cbo_LANGUAGE.EditValue = old_entity.Language;
            cbo_INFORMATIC.EditValue = old_entity.Informatic;
            cbo_PROFESSIONAL.EditValue = old_entity.Professional;
          //  cbo_DEGREE.Text = old_entity.Degree;
            cbo_SCHOOL.EditValue = old_entity.School;
            //cbo_TRANG_THAI_NHAN_VIEN.Text = old_entity.



            //txt_LANGUAGE_CODE.Text = old_entity.EmployeeCode;
            //txt_LANGUAGE_NAME.Text = old_entity.LanguageName;
            //txt_DESCRIPTION.Text = old_entity.Description;
           
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new HRM_EMPLOYEE();
            new_entity.EmployeeCode = txt_EMPLOYEE_CODE.Text;
            new_entity.FirstName = txt_FIRST_NAME.Text;
            new_entity.LastName = txt_LAST_NAME.Text;
            new_entity.Sex = chk_SEX.Checked;
            new_entity.Birthday = date_BIRTHDAY.DateTime;
            new_entity.BirthPlace = txt_BIRTH_PLACE.Text;
            new_entity.Alias = txt_ALIAS.Text;
            new_entity.Marriage = cbo_MARRIAGE.Text;
            new_entity.IDCard = txt_IDCARD.Text;

            new_entity.IDCardDate = date_IDCARD.DateTime;
            new_entity.IDCardPlace = txt_IDCARD_PLACE.Text;
            new_entity.MainAddress = txt_MAIN_ADDRESS.Text;
            new_entity.ContactAddress = txt_CONTACT_ADDRESS.Text;
            new_entity.CellPhone = txt_CELL_PHONE.Text;
            new_entity.Email = txt_EMAIL.Text;
            new_entity.Nationality = cbo_NATIONALITY.EditValue.ToString();
            new_entity.Religion = (cbo_RELIGION.EditValue == null ?  null : cbo_RELIGION.EditValue.ToString());
            new_entity.Ethnic = cbo_ETHNIC.EditValue.ToString();
            new_entity.Education = cbo_EDUCATION.EditValue.ToString();
            new_entity.Language = cbo_LANGUAGE.EditValue.ToString();
            new_entity.Informatic = (cbo_INFORMATIC.EditValue== null ? null : cbo_INFORMATIC.EditValue.ToString());
            new_entity.Professional = cbo_PROFESSIONAL.EditValue.ToString();
            new_entity.School = (cbo_SCHOOL.EditValue == null ? null : cbo_SCHOOL.EditValue.ToString());
            //new_entity.EmployeeCode = txt_LANGUAGE_CODE.Text;
            //new_entity.LanguageName = txt_LANGUAGE_NAME.Text;
            //new_entity.Description = txt_DESCRIPTION.Text;
            //new_entity.Active = old_entity.Active;
            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if (validate.Status)
            {
                DAO_HRM_EMPLOYEE.Update(old_entity, new_entity);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Lỗi.!!!");
            }
            this.DialogResult = DialogResult.OK;
        }
        // BEGIN INSERT BEGIN INSERT BEGIN INSERT BEGIN INSERT BEGIN INSERT 

        frm_NHAN_VIEN parent = null;
        public frm_NHAN_VIEN_EDIT(frm_NHAN_VIEN parent_frm, bool is_insert)
        {
            InitializeComponent();

            Init_Data();

            this.btn_INSERT_CONTINUE.Click += insert_record_continue;
            this.btn_INSERT.Click += insert_record;

            parent = parent_frm;


        }

    
        private void Init_Data()
        {
           // txt_LANGUAGE_CODE.Text = LOGIC_COMMON.Generate_Code("NN");
           // txt_LANGUAGE_NAME.Text = string.Empty;
           // txt_DESCRIPTION.Text = string.Empty;
           //// chk_IS_MANAGER.Checked = false;
            
        }
        private void Insert()
        {
            new_entity = new HRM_EMPLOYEE();
            //new_entity.EmployeeCode = txt_LANGUAGE_CODE.Text;
            //new_entity.LanguageName = txt_LANGUAGE_NAME.Text;
            //new_entity.Description = txt_DESCRIPTION.Text;
            //new_entity.IsManager = chk_IS_MANAGER.Checked;
            //new_entity.Active = true;
            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if(validate.Status)
            {
                DAO_HRM_EMPLOYEE.Add(new_entity);
                //parent.dg_DATA.DataSource = DAO_HRM_EMPLOYEE.Get_Data();
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Lỗi.!!!");
            }

        }
        private void insert_record(object sender, EventArgs e)
        {
            Insert();
            this.Close();
        }

        private void insert_record_continue(object sender, EventArgs e)
        {
            Insert();
            Init_Data();

        }

        private void btn_frm_QUOC_TICH_Click(object sender, EventArgs e)
        {
            frm_QUOC_TICH_EDIT frm_QT = new frm_QUOC_TICH_EDIT(null,true);
            frm_QT.ShowDialog();
            Init_Reference_Data();
        }

        private void btn_frm_TON_GIAO_Click(object sender, EventArgs e)
        {
            frm_TON_GIAO_EDIT frm_TG = new frm_TON_GIAO_EDIT(null, true);
            frm_TG.ShowDialog();
            Init_Reference_Data();
        }

        private void btn_frm_NGOAI_NGU_Click(object sender, EventArgs e)
        {
            frm_NGOAI_NGU_EDIT frm_NN = new frm_NGOAI_NGU_EDIT(null, true);
            frm_NN.ShowDialog();
            Init_Reference_Data();
        }

        private void btn_frm_CHUYEN_MON_Click(object sender, EventArgs e)
        {
            frm_CHUYEN_MON_EDIT frm_CM = new frm_CHUYEN_MON_EDIT(null, true);
            frm_CM.ShowDialog();
            Init_Reference_Data();
        }

        private void btn_frm_DAN_TOC_Click(object sender, EventArgs e)
        {
            frm_DAN_TOC_EDIT frm_DT = new frm_DAN_TOC_EDIT(null, true);
            frm_DT.ShowDialog();
            Init_Reference_Data();
        }

        private void btn_frm_HOC_VAN_Click(object sender, EventArgs e)
        {
            frm_HOC_VAN_EDIT frm_HV = new frm_HOC_VAN_EDIT(null, true);
            frm_HV.ShowDialog();
            Init_Reference_Data();
        }

        private void btn_frm_TIN_HOC_Click(object sender, EventArgs e)
        {
            frm_TIN_HOC_EDIT frm_TH = new frm_TIN_HOC_EDIT(null, true);
            frm_TH.ShowDialog();
            Init_Reference_Data();
        }
       

        // END INSERT END INSERT END INSERT END INSERT END INSERT END INSERT
    }
}
