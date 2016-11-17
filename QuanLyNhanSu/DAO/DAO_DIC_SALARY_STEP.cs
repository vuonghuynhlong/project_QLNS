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
    public class DAO_DIC_SALARY_STEP : DAO_BASE
    {
        public static DIC_SALARY_STEP Select_Record(DIC_SALARY_STEP clsDIC_SALARY_STEPPara)
        {
            DIC_SALARY_STEP clsDIC_SALARY_STEP = new DIC_SALARY_STEP();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [StepCode] "
                + "    ,[RankCode] "
                + "    ,[StepName] "
                + "    ,[Coefficient] "
                + "    ,[Description] "
                + "FROM "
                + "     [DIC_SALARY_STEP] "
                + "WHERE "
                + "     [StepCode] = @StepCode "
                + " AND [RankCode] = @RankCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@StepCode", clsDIC_SALARY_STEPPara.StepCode);
            selectCommand.Parameters.AddWithValue("@RankCode", clsDIC_SALARY_STEPPara.RankCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_SALARY_STEP.StepCode = System.Convert.ToInt32(reader["StepCode"]);
                    clsDIC_SALARY_STEP.RankCode = System.Convert.ToString(reader["RankCode"]);
                    clsDIC_SALARY_STEP.StepName = reader["StepName"] is DBNull ? null : reader["StepName"].ToString();
                    clsDIC_SALARY_STEP.Coefficient = reader["Coefficient"] is DBNull ? null : (Decimal?)(Double?)reader["Coefficient"];
                    clsDIC_SALARY_STEP.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                }
                else
                {
                    clsDIC_SALARY_STEP = null;
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
            return clsDIC_SALARY_STEP;
        }

        public static bool Add(DIC_SALARY_STEP clsDIC_SALARY_STEP)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [DIC_SALARY_STEP] "
                + "     ( "
                + "     [StepCode] "
                + "    ,[RankCode] "
                + "    ,[StepName] "
                + "    ,[Coefficient] "
                + "    ,[Description] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @StepCode "
                + "    ,@RankCode "
                + "    ,@StepName "
                + "    ,@Coefficient "
                + "    ,@Description "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@StepCode", clsDIC_SALARY_STEP.StepCode);
            insertCommand.Parameters.AddWithValue("@RankCode", clsDIC_SALARY_STEP.RankCode);
            if (clsDIC_SALARY_STEP.StepName != null)
            {
                insertCommand.Parameters.AddWithValue("@StepName", clsDIC_SALARY_STEP.StepName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@StepName", DBNull.Value);
            }
            if (clsDIC_SALARY_STEP.Coefficient.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Coefficient", clsDIC_SALARY_STEP.Coefficient);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Coefficient", DBNull.Value);
            }
            if (clsDIC_SALARY_STEP.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_SALARY_STEP.Description);
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

        public static bool Update(DIC_SALARY_STEP oldDIC_SALARY_STEP,
               DIC_SALARY_STEP newDIC_SALARY_STEP)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_SALARY_STEP] "
                + "SET "
                + "     [StepCode] = @NewStepCode "
                + "    ,[RankCode] = @NewRankCode "
                + "    ,[StepName] = @NewStepName "
                + "    ,[Coefficient] = @NewCoefficient "
                + "    ,[Description] = @NewDescription "
                + "WHERE "
                + "     [StepCode] = @OldStepCode "
                + " AND [RankCode] = @OldRankCode "
                + " AND ((@OldStepName IS NULL AND [StepName] IS NULL) OR [StepName] = @OldStepName) "
                + " AND ((@OldCoefficient IS NULL AND [Coefficient] IS NULL) OR [Coefficient] = @OldCoefficient) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewStepCode", newDIC_SALARY_STEP.StepCode);
            updateCommand.Parameters.AddWithValue("@NewRankCode", newDIC_SALARY_STEP.RankCode);
            if (newDIC_SALARY_STEP.StepName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewStepName", newDIC_SALARY_STEP.StepName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewStepName", DBNull.Value);
            }
            if (newDIC_SALARY_STEP.Coefficient.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewCoefficient", newDIC_SALARY_STEP.Coefficient);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewCoefficient", DBNull.Value);
            }
            if (newDIC_SALARY_STEP.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_SALARY_STEP.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldStepCode", oldDIC_SALARY_STEP.StepCode);
            updateCommand.Parameters.AddWithValue("@OldRankCode", oldDIC_SALARY_STEP.RankCode);
            if (oldDIC_SALARY_STEP.StepName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldStepName", oldDIC_SALARY_STEP.StepName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldStepName", DBNull.Value);
            }
            if (oldDIC_SALARY_STEP.Coefficient.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldCoefficient", oldDIC_SALARY_STEP.Coefficient);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldCoefficient", DBNull.Value);
            }
            if (oldDIC_SALARY_STEP.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_SALARY_STEP.Description);
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

        public static bool Delete(DIC_SALARY_STEP clsDIC_SALARY_STEP)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_SALARY_STEP] "
                + "WHERE "
                + "     [StepCode] = @OldStepCode "
                + " AND [RankCode] = @OldRankCode "
                + " AND ((@OldStepName IS NULL AND [StepName] IS NULL) OR [StepName] = @OldStepName) "
                + " AND ((@OldCoefficient IS NULL AND [Coefficient] IS NULL) OR [Coefficient] = @OldCoefficient) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldStepCode", clsDIC_SALARY_STEP.StepCode);
            deleteCommand.Parameters.AddWithValue("@OldRankCode", clsDIC_SALARY_STEP.RankCode);
            if (clsDIC_SALARY_STEP.StepName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldStepName", clsDIC_SALARY_STEP.StepName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldStepName", DBNull.Value);
            }
            if (clsDIC_SALARY_STEP.Coefficient.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldCoefficient", clsDIC_SALARY_STEP.Coefficient);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldCoefficient", DBNull.Value);
            }
            if (clsDIC_SALARY_STEP.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_SALARY_STEP.Description);
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
            sql = sql + "     [StepCode] AS [Mã Bậc]  ";
            sql = sql + "    ,[RankCode] AS [Mã Ngạch] ";
            sql = sql + "    ,[StepName] AS [Tên Bậc]";
            sql = sql + "    ,[Coefficient] AS [Hệ Số]";
            sql = sql + "    ,[Description]      AS [Mô Tả]          ";
            sql = sql + "FROM DIC_SALARY_STEP ";
            return Select_Table(sql);

        }
    }

}
