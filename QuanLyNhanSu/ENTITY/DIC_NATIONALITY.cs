using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_NATIONALITY
    {
        private String m_NationalityCode;
        private String m_NationalityName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_NATIONALITY() { }

        public String NationalityCode
        {
            get
            {
                return m_NationalityCode;
            }
            set
            {
                m_NationalityCode = value;
            }
        }
        public String NationalityName
        {
            get
            {
                return m_NationalityName;
            }
            set
            {
                m_NationalityName = value;
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
