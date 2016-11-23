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
    public class DAO_DIC_PROFESSIONAL : DAO_BASE
    {
        public static DIC_PROFESSIONAL Select_Record(DIC_PROFESSIONAL clsDIC_PROFESSIONALPara)
        {
            DIC_PROFESSIONAL clsDIC_PROFESSIONAL = new DIC_PROFESSIONAL();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [ProfessionalCode] "
                + "    ,[ProfessionalName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "FROM "
                + "     [DIC_PROFESSIONAL] "
                + "WHERE "
                + "     [ProfessionalCode] = @ProfessionalCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@ProfessionalCode", clsDIC_PROFESSIONALPara.ProfessionalCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_PROFESSIONAL.ProfessionalCode = System.Convert.ToString(reader["ProfessionalCode"]);
                    clsDIC_PROFESSIONAL.ProfessionalName = reader["ProfessionalName"] is DBNull ? null : reader["ProfessionalName"].ToString();
                    clsDIC_PROFESSIONAL.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                    clsDIC_PROFESSIONAL.Active = reader["Active"] is DBNull ? null : (Boolean?)reader["Active"];
                }
                else
                {
                    clsDIC_PROFESSIONAL = null;
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
            return clsDIC_PROFESSIONAL;
        }

        public static bool Add(DIC_PROFESSIONAL clsDIC_PROFESSIONAL)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_PROFESSIONAL] "
                + "     ( "
                + "     [ProfessionalCode] "
                + "    ,[ProfessionalName] "
                + "    ,[Description] "
                + "    ,[Active] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @ProfessionalCode "
                + "    ,@ProfessionalName "
                + "    ,@Description "
                + "    ,@Active "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@ProfessionalCode", clsDIC_PROFESSIONAL.ProfessionalCode);
            if (clsDIC_PROFESSIONAL.ProfessionalName != null)
            {
                insertCommand.Parameters.AddWithValue("@ProfessionalName", clsDIC_PROFESSIONAL.ProfessionalName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ProfessionalName", DBNull.Value);
            }
            if (clsDIC_PROFESSIONAL.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_PROFESSIONAL.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
            }
            if (clsDIC_PROFESSIONAL.Active.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Active", clsDIC_PROFESSIONAL.Active);
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

        public static bool Update(DIC_PROFESSIONAL oldDIC_PROFESSIONAL,
               DIC_PROFESSIONAL newDIC_PROFESSIONAL)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_PROFESSIONAL] "
                + "SET "
                + "     [ProfessionalCode] = @NewProfessionalCode "
                + "    ,[ProfessionalName] = @NewProfessionalName "
                + "    ,[Description] = @NewDescription "
                + "    ,[Active] = @NewActive "
                + "WHERE "
                + "     [ProfessionalCode] = @OldProfessionalCode "
                + " AND ((@OldProfessionalName IS NULL AND [ProfessionalName] IS NULL) OR [ProfessionalName] = @OldProfessionalName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewProfessionalCode", newDIC_PROFESSIONAL.ProfessionalCode);
            if (newDIC_PROFESSIONAL.ProfessionalName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewProfessionalName", newDIC_PROFESSIONAL.ProfessionalName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewProfessionalName", DBNull.Value);
            }
            if (newDIC_PROFESSIONAL.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_PROFESSIONAL.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            if (newDIC_PROFESSIONAL.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewActive", newDIC_PROFESSIONAL.Active);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewActive", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldProfessionalCode", oldDIC_PROFESSIONAL.ProfessionalCode);
            if (oldDIC_PROFESSIONAL.ProfessionalName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldProfessionalName", oldDIC_PROFESSIONAL.ProfessionalName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldProfessionalName", DBNull.Value);
            }
            if (oldDIC_PROFESSIONAL.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_PROFESSIONAL.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (oldDIC_PROFESSIONAL.Active.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldActive", oldDIC_PROFESSIONAL.Active);
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

        public static bool Delete(DIC_PROFESSIONAL clsDIC_PROFESSIONAL)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_PROFESSIONAL] "
                + "WHERE "
                + "     [ProfessionalCode] = @OldProfessionalCode "
                + " AND ((@OldProfessionalName IS NULL AND [ProfessionalName] IS NULL) OR [ProfessionalName] = @OldProfessionalName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + " AND ((@OldActive IS NULL AND [Active] IS NULL) OR [Active] = @OldActive) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldProfessionalCode", clsDIC_PROFESSIONAL.ProfessionalCode);
            if (clsDIC_PROFESSIONAL.ProfessionalName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldProfessionalName", clsDIC_PROFESSIONAL.ProfessionalName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldProfessionalName", DBNull.Value);
            }
            if (clsDIC_PROFESSIONAL.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_PROFESSIONAL.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
            }
            if (clsDIC_PROFESSIONAL.Active.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldActive", clsDIC_PROFESSIONAL.Active);
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
            sql = sql + "     [ProfessionalCode] AS [Mã Chuyên Môn]  ";
            sql = sql + "    ,[ProfessionalName] AS [Tên Chuyên Môn] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "FROM DIC_PROFESSIONAL ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }
        public static DataTable Get_View_Data()
        {

            String sql = "";
            sql = sql + "SELECT ";
            sql = sql + "     [ProfessionalCode] AS [Mã Chuyên Môn]  ";
            sql = sql + "    ,[ProfessionalName] AS [Tên Chuyên Môn] ";
            sql = sql + "FROM DIC_PROFESSIONAL ";
            sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);
        }

        public static bool Delete(string code)
        {
            return Delete("DIC_PROFESSIONAL", "ProfessionalCode", code);
        }
    }

}
