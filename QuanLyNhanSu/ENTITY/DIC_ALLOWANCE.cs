using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_ALLOWANCE
    {
        private String m_AllowanceCode;
        private String m_AllowanceName;
        private Nullable<Decimal> m_MaximumMoney;
        private String m_Description;

        public DIC_ALLOWANCE() { }

        public String AllowanceCode
        {
            get
            {
                return m_AllowanceCode;
            }
            set
            {
                m_AllowanceCode = value;
            }
        }
        public String AllowanceName
        {
            get
            {
                return m_AllowanceName;
            }
            set
            {
                m_AllowanceName = value;
            }
        }

        public Nullable<Decimal> MaximumMoney
        {
            get
            {
                return m_MaximumMoney;
            }
            set
            {
                m_MaximumMoney = value;
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


    }
}
