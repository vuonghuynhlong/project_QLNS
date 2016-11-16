using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_SCHOOL
    {
        private String m_SchoolCode;
        private String m_SchoolName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_SCHOOL() { }

        public String SchoolCode
        {
            get
            {
                return m_SchoolCode;
            }
            set
            {
                m_SchoolCode = value;
            }
        }
        public String SchoolName
        {
            get
            {
                return m_SchoolName;
            }
            set
            {
                m_SchoolName = value;
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
