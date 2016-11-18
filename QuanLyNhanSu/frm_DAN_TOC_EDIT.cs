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
            this.btn_SAVE.Location = new Point(274, 7);
            CODE = code;
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
            DAO_DIC_ETHNIC.Update(old_entity, new_entity);
            this.DialogResult = DialogResult.OK;
        }
    }
}
