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
    public class DAO_DIC_RELIGION : DAO_BASE
    {
        public static DIC_RELIGION Select_Record(DIC_RELIGION clsDIC_RELIGIONPara)
        {
            DIC_RELIGION clsDIC_RELIGION = new DIC_RELIGION();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [ReligionCode] "
                + "    ,[ReligionName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_RELIGION] "
                + "WHERE "
                + "     [ReligionCode] = @ReligionCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@ReligionCode", clsDIC_RELIGIONPara.ReligionCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_RELIGION.ReligionCode = System.Convert.ToString(reader["ReligionCode"]);
                    clsDIC_RELIGION.ReligionName = reader["ReligionName"] is DBNull ? null : reader["ReligionName"].ToString();
                    clsDIC_RELIGION.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_RELIGION.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_RELIGION = null;
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
            return clsDIC_RELIGION;
        }

        public static bool Add(DIC_RELIGION clsDIC_RELIGION)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_RELIGION] "
                + "     ( "
                + "     [ReligionCode] "
                + "    ,[ReligionName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @ReligionCode "
                + "    ,@ReligionName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@ReligionCode", clsDIC_RELIGION.ReligionCode);
            if (clsDIC_RELIGION.ReligionName != null)
            {
                insertCommand.Parameters.AddWithValue("@ReligionName", clsDIC_RELIGION.ReligionName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ReligionName", DBNull.Value);
            }
            if (clsDIC_RELIGION.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_RELIGION.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_RELIGION.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_RELIGION.Active);
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

        public static bool Update(DIC_RELIGION oldDIC_RELIGION,
               DIC_RELIGION newDIC_RELIGION)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_RELIGION] "
                + "SET "
                + "     [ReligionCode] = @NewReligionCode "
                + "    ,[ReligionName] = @NewReligionName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [ReligionCode] = @OldReligionCode "
                + " AND ((@OldReligionName IS NULL AND [ReligionName] IS NULL) OR [ReligionName] = @OldReligionName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewReligionCode", newDIC_RELIGION.ReligionCode);
            if (newDIC_RELIGION.ReligionName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewReligionName", newDIC_RELIGION.ReligionName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewReligionName", DBNull.Value);
            }
            if (newDIC_RELIGION.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_RELIGION.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_RELIGION.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_RELIGION.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldReligionCode", oldDIC_RELIGION.ReligionCode);
            if (oldDIC_RELIGION.ReligionName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldReligionName", oldDIC_RELIGION.ReligionName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldReligionName", DBNull.Value);
            }
            if (oldDIC_RELIGION.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_RELIGION.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_RELIGION.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_RELIGION.Active);
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

        public static bool Delete(DIC_RELIGION clsDIC_RELIGION)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_RELIGION] "
                + "WHERE "
                + "     [ReligionCode] = @OldReligionCode "
                + " AND ((@OldReligionName IS NULL AND [ReligionName] IS NULL) OR [ReligionName] = @OldReligionName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldReligionCode", clsDIC_RELIGION.ReligionCode);
            if (clsDIC_RELIGION.ReligionName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldReligionName", clsDIC_RELIGION.ReligionName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldReligionName", DBNull.Value);
            }
            if (clsDIC_RELIGION.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_RELIGION.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_RELIGION.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_RELIGION.Active);
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
            sql = sql + "     [ReligionCode] AS [Mã Tôn Giáo]  ";
            sql = sql + "    ,[ReligionName] AS [Tên Tôn Giáo] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "FROM DIC_RELIGION ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static DataTable Get_View_Data()
        {

            String sql = "";
            sql = sql + "SELECT ";
            sql = sql + "     [ReligionCode] AS [Mã Tôn Giáo]  ";
            sql = sql + "    ,[ReligionName] AS [Tên Tôn Giáo] ";
            sql = sql + "FROM DIC_RELIGION ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }
        public static bool Delete(string code)
        {
            return Delete("DIC_RELIGION", "ReligionCode", code);
        }
    }

}
