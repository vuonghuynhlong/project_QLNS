using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.LOGIC
{
    class GLOBAL
    {

        public static Dictionary<String, String> err_code = new Dictionary<String, String>(){
            {"E001","Ten Chuc Vu khong duoc rong!\r\n"},
            {"E002","Ten Chuc Vu khong duoc qua 100 ky tu!\r\n"},
            {"E003","Mo ta khong khong duoc qua 255 ky tu!\r\n"},
            {"E004","Ten Chuc Mon khong duoc rong!\r\n"},
            {"E005","Ten Chuc Vu khong duoc qua 100 ky tu!\r\n"},
        };
    }
}
