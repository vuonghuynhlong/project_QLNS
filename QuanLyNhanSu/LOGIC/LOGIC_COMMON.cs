using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyNhanSu.LOGIC
{
    public class LOGIC_COMMON
    {

        private static  Dictionary<String, XtraUserControl> dict = new Dictionary<string, XtraUserControl>(){
           {"bar_NGOAI_NGU", new frm_NGOAI_NGU()},
           {"bar_TIN_HOC", new frm_TIN_HOC()},
        };
         

        /// <summary>
        /// Them mot tab moi vao trong frm_MAIN
        /// </summary>
        public static void Add_Tab_Page(XtraTabControl tab_manager, String tab_page_name, String tab_page_text) {
            var find_tab = tab_manager.TabPages.Where(p => p.Name == tab_page_name);
            XtraTabPage tab = null;
            if (find_tab.Count() == 0) 
            {
                tab = tab_manager.TabPages.Add();
                tab.Name = tab_page_name;
                tab.Text = tab_page_text;
                tab.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                Add_Control(tab);
            }
            else
            {
                tab = find_tab.First();
            }
            tab_manager.SelectedTabPage = tab;
        }
        private static void Add_Control(XtraTabPage tab_page) {
            XtraUserControl frm = (XtraUserControl)dict[tab_page.Name];
            frm.Dock = DockStyle.Fill;
            tab_page.Controls.Add(frm);
        }
    }
}
