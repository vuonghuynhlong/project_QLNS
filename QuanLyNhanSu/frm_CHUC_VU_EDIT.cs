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
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click+=btn_SAVE_Click;
            this.btn_SAVE.Location = new Point(274, 7);
            CODE = code;
        }

        private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_POSITION();

            old_entity.PositionCode = CODE;
            old_entity = DAO_DIC_POSITION.Select_Record(old_entity);


            txt_POSITION_CODE.Text = old_entity.PositionCode;
            txt_POSITION_NAME.Text = old_entity.PositionName;
            txt_DESCRIPTION.Text = old_entity.Description;
            if (old_entity.IsManager != null)
                chk_IS_MANAGER.Checked = (bool)old_entity.IsManager;



        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_POSITION();


            new_entity.PositionCode  = txt_POSITION_CODE.Text;
            new_entity.PositionName = txt_POSITION_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.IsManager = chk_IS_MANAGER.Checked;
            DAO_DIC_POSITION.Update(old_entity, new_entity);


            this.DialogResult = DialogResult.OK;
        }
    }
}
