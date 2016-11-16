using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
   
    public class EMP_MANAGEMENTData
    {
        public static SqlConnection GetConnection()
        {
            string connectionString
                    = "Data Source=.\\sqlexpress;Initial Catalog=EMP_MANAGEMENT;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }

}
