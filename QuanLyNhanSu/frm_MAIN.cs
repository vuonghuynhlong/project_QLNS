using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyNhanSu.LOGIC;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
namespace QuanLyNhanSu
{
    public partial class frm_MAIN : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_MAIN()
        {
            InitializeComponent();
        }

        public void Preload() {
            tab_MANAGER.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
        }

        private void bar_ItemClick(object sender, ItemClickEventArgs e)
        {
            LOGIC_COMMON.Add_Tab_Page(tab_MANAGER, e.Item.Name, e.Item.Caption);
        }

        private void frm_MAIN_Load(object sender, EventArgs e)
        {
            Preload();
        }

        private void tab_MANAGER_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
        }

    
    }
}