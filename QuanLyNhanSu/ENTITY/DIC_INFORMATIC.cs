using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_INFORMATIC
    {
        private String m_InformaticCode;
        private String m_InformaticName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_INFORMATIC() { }

        public String InformaticCode
        {
            get
            {
                return m_InformaticCode;
            }
            set
            {
                m_InformaticCode = value;
            }
        }
        public String InformaticName
        {
            get
            {
                return m_InformaticName;
            }
            set
            {
                m_InformaticName = value;
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
