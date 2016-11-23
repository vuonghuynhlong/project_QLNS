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
    public class DAO_DIC_LANGUAGE : DAO_BASE
    {
        public static DIC_LANGUAGE Select_Record(DIC_LANGUAGE clsDIC_LANGUAGEPara)
        {
            DIC_LANGUAGE clsDIC_LANGUAGE = new DIC_LANGUAGE();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [LanguageCode] "
                + "    ,[LanguageName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_LANGUAGE] "
                + "WHERE "
                + "     [LanguageCode] = @LanguageCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@LanguageCode", clsDIC_LANGUAGEPara.LanguageCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_LANGUAGE.LanguageCode = System.Convert.ToString(reader["LanguageCode"]);
                    clsDIC_LANGUAGE.LanguageName = reader["LanguageName"] is DBNull ? null : reader["LanguageName"].ToString();
                    clsDIC_LANGUAGE.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_LANGUAGE.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_LANGUAGE = null;
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
            return clsDIC_LANGUAGE;
        }

        public static bool Add(DIC_LANGUAGE clsDIC_LANGUAGE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_LANGUAGE] "
                + "     ( "
                + "     [LanguageCode] "
                + "    ,[LanguageName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @LanguageCode "
                + "    ,@LanguageName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@LanguageCode", clsDIC_LANGUAGE.LanguageCode);
            if (clsDIC_LANGUAGE.LanguageName != null)
            {
                insertCommand.Parameters.AddWithValue("@LanguageName", clsDIC_LANGUAGE.LanguageName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@LanguageName", DBNull.Value);
            }
            if (clsDIC_LANGUAGE.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_LANGUAGE.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_LANGUAGE.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_LANGUAGE.Active);
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

        public static bool Update(DIC_LANGUAGE oldDIC_LANGUAGE,
               DIC_LANGUAGE newDIC_LANGUAGE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_LANGUAGE] "
                + "SET "
                + "     [LanguageCode] = @NewLanguageCode "
                + "    ,[LanguageName] = @NewLanguageName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [LanguageCode] = @OldLanguageCode "
                + " AND ((@OldLanguageName IS NULL AND [LanguageName] IS NULL) OR [LanguageName] = @OldLanguageName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewLanguageCode", newDIC_LANGUAGE.LanguageCode);
            if (newDIC_LANGUAGE.LanguageName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewLanguageName", newDIC_LANGUAGE.LanguageName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewLanguageName", DBNull.Value);
            }
            if (newDIC_LANGUAGE.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_LANGUAGE.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_LANGUAGE.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_LANGUAGE.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldLanguageCode", oldDIC_LANGUAGE.LanguageCode);
            if (oldDIC_LANGUAGE.LanguageName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldLanguageName", oldDIC_LANGUAGE.LanguageName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldLanguageName", DBNull.Value);
            }
            if (oldDIC_LANGUAGE.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_LANGUAGE.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_LANGUAGE.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_LANGUAGE.Active);
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

        public static bool Delete(DIC_LANGUAGE clsDIC_LANGUAGE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_LANGUAGE] "
                + "WHERE "
                + "     [LanguageCode] = @OldLanguageCode "
                + " AND ((@OldLanguageName IS NULL AND [LanguageName] IS NULL) OR [LanguageName] = @OldLanguageName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldLanguageCode", clsDIC_LANGUAGE.LanguageCode);
            if (clsDIC_LANGUAGE.LanguageName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldLanguageName", clsDIC_LANGUAGE.LanguageName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldLanguageName", DBNull.Value);
            }
            if (clsDIC_LANGUAGE.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_LANGUAGE.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_LANGUAGE.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_LANGUAGE.Active);
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
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [LanguageCode] AS [Mã Ngôn Ngữ]  ";
            sql = sql + "    ,[LanguageName] AS [Tên Ngôn Ngữ] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "    ,[Active]           AS [Còn Sử Dụng]    ";
            sql = sql + "FROM DIC_LANGUAGE ";
            sql = sql + "WHERE [Active] = 1";
            return Select_Table(sql);
        }

        public static DataTable Get_View_Data()
        {
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [LanguageCode] AS [Mã Ngôn Ngữ]  ";
            sql = sql + "    ,[LanguageName] AS [Tên Ngôn Ngữ] ";
            sql = sql + "FROM DIC_LANGUAGE ";
            sql = sql + "WHERE [Active] = 1";
            return Select_Table(sql);
        }

        public static bool Delete(string code)
        {
            return Delete("DIC_LANGUAGE", "LanguageCode", code);
        }
    }

}
