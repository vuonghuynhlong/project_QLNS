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
    public partial class frm_TIN_HOC_EDIT : QuanLyNhanSu.frm_TEMPLATE_EDIT
    {
        string CODE;
        DIC_INFORMATIC old_entity;
        DIC_INFORMATIC new_entity;
        public frm_TIN_HOC_EDIT(string code)
        {
            InitializeComponent();
            this.Load += frm_EDIT_Load;
            this.btn_SAVE.Click += btn_SAVE_Click;
            this.btn_SAVE.Location = new Point(274, 7);
            CODE = code;
        }

      

        private void frm_EDIT_Load(object sender, EventArgs e)
        {
            old_entity = new DIC_INFORMATIC();

            old_entity.InformaticCode = CODE;
            old_entity = DAO_DIC_INFORMATIC.Select_Record(old_entity);


            txt_INFORMATIC_CODE.Text = old_entity.InformaticCode;
            txt_INFORMATIC_NAME.Text = old_entity.InformaticName;
            txt_DESCRIPTION.Text = old_entity.Description;
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            new_entity = new DIC_INFORMATIC();


            new_entity.InformaticCode = txt_INFORMATIC_CODE.Text;
            new_entity.InformaticName = txt_INFORMATIC_NAME.Text;
            new_entity.Description = txt_DESCRIPTION.Text;
            new_entity.Active = old_entity.Active;
            DAO_DIC_INFORMATIC.Update(old_entity, new_entity);


            this.DialogResult = DialogResult.OK;
        }
        public string code { get; set; }
    }
}
