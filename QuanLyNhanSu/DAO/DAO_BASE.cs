using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
   
    public class DAO_BASE
    {
        protected static SqlConnection Get_Connection()
        {
            string connectionString
                    = "Data Source=.\\sqlexpress;Initial Catalog=EMP_MANAGEMENT;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }


        protected static DataTable Select_Table(String sql)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                connection.Close();
            }
        }
    }

}
