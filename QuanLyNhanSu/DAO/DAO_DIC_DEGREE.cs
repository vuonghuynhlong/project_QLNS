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
    public class DAO_DIC_DEGREE : DAO_BASE
    {
        public static DIC_DEGREE Select_Record(DIC_DEGREE clsDIC_DEGREEPara)
        {    
            DIC_DEGREE clsDIC_DEGREE = new DIC_DEGREE();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [DegreeCode] "
                + "    ,[DegreeName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_DEGREE] "
                + "WHERE "
                + "     [DegreeCode] = @DegreeCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@DegreeCode", clsDIC_DEGREEPara.DegreeCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_DEGREE.DegreeCode = System.Convert.ToString(reader["DegreeCode"]);
                    clsDIC_DEGREE.DegreeName = reader["DegreeName"] is DBNull ? null : reader["DegreeName"].ToString();
                    clsDIC_DEGREE.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_DEGREE.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_DEGREE = null;
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
            return clsDIC_DEGREE;
        }

        public static bool Add(DIC_DEGREE clsDIC_DEGREE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_DEGREE] "
                + "     ( "
                + "     [DegreeCode] "
                + "    ,[DegreeName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @DegreeCode "
                + "    ,@DegreeName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@DegreeCode", clsDIC_DEGREE.DegreeCode);
            if (clsDIC_DEGREE.DegreeName != null)
            {
                insertCommand.Parameters.AddWithValue("@DegreeName", clsDIC_DEGREE.DegreeName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@DegreeName", DBNull.Value);
            }
            if (clsDIC_DEGREE.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_DEGREE.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_DEGREE.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_DEGREE.Active);
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

        public static bool Update(DIC_DEGREE oldDIC_DEGREE,
               DIC_DEGREE newDIC_DEGREE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_DEGREE] "
                + "SET "
                + "     [DegreeCode] = @NewDegreeCode "
                + "    ,[DegreeName] = @NewDegreeName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [DegreeCode] = @OldDegreeCode "
                + " AND ((@OldDegreeName IS NULL AND [DegreeName] IS NULL) OR [DegreeName] = @OldDegreeName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewDegreeCode", newDIC_DEGREE.DegreeCode);
            if (newDIC_DEGREE.DegreeName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDegreeName", newDIC_DEGREE.DegreeName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDegreeName", DBNull.Value);
            }
            if (newDIC_DEGREE.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_DEGREE.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_DEGREE.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_DEGREE.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldDegreeCode", oldDIC_DEGREE.DegreeCode);
            if (oldDIC_DEGREE.DegreeName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDegreeName", oldDIC_DEGREE.DegreeName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDegreeName", DBNull.Value);
            }
            if (oldDIC_DEGREE.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_DEGREE.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_DEGREE.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_DEGREE.Active);
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

        public static bool Delete(DIC_DEGREE clsDIC_DEGREE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_DEGREE] "
                + "WHERE "
                + "     [DegreeCode] = @OldDegreeCode "
                + " AND ((@OldDegreeName IS NULL AND [DegreeName] IS NULL) OR [DegreeName] = @OldDegreeName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldDegreeCode", clsDIC_DEGREE.DegreeCode);
            if (clsDIC_DEGREE.DegreeName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDegreeName", clsDIC_DEGREE.DegreeName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDegreeName", DBNull.Value);
            }
            if (clsDIC_DEGREE.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_DEGREE.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_DEGREE.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_DEGREE.Active);
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
            sql = sql + "     [DegreeCode] AS [Mã Bằng Cấp]  ";
            sql = sql + "    ,[DegreeName] AS [Tên Bằng Cấp] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "    ,[Active]           AS [Còn Sử Dụng]    ";
            sql = sql + "FROM DIC_DEGREE ";
            return Select_Table(sql);
        }
        public static bool Delete(string code)
        {
            return Delete("DIC_DEGREE", "DegreeCode", code);
        }
    }

}
