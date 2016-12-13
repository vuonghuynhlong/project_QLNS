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

        protected static bool Delete(String table_name,String column_code,String code)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "UPDATE "
                + "     ["+table_name+"] "
                + "SET "
                + "     [ACTIVE] = 0 "
                + "WHERE ["+column_code+"] = @OldCode";


            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldCode", code);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static string Generate_Code(string table) {

            SqlConnection connection = DAO_BASE.Get_Connection();

            string column_code = table.Substring(4) + "Code";
            
            string sql =" SELECT MAX(" + column_code + ")";
            sql  = sql + " FROM "+ table ;

            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                string code   = cmd.ExecuteScalar().ToString();
                int number    = int.Parse(code.Substring(2)) + 1;
                code = "000000" + number;
                code = code.Substring(code.Length - 6, 6);
                return code;
            }
            catch (SqlException ex)
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
