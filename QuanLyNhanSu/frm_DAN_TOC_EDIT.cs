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
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;

namespace QuanLyNhanSu
{
    public partial class frm_DAN_TOC_EDIT : QuanLyNhanSu.frm_TEMPLATE_EDIT
    {
        DIC_ETHNIC old_entity;
        DIC_ETHNIC new_entity;
        string CODE;
        public frm_DAN_TOC_EDIT(string code)
        {
            InitializeComponent();
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;
            //this.btn_SAVE.Location = new Point(274, 7);
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
            old_entity = new DIC_ETHNIC();
            old_entity.EthnicCode = CODE;
            old_entity = DAO_DIC_ETHNIC.Select_Record(old_entity);
            txt_ETHNIC_CODE.Text = old_entity.EthnicCode;
            txt_ETHNIC_NAME.Text = old_entity.EthnicName;
            txt_DESCRIPTION.Text = old_entity.Description;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_ETHNIC();
            new_entity.EthnicCode = txt_ETHNIC_CODE.Text;
            new_entity.EthnicName = txt_ETHNIC_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Active = old_entity.Active;
            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if (validate.Status)
            {
                DAO_DIC_ETHNIC.Update(old_entity, new_entity);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Lỗi.!!!"); 
            }
        }

        // BEGIN INSERT BEGIN INSERT BEGIN INSERT BEGIN INSERT BEGIN INSERT 

        frm_DAN_TOC parent = null;

        public frm_DAN_TOC_EDIT(frm_DAN_TOC parent_frm, bool is_insert) : base(is_insert)
        {
            InitializeComponent();

            Init_Data();

            this.btn_INSERT_CONTINUE.Click += insert_record_continue;
            this.btn_INSERT.Click          += insert_record;

            parent = parent_frm;


        }

        //public frm_DAN_TOC_EDIT(frm_DAN_TOC frm_DAN_TOC, bool p)
        //{
        //    // TODO: Complete member initialization
        //    this.frm_DAN_TOC = frm_DAN_TOC;
        //    this.p = p;
        //}

    
        private void Init_Data()
        {
            txt_ETHNIC_CODE.Text = LOGIC_COMMON.Generate_Code("DT");
            txt_ETHNIC_NAME.Text = string.Empty;
            txt_DESCRIPTION.Text = string.Empty;
            //chk_IS_MANAGER.Checked = false;
            
        }
        private bool Insert()
        {
            new_entity = new DIC_ETHNIC();
            new_entity.EthnicCode = txt_ETHNIC_CODE.Text;
            new_entity.EthnicName = txt_ETHNIC_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            //new_entity.IsManager = chk_IS_MANAGER.Checked;
            new_entity.Active = true;
            ENT_RETURN validate = LOGIC_CHECK.Check_Data(new_entity);
            if(validate.Status)
            {
                DAO_DIC_ETHNIC.Add(new_entity);
                if(parent!=null)
                    parent.dg_DATA.DataSource = DAO_DIC_ETHNIC.Get_Data();
            }
            else
            {
                XtraMessageBox.Show(validate.Message, "Lỗi.!!!"); return false;
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
