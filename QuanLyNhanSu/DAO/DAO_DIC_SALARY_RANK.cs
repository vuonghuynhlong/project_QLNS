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
    public class DAO_DIC_SALARY_RANK : DAO_BASE
    {
        public static DIC_SALARY_RANK Select_Record(DIC_SALARY_RANK clsDIC_SALARY_RANKPara)
        {
            DIC_SALARY_RANK clsDIC_SALARY_RANK = new DIC_SALARY_RANK();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [RankCode] "
                + "    ,[RankName] "
                + "    ,[Description] "
                + "FROM "
                + "     [DIC_SALARY_RANK] "
                + "WHERE "
                + "     [RankCode] = @RankCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@RankCode", clsDIC_SALARY_RANKPara.RankCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_SALARY_RANK.RankCode = System.Convert.ToString(reader["RankCode"]);
                    clsDIC_SALARY_RANK.RankName = reader["RankName"] is DBNull ? null : reader["RankName"].ToString();
                    clsDIC_SALARY_RANK.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                }
                else
                {
                    clsDIC_SALARY_RANK = null;
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
            return clsDIC_SALARY_RANK;
        }

        public static bool Add(DIC_SALARY_RANK clsDIC_SALARY_RANK)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_SALARY_RANK] "
                + "     ( "
                + "     [RankCode] "
                + "    ,[RankName] "
                + "    ,[Description] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @RankCode "
                + "    ,@RankName "
                + "    ,@Description "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@RankCode", clsDIC_SALARY_RANK.RankCode);
            if (clsDIC_SALARY_RANK.RankName != null)
            {
                insertCommand.Parameters.AddWithValue("@RankName", clsDIC_SALARY_RANK.RankName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@RankName", DBNull.Value);
            }
            if (clsDIC_SALARY_RANK.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_SALARY_RANK.Description);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Description", DBNull.Value);
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

        public static bool Update(DIC_SALARY_RANK oldDIC_SALARY_RANK,
               DIC_SALARY_RANK newDIC_SALARY_RANK)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_SALARY_RANK] "
                + "SET "
                + "     [RankCode] = @NewRankCode "
                + "    ,[RankName] = @NewRankName "
                + "    ,[Description] = @NewDescription "
                + "WHERE "
                + "     [RankCode] = @OldRankCode "
                + " AND ((@OldRankName IS NULL AND [RankName] IS NULL) OR [RankName] = @OldRankName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewRankCode", newDIC_SALARY_RANK.RankCode);
            if (newDIC_SALARY_RANK.RankName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewRankName", newDIC_SALARY_RANK.RankName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewRankName", DBNull.Value);
            }
            if (newDIC_SALARY_RANK.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_SALARY_RANK.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldRankCode", oldDIC_SALARY_RANK.RankCode);
            if (oldDIC_SALARY_RANK.RankName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldRankName", oldDIC_SALARY_RANK.RankName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldRankName", DBNull.Value);
            }
            if (oldDIC_SALARY_RANK.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_SALARY_RANK.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
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

        public static bool Delete(DIC_SALARY_RANK clsDIC_SALARY_RANK)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_SALARY_RANK] "
                + "WHERE "
                + "     [RankCode] = @OldRankCode "
                + " AND ((@OldRankName IS NULL AND [RankName] IS NULL) OR [RankName] = @OldRankName) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldRankCode", clsDIC_SALARY_RANK.RankCode);
            if (clsDIC_SALARY_RANK.RankName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldRankName", clsDIC_SALARY_RANK.RankName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldRankName", DBNull.Value);
            }
            if (clsDIC_SALARY_RANK.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_SALARY_RANK.Description);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", DBNull.Value);
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
            sql = sql + "     [RankCode] AS [Mã Ngạch]  ";
            sql = sql + "    ,[RankName] AS [Tên Ngạch] ";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "FROM DIC_SALARY_RANK ";
            return Select_Table(sql);

        }
    }

}
