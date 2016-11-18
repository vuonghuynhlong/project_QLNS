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
            this.btn_SAVE.Location = new Point(274, 7);
            CODE = code;
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
            DAO_DIC_PROFESSIONAL.Update(old_entity, new_entity);
            this.DialogResult = DialogResult.OK;
        }
    }
}
