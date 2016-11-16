using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_DEGREE
    {
        private String m_DegreeCode;
        private String m_DegreeName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_DEGREE() { }

        public String DegreeCode
        {
            get
            {
                return m_DegreeCode;
            }
            set
            {
                m_DegreeCode = value;
            }
        }
        public String DegreeName
        {
            get
            {
                return m_DegreeName;
            }
            set
            {
                m_DegreeName = value;
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
