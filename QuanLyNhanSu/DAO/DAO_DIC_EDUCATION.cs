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
    public class DAO_DIC_EDUCATION : DAO_BASE
    {
        public static DIC_EDUCATION Select_Record(DIC_EDUCATION clsDIC_EDUCATIONPara)
        {
            DIC_EDUCATION clsDIC_EDUCATION = new DIC_EDUCATION();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [EducationCode] "
                + "    ,[EducationName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_EDUCATION] "
                + "WHERE "
                + "     [EducationCode] = @EducationCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@EducationCode", clsDIC_EDUCATIONPara.EducationCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_EDUCATION.EducationCode = System.Convert.ToString(reader["EducationCode"]);
                    clsDIC_EDUCATION.EducationName = reader["EducationName"] is DBNull ? null : reader["EducationName"].ToString();
                    clsDIC_EDUCATION.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_EDUCATION.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_EDUCATION = null;
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
            return clsDIC_EDUCATION;
        }

        public static bool Add(DIC_EDUCATION clsDIC_EDUCATION)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_EDUCATION] "
                + "     ( "
                + "     [EducationCode] "
                + "    ,[EducationName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @EducationCode "
                + "    ,@EducationName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@EducationCode", clsDIC_EDUCATION.EducationCode);
            if (clsDIC_EDUCATION.EducationName != null)
            {
                insertCommand.Parameters.AddWithValue("@EducationName", clsDIC_EDUCATION.EducationName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@EducationName", DBNull.Value);
            }
            if (clsDIC_EDUCATION.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_EDUCATION.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_EDUCATION.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_EDUCATION.Active);
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

        public static bool Update(DIC_EDUCATION oldDIC_EDUCATION,
               DIC_EDUCATION newDIC_EDUCATION)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_EDUCATION] "
                + "SET "
                + "     [EducationCode] = @NewEducationCode "
                + "    ,[EducationName] = @NewEducationName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [EducationCode] = @OldEducationCode "
                + " AND ((@OldEducationName IS NULL AND [EducationName] IS NULL) OR [EducationName] = @OldEducationName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewEducationCode", newDIC_EDUCATION.EducationCode);
            if (newDIC_EDUCATION.EducationName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewEducationName", newDIC_EDUCATION.EducationName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEducationName", DBNull.Value);
            }
            if (newDIC_EDUCATION.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_EDUCATION.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_EDUCATION.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_EDUCATION.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldEducationCode", oldDIC_EDUCATION.EducationCode);
            if (oldDIC_EDUCATION.EducationName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldEducationName", oldDIC_EDUCATION.EducationName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEducationName", DBNull.Value);
            }
            if (oldDIC_EDUCATION.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_EDUCATION.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_EDUCATION.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_EDUCATION.Active);
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

        public static bool Delete(DIC_EDUCATION clsDIC_EDUCATION)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_EDUCATION] "
                + "WHERE "
                + "     [EducationCode] = @OldEducationCode "
                + " AND ((@OldEducationName IS NULL AND [EducationName] IS NULL) OR [EducationName] = @OldEducationName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldEducationCode", clsDIC_EDUCATION.EducationCode);
            if (clsDIC_EDUCATION.EducationName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldEducationName", clsDIC_EDUCATION.EducationName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEducationName", DBNull.Value);
            }
            if (clsDIC_EDUCATION.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_EDUCATION.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_EDUCATION.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_EDUCATION.Active);
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

        public static bool Delete(string code)
        {
           return Delete("DIC_EDUCATION", "EducationCode", code);
        }

        public static DataTable Get_Data()
        {
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [EducationCode] AS [Mã Học Vấn]  ";
            sql = sql + "    ,[EducationName] AS [Tên Học Vấn] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "FROM DIC_EDUCATION ";
            sql = sql + "WHERE [Active] = 1 ";

            return Select_Table(sql);
        }

        public static DataTable Get_View_Data()
        {
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [EducationCode] AS [Mã Học Vấn]  ";
            sql = sql + "    ,[EducationName] AS [Tên Học Vấn] ";
            sql = sql + "FROM DIC_EDUCATION ";
            sql = sql + "WHERE [Active] = 1 ";

            return Select_Table(sql);
        }

    }


}
