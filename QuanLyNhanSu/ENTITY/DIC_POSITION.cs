using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_POSITION
    {
        private String m_PositionCode;
        private String m_PositionName;
        private Nullable<Boolean> m_IsManager;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_POSITION() { }

        public String PositionCode
        {
            get
            {
                return m_PositionCode;
            }
            set
            {
                m_PositionCode = value;
            }
        }
        public String PositionName
        {
            get
            {
                return m_PositionName;
            }
            set
            {
                m_PositionName = value;
            }
        }

        public Nullable<Boolean> IsManager
        {
            get
            {
                return m_IsManager;
            }
            set
            {
                m_IsManager = value;
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
