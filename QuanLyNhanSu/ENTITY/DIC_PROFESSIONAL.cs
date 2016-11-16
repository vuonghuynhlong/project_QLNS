using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_PROFESSIONAL
    {
        private String m_ProfessionalCode;
        private String m_ProfessionalName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_PROFESSIONAL() { }

        public String ProfessionalCode
        {
            get
            {
                return m_ProfessionalCode;
            }
            set
            {
                m_ProfessionalCode = value;
            }
        }
        public String ProfessionalName
        {
            get
            {
                return m_ProfessionalName;
            }
            set
            {
                m_ProfessionalName = value;
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
