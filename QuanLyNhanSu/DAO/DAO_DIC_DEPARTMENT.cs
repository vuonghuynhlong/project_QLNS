﻿using QuanLyNhanSu.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class DAO_DIC_DEPARTMENT : DAO_BASE
    {
        public static DIC_DEPARTMENT Select_Record(DIC_DEPARTMENT clsDIC_DEPARTMENTPara)
        {
            DIC_DEPARTMENT clsDIC_DEPARTMENT = new DIC_DEPARTMENT();
            SqlConnection connection = DAO_BASE.GetConnection();
            string selectStatement
                = "SELECT "
                + "     [DepartmentCode] "
                + "    ,[DepartmentName] "
                + "    ,[Phone] "
                + "    ,[Quantity] "
                + "    ,[FactQuantity] "
                + "    ,[Description] "
                + "FROM "
                + "     [DIC_DEPARTMENT] "
                + "WHERE "
                + "    [DepartmentCode] = @DepartmentCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@DepartmentCode", clsDIC_DEPARTMENTPara.DepartmentCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsDIC_DEPARTMENT.DepartmentCode = System.Convert.ToString(reader["DepartmentCode"]);
                    clsDIC_DEPARTMENT.DepartmentName = reader["DepartmentName"] is DBNull ? null : reader["DepartmentName"].ToString();
                    clsDIC_DEPARTMENT.Phone = reader["Phone"] is DBNull ? null : reader["Phone"].ToString();
                    clsDIC_DEPARTMENT.Quantity = reader["Quantity"] is DBNull ? null : (Int32?)reader["Quantity"];
                    clsDIC_DEPARTMENT.FactQuantity = reader["FactQuantity"] is DBNull ? null : (Int32?)reader["FactQuantity"];
                    clsDIC_DEPARTMENT.Description = reader["Description"] is DBNull ? null : reader["Description"].ToString();
                }
                else
                {
                    clsDIC_DEPARTMENT = null;
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
            return clsDIC_DEPARTMENT;
        }

        public static bool Add(DIC_DEPARTMENT clsDIC_DEPARTMENT)
        {
            SqlConnection connection = DAO_BASE.GetConnection();
            string insertStatement
                = "INSERT "
                + "     [DIC_DEPARTMENT] "
                + "     ( "
                + "     [DepartmentCode] "
                + "    ,[DepartmentName] "
                + "    ,[Phone] "
                + "    ,[Quantity] "
                + "    ,[FactQuantity] "
                + "    ,[Description] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @DepartmentCode "
                + "    ,@DepartmentName "
                + "    ,@Phone "
                + "    ,@Quantity "
                + "    ,@FactQuantity "
                + "    ,@Description "
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@DepartmentCode", clsDIC_DEPARTMENT.DepartmentCode);
            if (clsDIC_DEPARTMENT.DepartmentName != null)
            {
                insertCommand.Parameters.AddWithValue("@DepartmentName", clsDIC_DEPARTMENT.DepartmentName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@DepartmentName", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.Phone != null)
            {
                insertCommand.Parameters.AddWithValue("@Phone", clsDIC_DEPARTMENT.Phone);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Phone", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.Quantity.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Quantity", clsDIC_DEPARTMENT.Quantity);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Quantity", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.FactQuantity.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@FactQuantity", clsDIC_DEPARTMENT.FactQuantity);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@FactQuantity", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.Description != null)
            {
                insertCommand.Parameters.AddWithValue("@Description", clsDIC_DEPARTMENT.Description);
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

        public static bool Update(DIC_DEPARTMENT oldDIC_DEPARTMENT,
               DIC_DEPARTMENT newDIC_DEPARTMENT)
        {
            SqlConnection connection = DAO_BASE.GetConnection();
            string updateStatement
                = "UPDATE "
                + "     [DIC_DEPARTMENT] "
                + "SET "
                + "     [DepartmentCode] = @NewDepartmentCode "
                + "    ,[DepartmentName] = @NewDepartmentName "
                + "    ,[Phone] = @NewPhone "
                + "    ,[Quantity] = @NewQuantity "
                + "    ,[FactQuantity] = @NewFactQuantity "
                + "    ,[Description] = @NewDescription "
                + "WHERE "
                + "     [DepartmentCode] = @OldDepartmentCode "
                + " AND ((@OldDepartmentName IS NULL AND [DepartmentName] IS NULL) OR [DepartmentName] = @OldDepartmentName) "
                + " AND ((@OldPhone IS NULL AND [Phone] IS NULL) OR [Phone] = @OldPhone) "
                + " AND ((@OldQuantity IS NULL AND [Quantity] IS NULL) OR [Quantity] = @OldQuantity) "
                + " AND ((@OldFactQuantity IS NULL AND [FactQuantity] IS NULL) OR [FactQuantity] = @OldFactQuantity) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewDepartmentCode", newDIC_DEPARTMENT.DepartmentCode);
            if (newDIC_DEPARTMENT.DepartmentName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDepartmentName", newDIC_DEPARTMENT.DepartmentName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDepartmentName", DBNull.Value);
            }
            if (newDIC_DEPARTMENT.Phone != null)
            {
                updateCommand.Parameters.AddWithValue("@NewPhone", newDIC_DEPARTMENT.Phone);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPhone", DBNull.Value);
            }
            if (newDIC_DEPARTMENT.Quantity.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewQuantity", newDIC_DEPARTMENT.Quantity);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewQuantity", DBNull.Value);
            }
            if (newDIC_DEPARTMENT.FactQuantity.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewFactQuantity", newDIC_DEPARTMENT.FactQuantity);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewFactQuantity", DBNull.Value);
            }
            if (newDIC_DEPARTMENT.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", newDIC_DEPARTMENT.Description);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDescription", DBNull.Value);
            }
            updateCommand.Parameters.AddWithValue("@OldDepartmentCode", oldDIC_DEPARTMENT.DepartmentCode);
            if (oldDIC_DEPARTMENT.DepartmentName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDepartmentName", oldDIC_DEPARTMENT.DepartmentName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDepartmentName", DBNull.Value);
            }
            if (oldDIC_DEPARTMENT.Phone != null)
            {
                updateCommand.Parameters.AddWithValue("@OldPhone", oldDIC_DEPARTMENT.Phone);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPhone", DBNull.Value);
            }
            if (oldDIC_DEPARTMENT.Quantity.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldQuantity", oldDIC_DEPARTMENT.Quantity);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldQuantity", DBNull.Value);
            }
            if (oldDIC_DEPARTMENT.FactQuantity.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldFactQuantity", oldDIC_DEPARTMENT.FactQuantity);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldFactQuantity", DBNull.Value);
            }
            if (oldDIC_DEPARTMENT.Description != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDescription", oldDIC_DEPARTMENT.Description);
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

        public static bool Delete(DIC_DEPARTMENT clsDIC_DEPARTMENT)
        {
            SqlConnection connection = DAO_BASE.GetConnection();
            string deleteStatement
                = "DELETE FROM "
                + "     [DIC_DEPARTMENT] "
                + "WHERE "
                + "     [DepartmentCode] = @OldDepartmentCode "
                + " AND ((@OldDepartmentName IS NULL AND [DepartmentName] IS NULL) OR [DepartmentName] = @OldDepartmentName) "
                + " AND ((@OldPhone IS NULL AND [Phone] IS NULL) OR [Phone] = @OldPhone) "
                + " AND ((@OldQuantity IS NULL AND [Quantity] IS NULL) OR [Quantity] = @OldQuantity) "
                + " AND ((@OldFactQuantity IS NULL AND [FactQuantity] IS NULL) OR [FactQuantity] = @OldFactQuantity) "
                + " AND ((@OldDescription IS NULL AND [Description] IS NULL) OR [Description] = @OldDescription) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldDepartmentCode", clsDIC_DEPARTMENT.DepartmentCode);
            if (clsDIC_DEPARTMENT.DepartmentName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDepartmentName", clsDIC_DEPARTMENT.DepartmentName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDepartmentName", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.Phone != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldPhone", clsDIC_DEPARTMENT.Phone);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPhone", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.Quantity.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldQuantity", clsDIC_DEPARTMENT.Quantity);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldQuantity", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.FactQuantity.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldFactQuantity", clsDIC_DEPARTMENT.FactQuantity);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldFactQuantity", DBNull.Value);
            }
            if (clsDIC_DEPARTMENT.Description != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDescription", clsDIC_DEPARTMENT.Description);
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
            sql = sql + "     [DepartmentCode] AS [Mã Phòng Ban]  ";
            sql = sql + "    ,[DepartmentName] AS [Tên Phòng Ban] ";
            sql = sql + "    ,[Phone] AS [SĐT]";
            sql = sql + "    ,[Quantity] AS [Số Lượng]";
            sql = sql + "    ,[FactQuantity] AS [Số Lượng Thực Tế]";
            sql = sql + "    ,[Description] AS [Miêu tả]";
            sql = sql + "FROM DIC_DEPARTMENT ";
            //sql = sql + "WHERE [Active] = 1 ";
            return Select_Table(sql);

        }

        public static bool Delete(string code)
        {
            return Delete("DIC_DEPARTMENT", "DepartmentCode", code);
        }
        //internal static object Get_Data()
        //{
        //    throw new NotImplementedException();
        //}
    }

}
