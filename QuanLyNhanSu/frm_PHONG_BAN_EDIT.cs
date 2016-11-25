using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.ENTITY;
using QuanLyNhanSu.LOGIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frm_PHONG_BAN_EDIT : QuanLyNhanSu.frm_TEMPLATE_EDIT
    {
        string CODE;
        DIC_DEPARTMENT old_entity;
        DIC_DEPARTMENT new_entity;
        public frm_PHONG_BAN_EDIT(string code)
        {
            InitializeComponent();
            CODE = code;
            this.Load+=frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;
            LayoutControlItem item_insert_continue = layout_CONTROL.GetItemByControl(btn_INSERT_CONTINUE);
            LayoutControlItem item_insert = layout_CONTROL.GetItemByControl(btn_INSERT);
            item_insert_continue.Parent.Remove(item_insert_continue);
            item_insert.Parent.Remove(item_insert);

        }

        private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_DEPARTMENT();

            old_entity.DepartmentCode = CODE;
            old_entity = DAO_DIC_DEPARTMENT.Select_Record(old_entity);
            txt_DEPARTMENT_CODE.Text = old_entity.DepartmentCode;
            txt_DEPARTMENT_NAME.Text = old_entity.DepartmentName;
            txt_DESCRIPTION.Text = old_entity.Description;
            txt_PHONE.Text = old_entity.Phone;
            txt_QUANLITY.Text = old_entity.Quantity.ToString();
            txt_FACT_QUANLITY.Text = old_entity.FactQuantity.ToString();
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_DEPARTMENT();


            new_entity.DepartmentCode = txt_DEPARTMENT_CODE.Text;
            new_entity.DepartmentName = txt_DEPARTMENT_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Phone = txt_PHONE.Text;
            new_entity.Quantity = old_entity.Quantity;
            new_entity.FactQuantity = old_entity.FactQuantity;
            new_entity.Active = old_entity.Active;
            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if (validate.Status)
            {
                DAO_DIC_DEPARTMENT.Update(old_entity, new_entity);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Lỗi.!!!"); 
            }
        }

        frm_PHONG_BAN parent = null;
        public frm_PHONG_BAN_EDIT(frm_PHONG_BAN parent_frm, bool is_insert) : base(is_insert)
        {
            InitializeComponent();

            Init_Data();

            this.btn_INSERT_CONTINUE.Click += insert_record_continue;
            this.btn_INSERT.Click          += insert_record;
            parent = parent_frm;
        }
        private void Init_Data()
        {
            txt_DEPARTMENT_CODE.Text = LOGIC_COMMON.Generate_Code("PB");
            txt_DEPARTMENT_NAME.Text = string.Empty;
            txt_DESCRIPTION.Text = string.Empty;
            txt_QUANLITY.Text = "0";
            txt_FACT_QUANLITY.Text = "0";

        }
        private bool Insert()
        {
            new_entity = new DIC_DEPARTMENT();
            new_entity.DepartmentCode = txt_DEPARTMENT_CODE.Text;
            new_entity.DepartmentName = txt_DEPARTMENT_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Phone = txt_PHONE.Text;
            new_entity.Quantity = 0;
            new_entity.FactQuantity = 0;
            new_entity.Active = true;
            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if (validate.Status)
            {
                DAO_DIC_DEPARTMENT.Add(new_entity);
                parent.dg_DATA.DataSource = DAO_DIC_DEPARTMENT.Get_Data();
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Lỗi.!!!");

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
    }
}
