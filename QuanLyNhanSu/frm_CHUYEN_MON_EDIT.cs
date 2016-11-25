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
using DevExpress.XtraLayout;
using QuanLyNhanSu.LOGIC;
using DevExpress.XtraEditors;

namespace QuanLyNhanSu
{

    public partial class frm_CHUYEN_MON_EDIT : QuanLyNhanSu.frm_TEMPLATE_EDIT
    {
        string CODE;
        DIC_PROFESSIONAL old_entity;
        DIC_PROFESSIONAL new_entity;
        public frm_CHUYEN_MON_EDIT(string code)
        {
            InitializeComponent();
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;
            CODE = code;

            LayoutControlItem item_insert_continue = layout_CONTROL.GetItemByControl(btn_INSERT_CONTINUE);
            LayoutControlItem item_insert = layout_CONTROL.GetItemByControl(btn_INSERT);
            item_insert_continue.Parent.Remove(item_insert_continue);
            item_insert.Parent.Remove(item_insert);

        }

        private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_PROFESSIONAL();
            old_entity.ProfessionalCode = CODE;
            old_entity = DAO_DIC_PROFESSIONAL.Select_Record(old_entity);
            txt_PROFESSIONAL_CODE.Text = old_entity.ProfessionalCode;
            txt_PROFESSIONAL_NAME.Text = old_entity.ProfessionalName;
            txt_DESCRIPTION.Text = old_entity.Description;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_PROFESSIONAL();
            new_entity.ProfessionalCode = txt_PROFESSIONAL_CODE.Text;
            new_entity.ProfessionalName = txt_PROFESSIONAL_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Active = old_entity.Active;

            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if (validate.Status)
            {

                DAO_DIC_PROFESSIONAL.Update(old_entity, new_entity);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Loi");
            }
           
           
        }

        // BEGIN INSERT BEGIN INSERT BEGIN INSERT BEGIN INSERT BEGIN INSERT 

        frm_CHUYEN_MON parent = null;
        public frm_CHUYEN_MON_EDIT(frm_CHUYEN_MON parent_frm, bool is_insert)
            : base(is_insert)
        {
            InitializeComponent();

            Init_Data();

            this.btn_INSERT_CONTINUE.Click += insert_record_continue;
            this.btn_INSERT.Click          += insert_record;

            parent = parent_frm;


        }

    
        private void Init_Data()
        {
            txt_PROFESSIONAL_CODE.Text = LOGIC_COMMON.Generate_Code("CM");
            txt_PROFESSIONAL_NAME.Text = string.Empty;
            txt_DESCRIPTION.Text = string.Empty;
           
            
        }
        private bool Insert()
        {
            new_entity = new DIC_PROFESSIONAL();
            new_entity.ProfessionalCode = txt_PROFESSIONAL_CODE.Text;
            new_entity.ProfessionalName = txt_PROFESSIONAL_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Active = true;

            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if (validate.Status)
            {

                DAO_DIC_PROFESSIONAL.Add(new_entity);
                if (parent != null)
                    parent.dg_DATA.DataSource = DAO_DIC_PROFESSIONAL.Get_Data();
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Loi");
                return false;
            }
            return true;
           

        }
        private void insert_record(object sender, EventArgs e)
        {
            if (Insert())
            this.Close();
        }

        private void insert_record_continue(object sender, EventArgs e)
        {
            if (Insert())
            Init_Data();

        }
       

        // END INSERT END INSERT END INSERT END INSERT END INSERT END INSERT
    }
}
