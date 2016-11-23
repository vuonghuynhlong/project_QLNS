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
    public class DAO_DIC_INFORMATIC : DAO_BASE
    {
        public static DIC_INFORMATIC Select_Record(DIC_INFORMATIC clsDIC_INFORMATICPara)
        {
            DIC_INFORMATIC clsDIC_INFORMATIC = new DIC_INFORMATIC();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [InformaticCode] "
                + "    ,[InformaticName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_INFORMATIC] "
                + "WHERE "
                + "     [InformaticCode] = @InformaticCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@InformaticCode", clsDIC_INFORMATICPara.InformaticCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_INFORMATIC.InformaticCode = System.Convert.ToString(reader["InformaticCode"]);
                    clsDIC_INFORMATIC.InformaticName = reader["InformaticName"] is DBNull ? null : reader["InformaticName"].ToString();
                    clsDIC_INFORMATIC.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_INFORMATIC.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_INFORMATIC = null;
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
            return clsDIC_INFORMATIC;
        }

        public static bool Add(DIC_INFORMATIC clsDIC_INFORMATIC)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_INFORMATIC] "
                + "     ( "
                + "     [InformaticCode] "
                + "    ,[InformaticName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @InformaticCode "
                + "    ,@InformaticName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@InformaticCode", clsDIC_INFORMATIC.InformaticCode);
            if (clsDIC_INFORMATIC.InformaticName != null)
            {
                insertCommand.Parameters.AddWithValue("@InformaticName", clsDIC_INFORMATIC.InformaticName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@InformaticName", DBNull.Value);
            }
            if (clsDIC_INFORMATIC.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_INFORMATIC.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_INFORMATIC.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_INFORMATIC.Active);
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

        public static bool Update(DIC_INFORMATIC oldDIC_INFORMATIC,
               DIC_INFORMATIC newDIC_INFORMATIC)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_INFORMATIC] "
                + "SET "
                + "     [InformaticCode] = @NewInformaticCode "
                + "    ,[InformaticName] = @NewInformaticName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [InformaticCode] = @OldInformaticCode "
                + " AND ((@OldInformaticName IS NULL AND [InformaticName] IS NULL) OR [InformaticName] = @OldInformaticName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewInformaticCode", newDIC_INFORMATIC.InformaticCode);
            if (newDIC_INFORMATIC.InformaticName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewInformaticName", newDIC_INFORMATIC.InformaticName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewInformaticName", DBNull.Value);
            }
            if (newDIC_INFORMATIC.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_INFORMATIC.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_INFORMATIC.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_INFORMATIC.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldInformaticCode", oldDIC_INFORMATIC.InformaticCode);
            if (oldDIC_INFORMATIC.InformaticName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldInformaticName", oldDIC_INFORMATIC.InformaticName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldInformaticName", DBNull.Value);
            }
            if (oldDIC_INFORMATIC.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_INFORMATIC.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_INFORMATIC.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_INFORMATIC.Active);
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

        public static bool Delete(DIC_INFORMATIC clsDIC_INFORMATIC)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_INFORMATIC] "
                + "WHERE "
                + "     [InformaticCode] = @OldInformaticCode "
                + " AND ((@OldInformaticName IS NULL AND [InformaticName] IS NULL) OR [InformaticName] = @OldInformaticName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldInformaticCode", clsDIC_INFORMATIC.InformaticCode);
            if (clsDIC_INFORMATIC.InformaticName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldInformaticName", clsDIC_INFORMATIC.InformaticName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldInformaticName", DBNull.Value);
            }
            if (clsDIC_INFORMATIC.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_INFORMATIC.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_INFORMATIC.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_INFORMATIC.Active);
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
            sql = sql + "     [InformaticCode] AS [Mã Bằng Tin Học]  ";
            sql = sql + "    ,[InformaticName] AS [Tên Bằng Tin Học] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "FROM DIC_INFORMATIC ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static DataTable Get_View_Data()
        {
            string sql = "";
            sql = sql + "SELECT";
            sql = sql + "     [InformaticCode] AS [Mã Bằng Tin Học]  ";
            sql = sql + "    ,[InformaticName] AS [Tên Bằng Tin Học] ";
            sql = sql + "FROM DIC_INFORMATIC ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static bool Delete(string code)
        {
            return Delete("DIC_INFORMATIC", "InformaticCode", code);
        }
    }

}
