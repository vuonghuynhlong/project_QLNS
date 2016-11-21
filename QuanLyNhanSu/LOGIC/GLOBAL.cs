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
            {"E001","Tên chức vụ không được rỗng!!\r\n"},
            {"E002","Tên chức vụ không được quá 100 ký tự!!\r\n"},
            {"E003","Mô tả không được quá 200 ký tự!!\r\n"},
            {"E004","Tên chuyên môn không được rỗng!!\r\n"},
            {"E005","Tên chuyên môn không được quá 100 ký tự!!!\r\n"},
            {"E006", "Tên học vấn không được rỗng.!!!\r\n"},
            {"E007", "Tên học vấn không được quá 100 ký tự.!!!\r\n"},
            {"E008", "Tên ngoại ngữ không được rỗng.!!!\r\n"},
            {"E009", "Tên ngoại ngữ không được quá 100 ký tự.!!!\r\n"},
            {"E010", "Tên tin học không được rỗng.!!!\r\n"},
            {"E011", "Tên tin học không được quá 100 ký tự.!!!\r\n"},
            {"E012", "Tên quốc tịch không được rổng.!!!\r\n"},
            {"E013", "Tên quốc tịch không được quá 100 ký tự.!!!\r\n"},
            {"E014", "Tên dân tộc không được rỗng.!!!\r\n"},
            {"E015", "Tên dân tộc không được quá 100 ký tự.!!!\r\n"},
            {"E016", "Tên tôn giáo không được rỗng.!!!\r\n"},
            {"E017", "Tên tôn giáo không được quá 100 ký tự.!!!\r\n"},
            {"E018", "Tên phòng ban không được rỗng.!!!\r\n"},
            {"E019", "Tên phòng ban không được quá 100 ký tự.!!!\r\n"},

        };
    }
}
