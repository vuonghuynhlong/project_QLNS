using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_LANGUAGE
    {
        private String m_LanguageCode;
        private String m_LanguageName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_LANGUAGE() { }

        public String LanguageCode
        {
            get
            {
                return m_LanguageCode;
            }
            set
            {
                m_LanguageCode = value;
            }
        }
        public String LanguageName
        {
            get
            {
                return m_LanguageName;
            }
            set
            {
                m_LanguageName = value;
            }
        }

        public String Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
            }
        }

        public Nullable<Boolean> Active
        {
            get
            {
                return m_Active;
            }
            set
            {
                m_Active = value;
            }
        }

    }

}
