using QuanLyNhanSu.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_DIC_WORK_STATE : DAO_BASE
    {
        public static DIC_WORK_STATE Select_Record(DIC_WORK_STATE clsDIC_WORK_STATEPara)
        {
            DIC_WORK_STATE clsDIC_WORK_STATE = new DIC_WORK_STATE();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [WorkStateCode] "
                + "    ,[WorkStateName] "
                + "FROM "
                + "     [DIC_WORK_STATE] "
                + "WHERE "
                + "     [WorkStateCode] = @WorkStateCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@WorkStateCode", clsDIC_WORK_STATEPara.WorkStateCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_WORK_STATE.WorkStateCode = System.Convert.ToString(reader["WorkStateCode"]);
                    clsDIC_WORK_STATE.WorkStateName = System.Convert.ToString(reader["WorkStateName"]);
                }
                else
                {
                    clsDIC_WORK_STATE = null;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return clsDIC_WORK_STATE;
        }

        public static bool Add(DIC_WORK_STATE clsDIC_WORK_STATE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_WORK_STATE] "
                + "     ( "
                + "     [WorkStateCode] "
                + "    ,[WorkStateName] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @WorkStateCode "
                + "    ,@WorkStateName "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@WorkStateCode", clsDIC_WORK_STATE.WorkStateCode);
            insertCommand.Parameters.AddWithValue("@WorkStateName", clsDIC_WORK_STATE.WorkStateName);
            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
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

        public static bool Update(DIC_WORK_STATE oldDIC_WORK_STATE,
               DIC_WORK_STATE newDIC_WORK_STATE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_WORK_STATE] "
                + "SET "
                + "     [WorkStateCode] = @NewWorkStateCode "
                + "    ,[WorkStateName] = @NewWorkStateName "
                + "WHERE "
                + "     [WorkStateCode] = @OldWorkStateCode "
                + " AND [WorkStateName] = @OldWorkStateName "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewWorkStateCode", newDIC_WORK_STATE.WorkStateCode);
            updateCommand.Parameters.AddWithValue("@NewWorkStateName", newDIC_WORK_STATE.WorkStateName);
            updateCommand.Parameters.AddWithValue("@OldWorkStateCode", oldDIC_WORK_STATE.WorkStateCode);
            updateCommand.Parameters.AddWithValue("@OldWorkStateName", oldDIC_WORK_STATE.WorkStateName);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
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

        public static bool Delete(DIC_WORK_STATE clsDIC_WORK_STATE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_WORK_STATE] "
                + "WHERE "
                + "     [WorkStateCode] = @OldWorkStateCode "
                + " AND [WorkStateName] = @OldWorkStateName "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldWorkStateCode", clsDIC_WORK_STATE.WorkStateCode);
            deleteCommand.Parameters.AddWithValue("@OldWorkStateName", clsDIC_WORK_STATE.WorkStateName);
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

        public static DataTable Get_View_Data()
        {
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [WorkStateCode] AS [Mã Trạng Thái]  ";
            sql = sql + "    ,[WorkStateName] AS [Tên Trạng Thái] ";
            sql = sql + "FROM DIC_WORK_STATE ";
            return Select_Table(sql);
        }
    }

}
