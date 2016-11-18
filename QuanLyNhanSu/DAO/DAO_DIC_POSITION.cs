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
    public class DAO_DIC_POSITION : DAO_BASE
    {

        public static DIC_POSITION Select_Record(DIC_POSITION clsDIC_POSITIONPara)
        {
            DIC_POSITION clsDIC_POSITION = new DIC_POSITION();
            SqlConnection connection = Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [PositionCode] "
                + "    ,[PositionName] "
                + "    ,[IsManager] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_POSITION] "
                + "WHERE "
                + "     [PositionCode] = @PositionCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@PositionCode", clsDIC_POSITIONPara.PositionCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_POSITION.PositionCode = System.Convert.ToString(reader["PositionCode"]);
                    clsDIC_POSITION.PositionName = reader["PositionName"] is DBNull ? null : reader["PositionName"].ToString();
                    clsDIC_POSITION.IsManager = reader["IsManager"] is DBNull ? null : (Boolean?)reader["IsManager"];
                    clsDIC_POSITION.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_POSITION.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_POSITION = null;
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
            return clsDIC_POSITION;
        }

        public static bool Add(DIC_POSITION clsDIC_POSITION)
        {
            SqlConnection connection = Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_POSITION] "
                + "     ( "
                + "     [PositionCode] "
                + "    ,[PositionName] "
                + "    ,[IsManager] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @PositionCode "
                + "    ,@PositionName "
                + "    ,@IsManager "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@PositionCode", clsDIC_POSITION.PositionCode);
            if (clsDIC_POSITION.PositionName != null)
            {
                insertCommand.Parameters.AddWithValue("@PositionName", clsDIC_POSITION.PositionName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PositionName", DBNull.Value);
            }
            if (clsDIC_POSITION.IsManager.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsManager", clsDIC_POSITION.IsManager);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsManager", DBNull.Value);
            }
            if (clsDIC_POSITION.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_POSITION.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_POSITION.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_POSITION.Active);
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

        public static bool Update(DIC_POSITION oldDIC_POSITION,
               DIC_POSITION newDIC_POSITION)
        {
            SqlConnection connection = Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_POSITION] "
                + "SET "
                + "     [PositionCode] = @NewPositionCode "
                + "    ,[PositionName] = @NewPositionName "
                + "    ,[IsManager] = @NewIsManager "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [PositionCode] = @OldPositionCode "
                + " AND ((@OldPositionName IS NULL AND [PositionName] IS NULL) OR [PositionName] = @OldPositionName) "
                + " AND ((@OldIsManager IS NULL AND [IsManager] IS NULL) OR [IsManager] = @OldIsManager) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewPositionCode", newDIC_POSITION.PositionCode);
            if (newDIC_POSITION.PositionName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewPositionName", newDIC_POSITION.PositionName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPositionName", DBNull.Value);
            }
            if (newDIC_POSITION.IsManager.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsManager", newDIC_POSITION.IsManager);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsManager", DBNull.Value);
            }
            if (newDIC_POSITION.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_POSITION.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_POSITION.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_POSITION.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldPositionCode", oldDIC_POSITION.PositionCode);
            if (oldDIC_POSITION.PositionName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldPositionName", oldDIC_POSITION.PositionName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPositionName", DBNull.Value);
            }
            if (oldDIC_POSITION.IsManager.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsManager", oldDIC_POSITION.IsManager);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsManager", DBNull.Value);
            }
            if (oldDIC_POSITION.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_POSITION.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_POSITION.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_POSITION.Active);
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

        public static bool Delete(DIC_POSITION clsDIC_POSITION)
        {
            SqlConnection connection = Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_POSITION] "
                + "WHERE "
                + "     [PositionCode] = @OldPositionCode "
                + " AND ((@OldPositionName IS NULL AND [PositionName] IS NULL) OR [PositionName] = @OldPositionName) "
                + " AND ((@OldIsManager IS NULL AND [IsManager] IS NULL) OR [IsManager] = @OldIsManager) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldPositionCode", clsDIC_POSITION.PositionCode);
            if (clsDIC_POSITION.PositionName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldPositionName", clsDIC_POSITION.PositionName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPositionName", DBNull.Value);
            }
            if (clsDIC_POSITION.IsManager.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsManager", clsDIC_POSITION.IsManager);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsManager", DBNull.Value);
            }
            if (clsDIC_POSITION.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_POSITION.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_POSITION.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_POSITION.Active);
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

        public static DataTable Get_Data() {
            String sql = "";
            sql = sql + "SELECT ";
            sql = sql + "     [PositionCode] AS [Mã Chức Vụ]  ";
            sql = sql + "    ,[PositionName] AS [Tên Chức Vụ] ";
            sql = sql + "    ,[IsManager]    AS [Là Quản Lý]  ";
            sql = sql + "    ,[Description]  AS [Mô Tả]       ";
           // sql = sql + "    ,[Active]       AS [Còn Sử Dụng] ";
            sql = sql + "FROM DIC_POSITION ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        
        }


        public static bool Delete(string code)
        {
            return Delete("DIC_POSITION", "PositionCode", code);
        }
    }

}
