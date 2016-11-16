using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_SALARY_RANK
    {
        private String m_RankCode;
        private String m_RankName;
        private String m_Description;

        public DIC_SALARY_RANK() { }

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
        public String RankName
        {
            get
            {
                return m_RankName;
            }
            set
            {
                m_RankName = value;
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
