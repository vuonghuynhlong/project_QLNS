using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_ETHNIC
    {
        private String m_EthnicCode;
        private String m_EthnicName;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_ETHNIC() { }

        public String EthnicCode
        {
            get
            {
                return m_EthnicCode;
            }
            set
            {
                m_EthnicCode = value;
            }
        }
        public String EthnicName
        {
            get
            {
                return m_EthnicName;
            }
            set
            {
                m_EthnicName = value;
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
