using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.ENTITY;
using QuanLyNhanSu.DAO;
namespace QuanLyNhanSu
{
    public partial class frm_CHUC_VU_EDIT : frm_TEMPLATE_EDIT
    {
        string CODE;
        DIC_POSITION old_entity;
        DIC_POSITION new_entity;
        public frm_CHUC_VU_EDIT(string code)
        {
            InitializeComponent();
            CODE = code;
        }

        private void frm_CHUC_VU_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_POSITION();
            old_entity.PositionCode = CODE;
            old_entity = DAO_DIC_POSITION.Select_Record(old_entity);
            textEdit1.Text = old_entity.PositionCode;
            textEdit2.Text = old_entity.PositionName;
            textEdit3.Text = old_entity.Description;
            checkEdit1.Checked = (bool) old_entity.Active;



        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_POSITION();
            new_entity.PositionCode  = textEdit1.Text;
            new_entity.PositionName = textEdit2.Text;
            new_entity.Description = textEdit3.Text;
            new_entity.Active = checkEdit1.Checked;
            DAO_DIC_POSITION.Update(old_entity, new_entity);
            this.DialogResult = DialogResult.OK;
        }
    }
}
