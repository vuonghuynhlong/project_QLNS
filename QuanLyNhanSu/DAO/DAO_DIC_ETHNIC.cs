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
    public class DAO_DIC_ETHNIC : DAO_BASE
    {
        public static DIC_ETHNIC Select_Record(DIC_ETHNIC clsDIC_ETHNICPara)
        {
            DIC_ETHNIC clsDIC_ETHNIC = new DIC_ETHNIC();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [EthnicCode] "
                + "    ,[EthnicName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_ETHNIC] "
                + "WHERE "
                + "     [EthnicCode] = @EthnicCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@EthnicCode", clsDIC_ETHNICPara.EthnicCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_ETHNIC.EthnicCode = System.Convert.ToString(reader["EthnicCode"]);
                    clsDIC_ETHNIC.EthnicName = reader["EthnicName"] is DBNull ? null : reader["EthnicName"].ToString();
                    clsDIC_ETHNIC.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_ETHNIC.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_ETHNIC = null;
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
            return clsDIC_ETHNIC;
        }

        public static bool Add(DIC_ETHNIC clsDIC_ETHNIC)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_ETHNIC] "
                + "     ( "
                + "     [EthnicCode] "
                + "    ,[EthnicName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @EthnicCode "
                + "    ,@EthnicName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@EthnicCode", clsDIC_ETHNIC.EthnicCode);
            if (clsDIC_ETHNIC.EthnicName != null)
            {
                insertCommand.Parameters.AddWithValue("@EthnicName", clsDIC_ETHNIC.EthnicName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@EthnicName", DBNull.Value);
            }
            if (clsDIC_ETHNIC.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_ETHNIC.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_ETHNIC.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_ETHNIC.Active);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Active", DBNull.Value);
            }
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

        public static bool Update(DIC_ETHNIC oldDIC_ETHNIC,
               DIC_ETHNIC newDIC_ETHNIC)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_ETHNIC] "
                + "SET "
                + "     [EthnicCode] = @NewEthnicCode "
                + "    ,[EthnicName] = @NewEthnicName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [EthnicCode] = @OldEthnicCode "
                + " AND ((@OldEthnicName IS NULL AND [EthnicName] IS NULL) OR [EthnicName] = @OldEthnicName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewEthnicCode", newDIC_ETHNIC.EthnicCode);
            if (newDIC_ETHNIC.EthnicName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewEthnicName", newDIC_ETHNIC.EthnicName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEthnicName", DBNull.Value);
            }
            if (newDIC_ETHNIC.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_ETHNIC.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_ETHNIC.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_ETHNIC.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldEthnicCode", oldDIC_ETHNIC.EthnicCode);
            if (oldDIC_ETHNIC.EthnicName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldEthnicName", oldDIC_ETHNIC.EthnicName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEthnicName", DBNull.Value);
            }
            if (oldDIC_ETHNIC.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_ETHNIC.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_ETHNIC.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_ETHNIC.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldActive", DBNull.Value);
            }
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

        public static bool Delete(DIC_ETHNIC clsDIC_ETHNIC)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_ETHNIC] "
                + "WHERE "
                + "     [EthnicCode] = @OldEthnicCode "
                + " AND ((@OldEthnicName IS NULL AND [EthnicName] IS NULL) OR [EthnicName] = @OldEthnicName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldEthnicCode", clsDIC_ETHNIC.EthnicCode);
            if (clsDIC_ETHNIC.EthnicName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldEthnicName", clsDIC_ETHNIC.EthnicName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEthnicName", DBNull.Value);
            }
            if (clsDIC_ETHNIC.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_ETHNIC.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_ETHNIC.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_ETHNIC.Active);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", DBNull.Value);
            }
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

        public static DataTable Get_Data()
        {
            String sql = "";
            sql = sql + "SELECT ";
            sql = sql + "     [EthnicCode] AS [Mã Dân Tộc]  ";
            sql = sql + "    ,[EthnicName] AS [Tên Dân Tộc] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "    ,[Active]           AS [Còn Sử Dụng]    ";
            sql = sql + "FROM DIC_ETHNIC ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }
        public static DataTable Get_View_Data()
        {
            String sql = "";
            sql = sql + "SELECT ";
            sql = sql + "     [EthnicCode] AS [Mã Dân Tộc]  ";
            sql = sql + "    ,[EthnicName] AS [Tên Dân Tộc] ";
            //sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            //sql = sql + "    ,[Active]           AS [Còn Sử Dụng]    ";
            sql = sql + "FROM DIC_ETHNIC ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static bool Delete(string code)
        {
            return Delete("DIC_ETHNIC", "EthnicCode", code);
        }
    }

}
