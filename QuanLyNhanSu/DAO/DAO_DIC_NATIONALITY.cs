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
    public class DAO_DIC_NATIONALITY : DAO_BASE
    {
        public static DIC_NATIONALITY Select_Record(DIC_NATIONALITY clsDIC_NATIONALITYPara)
        {
            DIC_NATIONALITY clsDIC_NATIONALITY = new DIC_NATIONALITY();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [NationalityCode] "
                + "    ,[NationalityName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_NATIONALITY] "
                + "WHERE "
                + "     [NationalityCode] = @NationalityCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@NationalityCode", clsDIC_NATIONALITYPara.NationalityCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_NATIONALITY.NationalityCode = System.Convert.ToString(reader["NationalityCode"]);
                    clsDIC_NATIONALITY.NationalityName = reader["NationalityName"] is DBNull ? null : reader["NationalityName"].ToString();
                    clsDIC_NATIONALITY.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_NATIONALITY.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_NATIONALITY = null;
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
            return clsDIC_NATIONALITY;
        }

        public static bool Add(DIC_NATIONALITY clsDIC_NATIONALITY)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_NATIONALITY] "
                + "     ( "
                + "     [NationalityCode] "
                + "    ,[NationalityName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @NationalityCode "
                + "    ,@NationalityName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@NationalityCode", clsDIC_NATIONALITY.NationalityCode);
            if (clsDIC_NATIONALITY.NationalityName != null)
            {
                insertCommand.Parameters.AddWithValue("@NationalityName", clsDIC_NATIONALITY.NationalityName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@NationalityName", DBNull.Value);
            }
            if (clsDIC_NATIONALITY.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_NATIONALITY.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_NATIONALITY.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_NATIONALITY.Active);
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

        public static bool Update(DIC_NATIONALITY oldDIC_NATIONALITY,
               DIC_NATIONALITY newDIC_NATIONALITY)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_NATIONALITY] "
                + "SET "
                + "     [NationalityCode] = @NewNationalityCode "
                + "    ,[NationalityName] = @NewNationalityName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [NationalityCode] = @OldNationalityCode "
                + " AND ((@OldNationalityName IS NULL AND [NationalityName] IS NULL) OR [NationalityName] = @OldNationalityName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewNationalityCode", newDIC_NATIONALITY.NationalityCode);
            if (newDIC_NATIONALITY.NationalityName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewNationalityName", newDIC_NATIONALITY.NationalityName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewNationalityName", DBNull.Value);
            }
            if (newDIC_NATIONALITY.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_NATIONALITY.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_NATIONALITY.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_NATIONALITY.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldNationalityCode", oldDIC_NATIONALITY.NationalityCode);
            if (oldDIC_NATIONALITY.NationalityName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldNationalityName", oldDIC_NATIONALITY.NationalityName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldNationalityName", DBNull.Value);
            }
            if (oldDIC_NATIONALITY.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_NATIONALITY.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_NATIONALITY.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_NATIONALITY.Active);
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

        public static bool Delete(DIC_NATIONALITY clsDIC_NATIONALITY)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_NATIONALITY] "
                + "WHERE "
                + "     [NationalityCode] = @OldNationalityCode "
                + " AND ((@OldNationalityName IS NULL AND [NationalityName] IS NULL) OR [NationalityName] = @OldNationalityName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldNationalityCode", clsDIC_NATIONALITY.NationalityCode);
            if (clsDIC_NATIONALITY.NationalityName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldNationalityName", clsDIC_NATIONALITY.NationalityName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldNationalityName", DBNull.Value);
            }
            if (clsDIC_NATIONALITY.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_NATIONALITY.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_NATIONALITY.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_NATIONALITY.Active);
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
            sql = sql + "     [NationalityCode] AS [Mã Quốc Tịch]  ";
            sql = sql + "    ,[NationalityName] AS [Tên Quốc Tịch] ";
            sql = sql + "    ,[Description]     AS [Mô Tả]     ";
            sql = sql + "FROM DIC_NATIONALITY ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static DataTable Get_View_Data()
        {
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [NationalityCode] AS [Mã Quốc Tịch]  ";
            sql = sql + "    ,[NationalityName] AS [Tên Quốc Tịch] ";
            //sql = sql + "    ,[Description]     AS [Mô Tả]     ";
            sql = sql + "FROM DIC_NATIONALITY ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static bool Delete(string code)
        {
            return Delete("DIC_NATIONALITY", "NationalityCode", code);
        }
    }

}
