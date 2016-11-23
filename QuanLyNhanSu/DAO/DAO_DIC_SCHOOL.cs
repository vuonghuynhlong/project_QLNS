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
    public class DAO_DIC_SCHOOL : DAO_BASE
    {
        public static DIC_SCHOOL Select_Record(DIC_SCHOOL clsDIC_SCHOOLPara)
        {
            DIC_SCHOOL clsDIC_SCHOOL = new DIC_SCHOOL();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [SchoolCode] "
                + "    ,[SchoolName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_SCHOOL] "
                + "WHERE "
                + "     [SchoolCode] = @SchoolCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@SchoolCode", clsDIC_SCHOOLPara.SchoolCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_SCHOOL.SchoolCode = System.Convert.ToString(reader["SchoolCode"]);
                    clsDIC_SCHOOL.SchoolName = reader["SchoolName"] is DBNull ? null : reader["SchoolName"].ToString();
                    clsDIC_SCHOOL.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_SCHOOL.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_SCHOOL = null;
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
            return clsDIC_SCHOOL;
        }

        public static bool Add(DIC_SCHOOL clsDIC_SCHOOL)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_SCHOOL] "
                + "     ( "
                + "     [SchoolCode] "
                + "    ,[SchoolName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @SchoolCode "
                + "    ,@SchoolName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@SchoolCode", clsDIC_SCHOOL.SchoolCode);
            if (clsDIC_SCHOOL.SchoolName != null)
            {
                insertCommand.Parameters.AddWithValue("@SchoolName", clsDIC_SCHOOL.SchoolName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@SchoolName", DBNull.Value);
            }
            if (clsDIC_SCHOOL.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_SCHOOL.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_SCHOOL.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_SCHOOL.Active);
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

        public static bool Update(DIC_SCHOOL oldDIC_SCHOOL,
               DIC_SCHOOL newDIC_SCHOOL)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_SCHOOL] "
                + "SET "
                + "     [SchoolCode] = @NewSchoolCode "
                + "    ,[SchoolName] = @NewSchoolName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [SchoolCode] = @OldSchoolCode "
                + " AND ((@OldSchoolName IS NULL AND [SchoolName] IS NULL) OR [SchoolName] = @OldSchoolName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewSchoolCode", newDIC_SCHOOL.SchoolCode);
            if (newDIC_SCHOOL.SchoolName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewSchoolName", newDIC_SCHOOL.SchoolName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewSchoolName", DBNull.Value);
            }
            if (newDIC_SCHOOL.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_SCHOOL.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_SCHOOL.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_SCHOOL.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldSchoolCode", oldDIC_SCHOOL.SchoolCode);
            if (oldDIC_SCHOOL.SchoolName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldSchoolName", oldDIC_SCHOOL.SchoolName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldSchoolName", DBNull.Value);
            }
            if (oldDIC_SCHOOL.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_SCHOOL.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_SCHOOL.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_SCHOOL.Active);
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

        public static bool Delete(DIC_SCHOOL clsDIC_SCHOOL)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_SCHOOL] "
                + "WHERE "
                + "     [SchoolCode] = @OldSchoolCode "
                + " AND ((@OldSchoolName IS NULL AND [SchoolName] IS NULL) OR [SchoolName] = @OldSchoolName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldSchoolCode", clsDIC_SCHOOL.SchoolCode);
            if (clsDIC_SCHOOL.SchoolName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldSchoolName", clsDIC_SCHOOL.SchoolName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldSchoolName", DBNull.Value);
            }
            if (clsDIC_SCHOOL.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_SCHOOL.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_SCHOOL.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_SCHOOL.Active);
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
            sql = sql + "     [SchoolCode] AS [Mã Trường]  ";
            sql = sql + "    ,[SchoolName] AS [Tên Trường] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "    ,[Active]           AS [Còn Sử Dụng]    ";
            sql = sql + "FROM DIC_SCHOOL ";
            return Select_Table(sql);

        }

        public static DataTable Get_View_Data()
        {

            String sql = "";
            sql = sql + "SELECT ";
            sql = sql + "     [SchoolCode] AS [Mã Trường]  ";
            sql = sql + "    ,[SchoolName] AS [Tên Trường] ";
            sql = sql + "FROM DIC_SCHOOL ";
            return Select_Table(sql);

        }


    }

}
