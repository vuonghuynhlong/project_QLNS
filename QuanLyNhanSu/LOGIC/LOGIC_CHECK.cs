using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.ENTITY;
namespace QuanLyNhanSu.LOGIC
{
    public class LOGIC_CHECK : LOGIC_COMMON
    {
        // CHUC_VU (DIC_POSITION)
        public static ENT_RETURN Check_Data(DIC_POSITION e) {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.PositionName)) {
                err_msg += GLOBAL.err_code["E001"];
            }

            if (Is_Over_MaxLength(e.PositionName, 100)) {
                err_msg += GLOBAL.err_code["E002"];
            }

            if (Is_Over_MaxLength(e.Description, 255))
            {
                err_msg += GLOBAL.err_code["E003"];
            }
            // END CHECK


            if (err_msg != string.Empty) {
                ret.Message = err_msg;
                ret.Status = false;
            }

            return ret;
        }

        public static ENT_RETURN Check_Data(DIC_PROFESSIONAL e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.ProfessionalName))
            {
                err_msg += GLOBAL.err_code["E0004"];
            }

            if (Is_Over_MaxLength(e.ProfessionalName, 100))
            {
                err_msg += GLOBAL.err_code["E0005"];
            }

            if (Is_Over_MaxLength(e.ProfessionalName, 255))
            {
                err_msg += GLOBAL.err_code["E003"];
            }
            // END CHECK


            if (err_msg != string.Empty)
            {
                ret.Message = err_msg;
                ret.Status = false;
            }

            return ret;
        }


    }
}
