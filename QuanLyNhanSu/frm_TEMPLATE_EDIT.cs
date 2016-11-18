using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace QuanLyNhanSu
{
    public partial class frm_TEMPLATE_EDIT : DevExpress.XtraEditors.XtraForm
    {

        public frm_TEMPLATE_EDIT()
        {
            InitializeComponent();


            
        }
        public frm_TEMPLATE_EDIT(bool is_insert)
        {
            InitializeComponent();
            LayoutControlItem item_save = layout_CONTROL.GetItemByControl(btn_SAVE);
            item_save.Parent.Remove(item_save);
        }
    }
}