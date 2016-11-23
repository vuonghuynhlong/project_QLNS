using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_DEPARTMENT
    {
        private String m_DepartmentCode;
        private String m_DepartmentName;
        private String m_Phone;
        private Nullable<Int32> m_Quantity;
        private Nullable<Int32> m_FactQuantity;
        private String m_Description;
        private Nullable<Boolean> m_Active;

        public DIC_DEPARTMENT() { }

        public String DepartmentCode
        {
            get
            {
                return m_DepartmentCode;
            }
            set
            {
                m_DepartmentCode = value;
            }
        }
        public String DepartmentName
        {
            get
            {
                return m_DepartmentName;
            }
            set
            {
                m_DepartmentName = value;
            }
        }

        public String Phone
        {
            get
            {
                return m_Phone;
            }
            set
            {
                m_Phone = value;
            }
        }

        public Nullable<Int32> Quantity
        {
            get
            {
                return m_Quantity;
            }
            set
            {
                m_Quantity = value;
            }
        }

        public Nullable<Int32> FactQuantity
        {
            get
            {
                return m_FactQuantity;
            }
            set
            {
                m_FactQuantity = value;
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
