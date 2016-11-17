﻿using DevExpress.XtraEditors;
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
           {"bar_HOC_VAN", new frm_HOC_VAN()},
           {"bar_CHUC_VU", new frm_CHUC_VU()},
           {"bar_CHUYEN_MON", new frm_CHUYEN_MON()},
           {"bar_QUOC_TICH", new frm_QUOC_TICH()},
           {"bar_DAN_TOC", new frm_DAN_TOC()},
           {"bar_TON_GIAO", new frm_TON_GIAO()},
           {"bar_DANH_SACH_NHAN_VIEN", new frm_DANH_SACH_NHAN_VIEN()},
           {"bar_HOP_DONG_LAO_DONG", new frm_HOP_DONG_LAO_DONG()},
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
