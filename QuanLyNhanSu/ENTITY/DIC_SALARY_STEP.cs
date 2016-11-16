using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_SALARY_STEP
    {
        private Int32 m_StepCode;
        private String m_RankCode;
        private String m_StepName;
        private Nullable<Decimal> m_Coefficient;
        private String m_Description;

        public DIC_SALARY_STEP() { }

        public Int32 StepCode
        {
            get
            {
                return m_StepCode;
            }
            set
            {
                m_StepCode = value;
            }
        }
        public String RankCode
        {
            get
            {
                return m_RankCode;
            }
            set
            {
                m_RankCode = value;
            }
        }
        public String StepName
        {
            get
            {
                return m_StepName;
            }
            set
            {
                m_StepName = value;
            }
        }

        public Nullable<Decimal> Coefficient
        {
            get
            {
                return m_Coefficient;
            }
            set
            {
                m_Coefficient = value;
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
