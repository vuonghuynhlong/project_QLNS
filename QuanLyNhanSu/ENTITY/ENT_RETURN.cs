using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class ENT_RETURN
    {
        private Dictionary<String, Object> m_Value;
        private bool m_Status ;
        private String m_Message;
        public ENT_RETURN() { m_Status = true; }

        public Dictionary<String, Object> Value
        {
            get
            {
                return m_Value;
            }
            set
            {
                m_Value = value;
            }
        }

        public bool Status
        {
            get
            {
                return m_Status;
            }
            set
            {
                m_Status = value;
            }
        }

        public string Message
        {
            get
            {
                return m_Message;
            }
            set
            {
                m_Message = value;
            }
        }

    }
}
