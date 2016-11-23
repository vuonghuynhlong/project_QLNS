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
                err_msg += GLOBAL.err_code["E004"];
            }

            if (Is_Over_MaxLength(e.ProfessionalName, 100))
            {
                err_msg += GLOBAL.err_code["E005"];
            }

            if (Is_Over_MaxLength(e.Description, 255))
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

        public static ENT_RETURN Check_Data(DIC_EDUCATION e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.EducationName))
            {
                err_msg += GLOBAL.err_code["E006"];
            }
            if (Is_Over_MaxLength(e.EducationName, 100))
            {
                err_msg += GLOBAL.err_code["E007"];
            }
            if (Is_Over_MaxLength(e.Description, 255))
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

        public static ENT_RETURN Check_Data(DIC_LANGUAGE e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.LanguageName))
            {
                err_msg += GLOBAL.err_code["E008"];
            }
            if (Is_Over_MaxLength(e.LanguageName, 100))
            {
                err_msg += GLOBAL.err_code["E009"];
            }
            if (Is_Over_MaxLength(e.Description, 200))
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


        public static ENT_RETURN Check_Data(DIC_INFORMATIC e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.InformaticName))
            {
                err_msg += GLOBAL.err_code["E010"];
            }
            if (Is_Over_MaxLength(e.InformaticName, 100))
            {
                err_msg += GLOBAL.err_code["E011"];
            }
            if (Is_Over_MaxLength(e.Description, 200))
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

        public static ENT_RETURN Check_Data(DIC_NATIONALITY e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.NationalityName))
            {
                err_msg += GLOBAL.err_code["E012"];
            }
            if (Is_Over_MaxLength(e.NationalityName, 100))
            {
                err_msg += GLOBAL.err_code["E013"];
            }
            if (Is_Over_MaxLength(e.Description, 200))
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

        public static ENT_RETURN Check_Data(DIC_ETHNIC e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.EthnicName))
            {
                err_msg += GLOBAL.err_code["E014"];
            }
            if (Is_Over_MaxLength(e.EthnicName, 100))
            {
                err_msg += GLOBAL.err_code["E015"];
            }
            if (Is_Over_MaxLength(e.Description, 200))
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

        public static ENT_RETURN Check_Data(DIC_RELIGION e)
        {
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.ReligionName))
            {
                err_msg += GLOBAL.err_code["E016"];
            }
            if (Is_Over_MaxLength(e.ReligionName, 100))
            {
                err_msg += GLOBAL.err_code["E017"];
            }
            if (Is_Over_MaxLength(e.Description, 200))
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

        internal static ENT_RETURN Check_Data(DIC_DEPARTMENT e)
        {
            //throw new NotImplementedException();
            ENT_RETURN ret = new ENT_RETURN();
            string err_msg = string.Empty;

            // BEGIN CHECK
            if (Is_Empty_String(e.DepartmentName))
            {
                err_msg += GLOBAL.err_code["E018"];
            }
            if (Is_Over_MaxLength(e.DepartmentName, 100))
            {
                err_msg += GLOBAL.err_code["E019"];
            }
            if (Is_Over_MaxLength(e.Description, 200))
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

        public static ENT_RETURN Check_Data(HRM_EMPLOYEE new_entity)
        {
            throw new NotImplementedException();
        }
    }
}
