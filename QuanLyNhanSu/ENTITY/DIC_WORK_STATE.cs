using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class DIC_WORK_STATE
    {
        private String m_WorkStateCode;
        private String m_WorkStateName;

        public DIC_WORK_STATE() { }

        public String WorkStateCode
        {
            get
            {
                return m_WorkStateCode;
            }
            set
            {
                m_WorkStateCode = value;
            }
        }
        public String WorkStateName
        {
            get
            {
                return m_WorkStateName;
            }
            set
            {
                m_WorkStateName = value;
            }
        }
    }

}
