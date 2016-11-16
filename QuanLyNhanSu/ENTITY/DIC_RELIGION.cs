using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_RELIGION
    {
        private String m_ReligionCode;
        private String m_ReligionName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_RELIGION() { }

        public String ReligionCode
        {
            get
            {
                return m_ReligionCode;
            }
            set
            {
                m_ReligionCode = value;
            }
        }
        public String ReligionName
        {
            get
            {
                return m_ReligionName;
            }
            set
            {
                m_ReligionName = value;
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
