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

namespace QuanLyNhanSu
{
    public partial class frm_QUOC_TICH_EDIT : QuanLyNhanSu.frm_TEMPLATE_EDIT
    {
        string CODE;
        DIC_NATIONALITY old_entity;
        DIC_NATIONALITY new_entity;
        public frm_QUOC_TICH_EDIT(string code)
        {
            InitializeComponent();
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;
            this.btn_SAVE.Location = new Point(274, 7);
            CODE = code;
        }
        private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_NATIONALITY();
            old_entity.NationalityCode = CODE;
            old_entity = DAO_DIC_NATIONALITY.Select_Record(old_entity);
            txt_NATIONALITY_CODE.Text = old_entity.NationalityCode;
            txt_NATIONALITY_NAME.Text = old_entity.NationalityName;
            txt_DESCRIPTION.Text = old_entity.Description;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_NATIONALITY();
            new_entity.NationalityCode = txt_NATIONALITY_CODE.Text;
            new_entity.NationalityName = txt_NATIONALITY_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Active = old_entity.Active;
            DAO_DIC_NATIONALITY.Update(old_entity, new_entity);
            this.DialogResult = DialogResult.OK;
        }
    }
}
