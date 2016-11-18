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
    public partial class frm_TON_GIAO_EDIT : QuanLyNhanSu.frm_TEMPLATE_EDIT
    {
        string CODE;
        DIC_RELIGION old_entity;
        DIC_RELIGION new_entity;
        public frm_TON_GIAO_EDIT(string code)
        {
            InitializeComponent();
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;
            this.btn_SAVE.Location = new Point(274, 7);
            CODE = code;
        }

        private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_RELIGION();
            old_entity.ReligionCode = CODE;
            old_entity = DAO_DIC_RELIGION.Select_Record(old_entity);
            txt_RELIGION_CODE.Text = old_entity.ReligionCode;
            txt_RELIGION_NAME.Text = old_entity.ReligionName;
            txt_DESCRIPTION.Text = old_entity.Description;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_RELIGION();
            new_entity.ReligionCode = txt_RELIGION_CODE.Text;
            new_entity.ReligionName = txt_RELIGION_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Active = old_entity.Active;
            DAO_DIC_RELIGION.Update(old_entity, new_entity);
            this.DialogResult = DialogResult.OK;
        }
    }
}
