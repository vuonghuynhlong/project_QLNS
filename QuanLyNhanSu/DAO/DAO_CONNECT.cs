using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
   
    public class DAO_CONNECT
    {
        public static SqlConnection Get_Connection()
        {
            string connectionString
                    = "Data Source=.\\sqlexpress;Initial Catalog=EMP_MANAGEMENT;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }

}
