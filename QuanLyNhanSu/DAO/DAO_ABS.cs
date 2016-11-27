using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.ENTITY;
namespace QuanLyNhanSu.DAO
{
    interface DAO_INTERFACE
    {
          DIC_DEGREE Select_Record(DIC_DEGREE obj);
          bool Add(DIC_DEGREE obj);
        
          DataTable Get_Data();
    }
}
