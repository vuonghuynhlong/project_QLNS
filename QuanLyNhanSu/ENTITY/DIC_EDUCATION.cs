using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_EDUCATION
    {
        private String m_EducationCode;
        private String m_EducationName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_EDUCATION() { }

        public String EducationCode
        {
            get
            {
                return m_EducationCode;
            }
            set
            {
                m_EducationCode = value;
            }
        }
        public String EducationName
        {
            get
            {
                return m_EducationName;
            }
            set
            {
                m_EducationName = value;
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
