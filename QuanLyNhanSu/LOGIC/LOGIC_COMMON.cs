using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DAO;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace QuanLyNhanSu.LOGIC
{
    public class LOGIC_COMMON
    {

        private static  Dictionary<String, XtraUserControl> dict = new Dictionary<string, XtraUserControl>(){
           {"bar_NGOAI_NGU", new frm_NGOAI_NGU()},
           {"bar_TIN_HOC", new frm_TIN_HOC()},
           {"bar_HOC_VAN", new frm_HOC_VAN()},
           {"bar_PHONG_BAN", new frm_PHONG_BAN()},
           {"bar_CHUC_VU", new frm_CHUC_VU()},
           {"bar_CHUYEN_MON", new frm_CHUYEN_MON()},
           {"bar_QUOC_TICH", new frm_QUOC_TICH()},
           {"bar_DAN_TOC", new frm_DAN_TOC()},
           {"bar_TON_GIAO", new frm_TON_GIAO()},
           {"bar_NHAN_VIEN", new frm_NHAN_VIEN()},
           {"bar_HOP_DONG_LAO_DONG", new frm_HOP_DONG_LAO_DONG()},
        };

        private static Dictionary<String, String> dict_code = new Dictionary<String, String>(){
           {"CV", "DIC_POSITION"},
           {"CM", "DIC_PROFESSIONAL"},
           {"DT", "DIC_ETHNIC"},
           {"HV", "DIC_EDUCATION"},
           {"PB", "DIC_DEPARTMENT"},
           {"NN", "DIC_LANGUAGE"},
           {"TH", "DIC_INFORMATIC"},
           {"QT", "DIC_NATIONALITY"},
           {"TG", "DIC_RELIGION"},
           {"NV", "HRM_EMPLOYEE"},
           
        };
        

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

            tab.PageVisible = true;

            tab_manager.SelectedTabPage = tab;
        }
        private static void Add_Control(XtraTabPage tab_page) {
            XtraUserControl frm = (XtraUserControl)dict[tab_page.Name];
            frm.Dock = DockStyle.Fill;
            tab_page.Controls.Add(frm);
        }

        public static string Generate_Code(string prefix) {
            string table_name = dict_code[prefix];
            return prefix + DAO_BASE.Generate_Code(table_name);
        }

        public static bool Is_Empty_String(String str)
        {
            return (str == null || str.Trim().Length == 0);
        }
        public static bool Is_Over_MaxLength(String str, int max_length)
        {
            return (str.Length > max_length);
        }


        public static bool Is_Number(String str)
        {
            try
            {
               int.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //public static bool emailIsValid(string email)
        //{
        //    string expresion;
        //    expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        //    if (Regex.IsMatch(email, expresion))
        //    {
        //        if (Regex.Replace(email, expresion, string.Empty).Length == 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public static bool Is_Email(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static void Init_Lookup_Edit_DataSource(LookUpEdit lookup_edit, DataTable data, String value_member, String display_member) {
            lookup_edit.Properties.DataSource = data;
            lookup_edit.Properties.DisplayMember = display_member;
            lookup_edit.Properties.ValueMember = value_member;          
        }

        public static Image Byte_To_Bitmap(byte[] arr){
            using (var ms = new MemoryStream(arr))
            {
                return Image.FromStream(ms);
            }
        }
        public static byte[] Bitmap_To_Byte(Image img)
        {

            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
         
        }

        public static byte[] Get_No_Avatar()
        {
            Image img = (Image)QuanLyNhanSu.Properties.Resources.LANGUAGE;
            byte[] imgbyte = LOGIC_COMMON.Bitmap_To_Byte(img);
            return imgbyte;
        }
    }
}
