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
    public class DAO_HRM_EMPLOYEE : DAO_BASE
    {
        public static HRM_EMPLOYEE Select_Record(HRM_EMPLOYEE clsHRM_EMPLOYEEPara)
        {
            HRM_EMPLOYEE clsHRM_EMPLOYEE = new HRM_EMPLOYEE();
            SqlConnection connection = DAO_BASE.Get_Connection();
            string selectStatement
                = "SELECT "
                + "     [EmployeeCode] "
                + "    ,[DepartmentCode] "
                + "    ,[EnrollNumber] "
                + "    ,[FirstName] "
                + "    ,[LastName] "
                + "    ,[Alias] "
                + "    ,[Sex] "
                + "    ,[Marriage] "
                + "    ,[Birthday] "
                + "    ,[BirthPlace] "
                + "    ,[MainAddress] "
                + "    ,[ContactAddress] "
                + "    ,[CellPhone] "
                + "    ,[Email] "
                + "    ,[Nationality] "
                + "    ,[Ethnic] "
                + "    ,[Religion] "
                + "    ,[Education] "
                + "    ,[Language] "
                + "    ,[Informatic] "
                + "    ,[Professional] "
                + "    ,[Position] "
                + "    ,[School] "
                + "    ,[IDCard] "
                + "    ,[IDCardDate] "
                + "    ,[IDCardPlace] "
                + "    ,[BeginDate] "
                + "    ,[IsOffWork] "
                + "    ,[EndDate] "
                + "    ,[PayForm] "
                + "    ,[PayMoney] "
                + "    ,[MinimumSalary] "
                + "    ,[RankSalary] "
                + "    ,[StepSalary] "
                + "    ,[CoefficientSalary] "
                + "    ,[DateSalary] "
                + "    ,[BasicSalary] "
                + "    ,[InsuranceSalary] "
                + "    ,[Allowance1] "
                + "    ,[Allowance2] "
                + "    ,[Allowance3] "
                + "    ,[Allowance4] "
                + "    ,[IsSocialInsurance] "
                + "    ,[IsHealthInsurance] "
                + "    ,[IsUnemploymentInsurance] "
                + "    ,[IsUnionMoney] "
                + "    ,[IsUnion] "
                + "    ,[UnionCode] "
                + "    ,[UnionDate] "
                + "    ,[UnionPlace] "
                + "    ,[IsParty] "
                + "    ,[PartyCode] "
                + "    ,[PartyDate] "
                + "    ,[PartyPlace] "
                + "    ,[InsuranceCode] "
                + "    ,[InsuranceDate] "
                + "    ,[HealthInsuranceCode] "
                + "    ,[HealthInsuranceFromDate] "
                + "    ,[HealthInsuranceToDate] "
                + "    ,[ContractCode] "
                + "    ,[ContractType] "
                + "    ,[ContractSignDate] "
                + "    ,[ContractFromDate] "
                + "    ,[ContractToDate] "
                + "    ,[Photo] "
                + "    ,[WorkStateCode] "
                
                + "FROM "
                + "     [HRM_EMPLOYEE] "
                + "WHERE "
                + "     [EmployeeCode] = @EmployeeCode "
                + "";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.CommandType = CommandType.Text;
            selectCommand.Parameters.AddWithValue("@EmployeeCode", clsHRM_EMPLOYEEPara.EmployeeCode);
            try
            {
                connection.Open();
                SqlDataReader reader
                    = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    clsHRM_EMPLOYEE.EmployeeCode = System.Convert.ToString(reader["EmployeeCode"]);
                    clsHRM_EMPLOYEE.DepartmentCode = reader["DepartmentCode"] is DBNull ? null : reader["DepartmentCode"].ToString();
                    clsHRM_EMPLOYEE.EnrollNumber = reader["EnrollNumber"] is DBNull ? null : reader["EnrollNumber"].ToString();
                    clsHRM_EMPLOYEE.FirstName = reader["FirstName"] is DBNull ? null : reader["FirstName"].ToString();
                    clsHRM_EMPLOYEE.LastName = reader["LastName"] is DBNull ? null : reader["LastName"].ToString();
                    clsHRM_EMPLOYEE.Alias = reader["Alias"] is DBNull ? null : reader["Alias"].ToString();
                 
                    clsHRM_EMPLOYEE.Sex = (bool)reader["Sex"];
                    clsHRM_EMPLOYEE.Marriage = reader["Marriage"] is DBNull ? null : reader["Marriage"].ToString();
                    clsHRM_EMPLOYEE.Birthday = reader["Birthday"] is DBNull ? null : (DateTime?)reader["Birthday"];
                    clsHRM_EMPLOYEE.BirthPlace = reader["BirthPlace"] is DBNull ? null : reader["BirthPlace"].ToString();
                    clsHRM_EMPLOYEE.MainAddress = reader["MainAddress"] is DBNull ? null : reader["MainAddress"].ToString();
                    clsHRM_EMPLOYEE.ContactAddress = reader["ContactAddress"] is DBNull ? null : reader["ContactAddress"].ToString();
                    clsHRM_EMPLOYEE.CellPhone = reader["CellPhone"] is DBNull ? null : reader["CellPhone"].ToString();
                    clsHRM_EMPLOYEE.Email = reader["Email"] is DBNull ? null : reader["Email"].ToString();
                    clsHRM_EMPLOYEE.Nationality = reader["Nationality"] is DBNull ? null : reader["Nationality"].ToString();
                    clsHRM_EMPLOYEE.Ethnic = reader["Ethnic"] is DBNull ? null : reader["Ethnic"].ToString();
                    clsHRM_EMPLOYEE.Religion = reader["Religion"] is DBNull ? null : reader["Religion"].ToString();
                    clsHRM_EMPLOYEE.Education = reader["Education"] is DBNull ? null : reader["Education"].ToString();
                    clsHRM_EMPLOYEE.Language = reader["Language"] is DBNull ? null : reader["Language"].ToString();
                    clsHRM_EMPLOYEE.Informatic = reader["Informatic"] is DBNull ? null : reader["Informatic"].ToString();
                    clsHRM_EMPLOYEE.Professional = reader["Professional"] is DBNull ? null : reader["Professional"].ToString();
                    clsHRM_EMPLOYEE.Position = reader["Position"] is DBNull ? null : reader["Position"].ToString();
                    clsHRM_EMPLOYEE.School = reader["School"] is DBNull ? null : reader["School"].ToString();
                    clsHRM_EMPLOYEE.IDCard = reader["IDCard"] is DBNull ? null : reader["IDCard"].ToString();
                    clsHRM_EMPLOYEE.IDCardDate = reader["IDCardDate"] is DBNull ? null : (DateTime?)reader["IDCardDate"];
                    clsHRM_EMPLOYEE.IDCardPlace = reader["IDCardPlace"] is DBNull ? null : reader["IDCardPlace"].ToString();
                    clsHRM_EMPLOYEE.BeginDate = reader["BeginDate"] is DBNull ? null : (DateTime?)reader["BeginDate"];
                    clsHRM_EMPLOYEE.IsOffWork = reader["IsOffWork"] is DBNull ? null : (Boolean?)reader["IsOffWork"];
                    clsHRM_EMPLOYEE.EndDate = reader["EndDate"] is DBNull ? null : (DateTime?)reader["EndDate"];
                    clsHRM_EMPLOYEE.PayForm = reader["PayForm"] is DBNull ? null : (Int32?)reader["PayForm"];
                    clsHRM_EMPLOYEE.PayMoney = reader["PayMoney"] is DBNull ? null : (Decimal?)reader["PayMoney"];
                    clsHRM_EMPLOYEE.MinimumSalary = reader["MinimumSalary"] is DBNull ? null : (Decimal?)reader["MinimumSalary"];
                    clsHRM_EMPLOYEE.RankSalary = reader["RankSalary"] is DBNull ? null : reader["RankSalary"].ToString();
                    clsHRM_EMPLOYEE.StepSalary = reader["StepSalary"] is DBNull ? null : (Int32?)reader["StepSalary"];
                    clsHRM_EMPLOYEE.CoefficientSalary = reader["CoefficientSalary"] is DBNull ? null : (Decimal?)(Double?)reader["CoefficientSalary"];
                    clsHRM_EMPLOYEE.DateSalary = reader["DateSalary"] is DBNull ? null : (DateTime?)reader["DateSalary"];
                    clsHRM_EMPLOYEE.BasicSalary = reader["BasicSalary"] is DBNull ? null : (Decimal?)reader["BasicSalary"];
                    clsHRM_EMPLOYEE.InsuranceSalary = reader["InsuranceSalary"] is DBNull ? null : (Decimal?)reader["InsuranceSalary"];
                    clsHRM_EMPLOYEE.Allowance1 = reader["Allowance1"] is DBNull ? null : (Decimal?)reader["Allowance1"];
                    clsHRM_EMPLOYEE.Allowance2 = reader["Allowance2"] is DBNull ? null : (Decimal?)reader["Allowance2"];
                    clsHRM_EMPLOYEE.Allowance3 = reader["Allowance3"] is DBNull ? null : (Decimal?)reader["Allowance3"];
                    clsHRM_EMPLOYEE.Allowance4 = reader["Allowance4"] is DBNull ? null : (Decimal?)reader["Allowance4"];
                    clsHRM_EMPLOYEE.IsSocialInsurance = reader["IsSocialInsurance"] is DBNull ? null : (Boolean?)reader["IsSocialInsurance"];
                    clsHRM_EMPLOYEE.IsHealthInsurance = reader["IsHealthInsurance"] is DBNull ? null : (Boolean?)reader["IsHealthInsurance"];
                    clsHRM_EMPLOYEE.IsUnemploymentInsurance = reader["IsUnemploymentInsurance"] is DBNull ? null : (Boolean?)reader["IsUnemploymentInsurance"];
                    clsHRM_EMPLOYEE.IsUnionMoney = reader["IsUnionMoney"] is DBNull ? null : (Boolean?)reader["IsUnionMoney"];
                    clsHRM_EMPLOYEE.IsUnion = reader["IsUnion"] is DBNull ? null : (Boolean?)reader["IsUnion"];
                    clsHRM_EMPLOYEE.UnionCode = reader["UnionCode"] is DBNull ? null : reader["UnionCode"].ToString();
                    clsHRM_EMPLOYEE.UnionDate = reader["UnionDate"] is DBNull ? null : (DateTime?)reader["UnionDate"];
                    clsHRM_EMPLOYEE.UnionPlace = reader["UnionPlace"] is DBNull ? null : reader["UnionPlace"].ToString();
                    clsHRM_EMPLOYEE.IsParty = reader["IsParty"] is DBNull ? null : (Boolean?)reader["IsParty"];
                    clsHRM_EMPLOYEE.PartyCode = reader["PartyCode"] is DBNull ? null : reader["PartyCode"].ToString();
                    clsHRM_EMPLOYEE.PartyDate = reader["PartyDate"] is DBNull ? null : (DateTime?)reader["PartyDate"];
                    clsHRM_EMPLOYEE.PartyPlace = reader["PartyPlace"] is DBNull ? null : reader["PartyPlace"].ToString();
                    clsHRM_EMPLOYEE.InsuranceCode = reader["InsuranceCode"] is DBNull ? null : reader["InsuranceCode"].ToString();
                    clsHRM_EMPLOYEE.InsuranceDate = reader["InsuranceDate"] is DBNull ? null : (DateTime?)reader["InsuranceDate"];
                    clsHRM_EMPLOYEE.HealthInsuranceCode = reader["HealthInsuranceCode"] is DBNull ? null : reader["HealthInsuranceCode"].ToString();
                    clsHRM_EMPLOYEE.HealthInsuranceFromDate = reader["HealthInsuranceFromDate"] is DBNull ? null : (DateTime?)reader["HealthInsuranceFromDate"];
                    clsHRM_EMPLOYEE.HealthInsuranceToDate = reader["HealthInsuranceToDate"] is DBNull ? null : (DateTime?)reader["HealthInsuranceToDate"];
                    clsHRM_EMPLOYEE.ContractCode = reader["ContractCode"] is DBNull ? null : reader["ContractCode"].ToString();
                    clsHRM_EMPLOYEE.ContractType = reader["ContractType"] is DBNull ? null : reader["ContractType"].ToString();
                    clsHRM_EMPLOYEE.ContractSignDate = reader["ContractSignDate"] is DBNull ? null : (DateTime?)reader["ContractSignDate"];
                    clsHRM_EMPLOYEE.ContractFromDate = reader["ContractFromDate"] is DBNull ? null : (DateTime?)reader["ContractFromDate"];
                    clsHRM_EMPLOYEE.ContractToDate = reader["ContractToDate"] is DBNull ? null : (DateTime?)reader["ContractToDate"];
                    clsHRM_EMPLOYEE.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];
                    clsHRM_EMPLOYEE.WorkStateCode = reader["WorkStateCode"] is DBNull ? null : reader["WorkStateCode"].ToString();
                }
                else
                {
                    clsHRM_EMPLOYEE = null;
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
            return clsHRM_EMPLOYEE;
        }

        public static bool Add(HRM_EMPLOYEE clsHRM_EMPLOYEE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string insertStatement
                = "INSERT "
                + "     [HRM_EMPLOYEE] "
                + "     ( "
                + "     [EmployeeCode] "
                + "    ,[DepartmentCode] "
                + "    ,[EnrollNumber] "
                + "    ,[FirstName] "
                + "    ,[LastName] "
                + "    ,[Alias] "
                + "    ,[Sex] "
                + "    ,[Marriage] "
                + "    ,[Birthday] "
                + "    ,[BirthPlace] "
                + "    ,[MainAddress] "
                + "    ,[ContactAddress] "
                + "    ,[CellPhone] "
                + "    ,[Email] "
                + "    ,[Nationality] "
                + "    ,[Ethnic] "
                + "    ,[Religion] "
                + "    ,[Education] "
                + "    ,[Language] "
                + "    ,[Informatic] "
                + "    ,[Professional] "
                + "    ,[Position] "
                + "    ,[School] "
                + "    ,[IDCard] "
                + "    ,[IDCardDate] "
                + "    ,[IDCardPlace] "
                + "    ,[BeginDate] "
                + "    ,[IsOffWork] "
                + "    ,[EndDate] "
                + "    ,[PayForm] "
                + "    ,[PayMoney] "
                + "    ,[MinimumSalary] "
                + "    ,[RankSalary] "
                + "    ,[StepSalary] "
                + "    ,[CoefficientSalary] "
                + "    ,[DateSalary] "
                + "    ,[BasicSalary] "
                + "    ,[InsuranceSalary] "
                + "    ,[Allowance1] "
                + "    ,[Allowance2] "
                + "    ,[Allowance3] "
                + "    ,[Allowance4] "
                + "    ,[IsSocialInsurance] "
                + "    ,[IsHealthInsurance] "
                + "    ,[IsUnemploymentInsurance] "
                + "    ,[IsUnionMoney] "
                + "    ,[IsUnion] "
                + "    ,[UnionCode] "
                + "    ,[UnionDate] "
                + "    ,[UnionPlace] "
                + "    ,[IsParty] "
                + "    ,[PartyCode] "
                + "    ,[PartyDate] "
                + "    ,[PartyPlace] "
                + "    ,[InsuranceCode] "
                + "    ,[InsuranceDate] "
                + "    ,[HealthInsuranceCode] "
                + "    ,[HealthInsuranceFromDate] "
                + "    ,[HealthInsuranceToDate] "
                + "    ,[ContractCode] "
                + "    ,[ContractType] "
                + "    ,[ContractSignDate] "
                + "    ,[ContractFromDate] "
                + "    ,[ContractToDate] "
                + "    ,[WorkStateCode] "
                + "    ,[Photo] "
                + "     ) "
                + "VALUES "
                + "     ( "
                + "     @EmployeeCode "
                + "    ,@DepartmentCode "
                + "    ,@EnrollNumber "
                + "    ,@FirstName "
                + "    ,@LastName "
                + "    ,@Alias "
                + "    ,@Sex "
                + "    ,@Marriage "
                + "    ,@Birthday "
                + "    ,@BirthPlace "
                + "    ,@MainAddress "
                + "    ,@ContactAddress "
                + "    ,@CellPhone "
                + "    ,@Email "
                + "    ,@Nationality "
                + "    ,@Ethnic "
                + "    ,@Religion "
                + "    ,@Education "
                + "    ,@Language "
                + "    ,@Informatic "
                + "    ,@Professional "
                + "    ,@Position "
                + "    ,@School "
                + "    ,@IDCard "
                + "    ,@IDCardDate "
                + "    ,@IDCardPlace "
                + "    ,@BeginDate "
                + "    ,@IsOffWork "
                + "    ,@EndDate "
                + "    ,@PayForm "
                + "    ,@PayMoney "
                + "    ,@MinimumSalary "
                + "    ,@RankSalary "
                + "    ,@StepSalary "
                + "    ,@CoefficientSalary "
                + "    ,@DateSalary "
                + "    ,@BasicSalary "
                + "    ,@InsuranceSalary "
                + "    ,@Allowance1 "
                + "    ,@Allowance2 "
                + "    ,@Allowance3 "
                + "    ,@Allowance4 "
                + "    ,@IsSocialInsurance "
                + "    ,@IsHealthInsurance "
                + "    ,@IsUnemploymentInsurance "
                + "    ,@IsUnionMoney "
                + "    ,@IsUnion "
                + "    ,@UnionCode "
                + "    ,@UnionDate "
                + "    ,@UnionPlace "
                + "    ,@IsParty "
                + "    ,@PartyCode "
                + "    ,@PartyDate "
                + "    ,@PartyPlace "
                + "    ,@InsuranceCode "
                + "    ,@InsuranceDate "
                + "    ,@HealthInsuranceCode "
                + "    ,@HealthInsuranceFromDate "
                + "    ,@HealthInsuranceToDate "
                + "    ,@ContractCode "
                + "    ,@ContractType "
                + "    ,@ContractSignDate "
                + "    ,@ContractFromDate "
                + "    ,@ContractToDate "
                + "    ,@WorkStateCode "
                + "    ,@Photo"

                
                + "     ) "
                + "";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.CommandType = CommandType.Text;
            insertCommand.Parameters.AddWithValue("@EmployeeCode", clsHRM_EMPLOYEE.EmployeeCode);
            if (clsHRM_EMPLOYEE.DepartmentCode != null)
            {
                insertCommand.Parameters.AddWithValue("@DepartmentCode", clsHRM_EMPLOYEE.DepartmentCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@DepartmentCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.EnrollNumber != null)
            {
                insertCommand.Parameters.AddWithValue("@EnrollNumber", clsHRM_EMPLOYEE.EnrollNumber);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@EnrollNumber", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.FirstName != null)
            {
                insertCommand.Parameters.AddWithValue("@FirstName", clsHRM_EMPLOYEE.FirstName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@FirstName", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.LastName != null)
            {
                insertCommand.Parameters.AddWithValue("@LastName", clsHRM_EMPLOYEE.LastName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@LastName", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Alias != null)
            {
                insertCommand.Parameters.AddWithValue("@Alias", clsHRM_EMPLOYEE.Alias);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Alias", DBNull.Value);
            }

            insertCommand.Parameters.AddWithValue("@Sex", clsHRM_EMPLOYEE.Sex);
            
            if (clsHRM_EMPLOYEE.Marriage != null)
            {
                insertCommand.Parameters.AddWithValue("@Marriage", clsHRM_EMPLOYEE.Marriage);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Marriage", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Birthday.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Birthday", clsHRM_EMPLOYEE.Birthday);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Birthday", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.BirthPlace != null)
            {
                insertCommand.Parameters.AddWithValue("@BirthPlace", clsHRM_EMPLOYEE.BirthPlace);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@BirthPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.MainAddress != null)
            {
                insertCommand.Parameters.AddWithValue("@MainAddress", clsHRM_EMPLOYEE.MainAddress);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@MainAddress", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContactAddress != null)
            {
                insertCommand.Parameters.AddWithValue("@ContactAddress", clsHRM_EMPLOYEE.ContactAddress);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ContactAddress", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.CellPhone != null)
            {
                insertCommand.Parameters.AddWithValue("@CellPhone", clsHRM_EMPLOYEE.CellPhone);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@CellPhone", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Email != null)
            {
                insertCommand.Parameters.AddWithValue("@Email", clsHRM_EMPLOYEE.Email);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Nationality != null)
            {
                insertCommand.Parameters.AddWithValue("@Nationality", clsHRM_EMPLOYEE.Nationality);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Nationality", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Ethnic != null)
            {
                insertCommand.Parameters.AddWithValue("@Ethnic", clsHRM_EMPLOYEE.Ethnic);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Ethnic", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Religion != null)
            {
                insertCommand.Parameters.AddWithValue("@Religion", clsHRM_EMPLOYEE.Religion);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Religion", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Education != null)
            {
                insertCommand.Parameters.AddWithValue("@Education", clsHRM_EMPLOYEE.Education);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Education", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Language != null)
            {
                insertCommand.Parameters.AddWithValue("@Language", clsHRM_EMPLOYEE.Language);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Language", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Informatic != null)
            {
                insertCommand.Parameters.AddWithValue("@Informatic", clsHRM_EMPLOYEE.Informatic);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Informatic", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Professional != null)
            {
                insertCommand.Parameters.AddWithValue("@Professional", clsHRM_EMPLOYEE.Professional);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Professional", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Position != null)
            {
                insertCommand.Parameters.AddWithValue("@Position", clsHRM_EMPLOYEE.Position);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Position", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.School != null)
            {
                insertCommand.Parameters.AddWithValue("@School", clsHRM_EMPLOYEE.School);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@School", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IDCard != null)
            {
                insertCommand.Parameters.AddWithValue("@IDCard", clsHRM_EMPLOYEE.IDCard);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IDCard", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IDCardDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IDCardDate", clsHRM_EMPLOYEE.IDCardDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IDCardDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IDCardPlace != null)
            {
                insertCommand.Parameters.AddWithValue("@IDCardPlace", clsHRM_EMPLOYEE.IDCardPlace);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IDCardPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.BeginDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@BeginDate", clsHRM_EMPLOYEE.BeginDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@BeginDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsOffWork.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsOffWork", clsHRM_EMPLOYEE.IsOffWork);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsOffWork", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.EndDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@EndDate", clsHRM_EMPLOYEE.EndDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@EndDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PayForm.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@PayForm", clsHRM_EMPLOYEE.PayForm);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PayForm", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PayMoney.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@PayMoney", clsHRM_EMPLOYEE.PayMoney);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PayMoney", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.MinimumSalary.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@MinimumSalary", clsHRM_EMPLOYEE.MinimumSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@MinimumSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.RankSalary != null)
            {
                insertCommand.Parameters.AddWithValue("@RankSalary", clsHRM_EMPLOYEE.RankSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@RankSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.StepSalary.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@StepSalary", clsHRM_EMPLOYEE.StepSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@StepSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.CoefficientSalary.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@CoefficientSalary", clsHRM_EMPLOYEE.CoefficientSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@CoefficientSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.DateSalary.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@DateSalary", clsHRM_EMPLOYEE.DateSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@DateSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.BasicSalary.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@BasicSalary", clsHRM_EMPLOYEE.BasicSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@BasicSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.InsuranceSalary.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@InsuranceSalary", clsHRM_EMPLOYEE.InsuranceSalary);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@InsuranceSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance1.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Allowance1", clsHRM_EMPLOYEE.Allowance1);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Allowance1", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance2.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Allowance2", clsHRM_EMPLOYEE.Allowance2);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Allowance2", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance3.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Allowance3", clsHRM_EMPLOYEE.Allowance3);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Allowance3", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance4.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@Allowance4", clsHRM_EMPLOYEE.Allowance4);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Allowance4", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsSocialInsurance.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsSocialInsurance", clsHRM_EMPLOYEE.IsSocialInsurance);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsSocialInsurance", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsHealthInsurance.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsHealthInsurance", clsHRM_EMPLOYEE.IsHealthInsurance);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsHealthInsurance", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsUnemploymentInsurance.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsUnemploymentInsurance", clsHRM_EMPLOYEE.IsUnemploymentInsurance);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsUnemploymentInsurance", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsUnionMoney.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsUnionMoney", clsHRM_EMPLOYEE.IsUnionMoney);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsUnionMoney", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsUnion.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsUnion", clsHRM_EMPLOYEE.IsUnion);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsUnion", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.UnionCode != null)
            {
                insertCommand.Parameters.AddWithValue("@UnionCode", clsHRM_EMPLOYEE.UnionCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@UnionCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.UnionDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@UnionDate", clsHRM_EMPLOYEE.UnionDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@UnionDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.UnionPlace != null)
            {
                insertCommand.Parameters.AddWithValue("@UnionPlace", clsHRM_EMPLOYEE.UnionPlace);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@UnionPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsParty.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@IsParty", clsHRM_EMPLOYEE.IsParty);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@IsParty", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PartyCode != null)
            {
                insertCommand.Parameters.AddWithValue("@PartyCode", clsHRM_EMPLOYEE.PartyCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PartyCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PartyDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@PartyDate", clsHRM_EMPLOYEE.PartyDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PartyDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PartyPlace != null)
            {
                insertCommand.Parameters.AddWithValue("@PartyPlace", clsHRM_EMPLOYEE.PartyPlace);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@PartyPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.InsuranceCode != null)
            {
                insertCommand.Parameters.AddWithValue("@InsuranceCode", clsHRM_EMPLOYEE.InsuranceCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@InsuranceCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.InsuranceDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@InsuranceDate", clsHRM_EMPLOYEE.InsuranceDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@InsuranceDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.HealthInsuranceCode != null)
            {
                insertCommand.Parameters.AddWithValue("@HealthInsuranceCode", clsHRM_EMPLOYEE.HealthInsuranceCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@HealthInsuranceCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.HealthInsuranceFromDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@HealthInsuranceFromDate", clsHRM_EMPLOYEE.HealthInsuranceFromDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@HealthInsuranceFromDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.HealthInsuranceToDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@HealthInsuranceToDate", clsHRM_EMPLOYEE.HealthInsuranceToDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@HealthInsuranceToDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractCode != null)
            {
                insertCommand.Parameters.AddWithValue("@ContractCode", clsHRM_EMPLOYEE.ContractCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ContractCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractType != null)
            {
                insertCommand.Parameters.AddWithValue("@ContractType", clsHRM_EMPLOYEE.ContractType);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ContractType", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractSignDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@ContractSignDate", clsHRM_EMPLOYEE.ContractSignDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ContractSignDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractFromDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@ContractFromDate", clsHRM_EMPLOYEE.ContractFromDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ContractFromDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractToDate.HasValue == true)
            {
                insertCommand.Parameters.AddWithValue("@ContractToDate", clsHRM_EMPLOYEE.ContractToDate);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@ContractToDate", DBNull.Value);
            }
            
            if (clsHRM_EMPLOYEE.WorkStateCode != null)
            {
                insertCommand.Parameters.AddWithValue("@WorkStateCode", clsHRM_EMPLOYEE.WorkStateCode);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@WorkStateCode", DBNull.Value);
            }

            if (clsHRM_EMPLOYEE.Photo != null)
            {
                insertCommand.Parameters.AddWithValue("@Photo", clsHRM_EMPLOYEE.Photo);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Photo", DBNull.Value);
            }
            try
            {
                connection.Open();
                string query = insertCommand.CommandText;

                foreach (SqlParameter p in insertCommand.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }
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

        public static bool Update(HRM_EMPLOYEE oldHRM_EMPLOYEE,
               HRM_EMPLOYEE newHRM_EMPLOYEE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string updateStatement
                = "UPDATE "
                + "     [HRM_EMPLOYEE] "
                + "SET "
                + "     [EmployeeCode] = @NewEmployeeCode "
                + "    ,[DepartmentCode] = @NewDepartmentCode "
                + "    ,[EnrollNumber] = @NewEnrollNumber "
                + "    ,[FirstName] = @NewFirstName "
                + "    ,[LastName] = @NewLastName "
                + "    ,[Alias] = @NewAlias "
                + "    ,[Sex] = @NewSex "
                + "    ,[Marriage] = @NewMarriage "
                + "    ,[Birthday] = @NewBirthday "
                + "    ,[BirthPlace] = @NewBirthPlace "
                + "    ,[MainAddress] = @NewMainAddress "
                + "    ,[ContactAddress] = @NewContactAddress "
                + "    ,[CellPhone] = @NewCellPhone "
                + "    ,[Email] = @NewEmail "
                + "    ,[Nationality] = @NewNationality "
                + "    ,[Ethnic] = @NewEthnic "
                + "    ,[Religion] = @NewReligion "
                + "    ,[Education] = @NewEducation "
                + "    ,[Language] = @NewLanguage "
                + "    ,[Informatic] = @NewInformatic "
                + "    ,[Professional] = @NewProfessional "
                + "    ,[Position] = @NewPosition "
                + "    ,[School] = @NewSchool "
                + "    ,[IDCard] = @NewIDCard "
                + "    ,[IDCardDate] = @NewIDCardDate "
                + "    ,[IDCardPlace] = @NewIDCardPlace "
                + "    ,[BeginDate] = @NewBeginDate "
                + "    ,[IsOffWork] = @NewIsOffWork "
                + "    ,[EndDate] = @NewEndDate "
                + "    ,[PayForm] = @NewPayForm "
                + "    ,[PayMoney] = @NewPayMoney "
                + "    ,[MinimumSalary] = @NewMinimumSalary "
                + "    ,[RankSalary] = @NewRankSalary "
                + "    ,[StepSalary] = @NewStepSalary "
                + "    ,[CoefficientSalary] = @NewCoefficientSalary "
                + "    ,[DateSalary] = @NewDateSalary "
                + "    ,[BasicSalary] = @NewBasicSalary "
                + "    ,[InsuranceSalary] = @NewInsuranceSalary "
                + "    ,[Allowance1] = @NewAllowance1 "
                + "    ,[Allowance2] = @NewAllowance2 "
                + "    ,[Allowance3] = @NewAllowance3 "
                + "    ,[Allowance4] = @NewAllowance4 "
                + "    ,[IsSocialInsurance] = @NewIsSocialInsurance "
                + "    ,[IsHealthInsurance] = @NewIsHealthInsurance "
                + "    ,[IsUnemploymentInsurance] = @NewIsUnemploymentInsurance "
                + "    ,[IsUnionMoney] = @NewIsUnionMoney "
                + "    ,[IsUnion] = @NewIsUnion "
                + "    ,[UnionCode] = @NewUnionCode "
                + "    ,[UnionDate] = @NewUnionDate "
                + "    ,[UnionPlace] = @NewUnionPlace "
                + "    ,[IsParty] = @NewIsParty "
                + "    ,[PartyCode] = @NewPartyCode "
                + "    ,[PartyDate] = @NewPartyDate "
                + "    ,[PartyPlace] = @NewPartyPlace "
                + "    ,[InsuranceCode] = @NewInsuranceCode "
                + "    ,[InsuranceDate] = @NewInsuranceDate "
                + "    ,[HealthInsuranceCode] = @NewHealthInsuranceCode "
                + "    ,[HealthInsuranceFromDate] = @NewHealthInsuranceFromDate "
                + "    ,[HealthInsuranceToDate] = @NewHealthInsuranceToDate "
                + "    ,[ContractCode] = @NewContractCode "
                + "    ,[ContractType] = @NewContractType "
                + "    ,[ContractSignDate] = @NewContractSignDate "
                + "    ,[ContractFromDate] = @NewContractFromDate "
                + "    ,[ContractToDate] = @NewContractToDate "
                + "    ,[Photo] = @NewPhoto "
                + "    ,[WorkStateCode] = @NewWorkStateCode "
                + "WHERE "
                + "     [EmployeeCode] = @OldEmployeeCode "
                + " AND ((@OldDepartmentCode IS NULL AND [DepartmentCode] IS NULL) OR [DepartmentCode] = @OldDepartmentCode) "
                + " AND ((@OldEnrollNumber IS NULL AND [EnrollNumber] IS NULL) OR [EnrollNumber] = @OldEnrollNumber) "
                + " AND ((@OldFirstName IS NULL AND [FirstName] IS NULL) OR [FirstName] = @OldFirstName) "
                + " AND ((@OldLastName IS NULL AND [LastName] IS NULL) OR [LastName] = @OldLastName) "
                + " AND ((@OldAlias IS NULL AND [Alias] IS NULL) OR [Alias] = @OldAlias) "
                + " AND ((@OldSex IS NULL AND [Sex] IS NULL) OR [Sex] = @OldSex) "
                + " AND ((@OldMarriage IS NULL AND [Marriage] IS NULL) OR [Marriage] = @OldMarriage) "
                + " AND ((@OldBirthday IS NULL AND [Birthday] IS NULL) OR [Birthday] = @OldBirthday) "
                + " AND ((@OldBirthPlace IS NULL AND [BirthPlace] IS NULL) OR [BirthPlace] = @OldBirthPlace) "
                + " AND ((@OldMainAddress IS NULL AND [MainAddress] IS NULL) OR [MainAddress] = @OldMainAddress) "
                + " AND ((@OldContactAddress IS NULL AND [ContactAddress] IS NULL) OR [ContactAddress] = @OldContactAddress) "
                + " AND ((@OldCellPhone IS NULL AND [CellPhone] IS NULL) OR [CellPhone] = @OldCellPhone) "
                + " AND ((@OldEmail IS NULL AND [Email] IS NULL) OR [Email] = @OldEmail) "
                + " AND ((@OldNationality IS NULL AND [Nationality] IS NULL) OR [Nationality] = @OldNationality) "
                + " AND ((@OldEthnic IS NULL AND [Ethnic] IS NULL) OR [Ethnic] = @OldEthnic) "
                + " AND ((@OldReligion IS NULL AND [Religion] IS NULL) OR [Religion] = @OldReligion) "
                + " AND ((@OldEducation IS NULL AND [Education] IS NULL) OR [Education] = @OldEducation) "
                + " AND ((@OldLanguage IS NULL AND [Language] IS NULL) OR [Language] = @OldLanguage) "
                + " AND ((@OldInformatic IS NULL AND [Informatic] IS NULL) OR [Informatic] = @OldInformatic) "
                + " AND ((@OldProfessional IS NULL AND [Professional] IS NULL) OR [Professional] = @OldProfessional) "
                + " AND ((@OldPosition IS NULL AND [Position] IS NULL) OR [Position] = @OldPosition) "
                + " AND ((@OldSchool IS NULL AND [School] IS NULL) OR [School] = @OldSchool) "
                + " AND ((@OldIDCard IS NULL AND [IDCard] IS NULL) OR [IDCard] = @OldIDCard) "
                + " AND ((@OldIDCardDate IS NULL AND [IDCardDate] IS NULL) OR [IDCardDate] = @OldIDCardDate) "
                + " AND ((@OldIDCardPlace IS NULL AND [IDCardPlace] IS NULL) OR [IDCardPlace] = @OldIDCardPlace) "
                + " AND ((@OldBeginDate IS NULL AND [BeginDate] IS NULL) OR [BeginDate] = @OldBeginDate) "
                + " AND ((@OldIsOffWork IS NULL AND [IsOffWork] IS NULL) OR [IsOffWork] = @OldIsOffWork) "
                + " AND ((@OldEndDate IS NULL AND [EndDate] IS NULL) OR [EndDate] = @OldEndDate) "
                + " AND ((@OldPayForm IS NULL AND [PayForm] IS NULL) OR [PayForm] = @OldPayForm) "
                + " AND ((@OldPayMoney IS NULL AND [PayMoney] IS NULL) OR [PayMoney] = @OldPayMoney) "
                + " AND ((@OldMinimumSalary IS NULL AND [MinimumSalary] IS NULL) OR [MinimumSalary] = @OldMinimumSalary) "
                + " AND ((@OldRankSalary IS NULL AND [RankSalary] IS NULL) OR [RankSalary] = @OldRankSalary) "
                + " AND ((@OldStepSalary IS NULL AND [StepSalary] IS NULL) OR [StepSalary] = @OldStepSalary) "
                + " AND ((@OldCoefficientSalary IS NULL AND [CoefficientSalary] IS NULL) OR [CoefficientSalary] = @OldCoefficientSalary) "
                + " AND ((@OldDateSalary IS NULL AND [DateSalary] IS NULL) OR [DateSalary] = @OldDateSalary) "
                + " AND ((@OldBasicSalary IS NULL AND [BasicSalary] IS NULL) OR [BasicSalary] = @OldBasicSalary) "
                + " AND ((@OldInsuranceSalary IS NULL AND [InsuranceSalary] IS NULL) OR [InsuranceSalary] = @OldInsuranceSalary) "
                + " AND ((@OldAllowance1 IS NULL AND [Allowance1] IS NULL) OR [Allowance1] = @OldAllowance1) "
                + " AND ((@OldAllowance2 IS NULL AND [Allowance2] IS NULL) OR [Allowance2] = @OldAllowance2) "
                + " AND ((@OldAllowance3 IS NULL AND [Allowance3] IS NULL) OR [Allowance3] = @OldAllowance3) "
                + " AND ((@OldAllowance4 IS NULL AND [Allowance4] IS NULL) OR [Allowance4] = @OldAllowance4) "
                + " AND ((@OldIsSocialInsurance IS NULL AND [IsSocialInsurance] IS NULL) OR [IsSocialInsurance] = @OldIsSocialInsurance) "
                + " AND ((@OldIsHealthInsurance IS NULL AND [IsHealthInsurance] IS NULL) OR [IsHealthInsurance] = @OldIsHealthInsurance) "
                + " AND ((@OldIsUnemploymentInsurance IS NULL AND [IsUnemploymentInsurance] IS NULL) OR [IsUnemploymentInsurance] = @OldIsUnemploymentInsurance) "
                + " AND ((@OldIsUnionMoney IS NULL AND [IsUnionMoney] IS NULL) OR [IsUnionMoney] = @OldIsUnionMoney) "
                + " AND ((@OldIsUnion IS NULL AND [IsUnion] IS NULL) OR [IsUnion] = @OldIsUnion) "
                + " AND ((@OldUnionCode IS NULL AND [UnionCode] IS NULL) OR [UnionCode] = @OldUnionCode) "
                + " AND ((@OldUnionDate IS NULL AND [UnionDate] IS NULL) OR [UnionDate] = @OldUnionDate) "
                + " AND ((@OldUnionPlace IS NULL AND [UnionPlace] IS NULL) OR [UnionPlace] = @OldUnionPlace) "
                + " AND ((@OldIsParty IS NULL AND [IsParty] IS NULL) OR [IsParty] = @OldIsParty) "
                + " AND ((@OldPartyCode IS NULL AND [PartyCode] IS NULL) OR [PartyCode] = @OldPartyCode) "
                + " AND ((@OldPartyDate IS NULL AND [PartyDate] IS NULL) OR [PartyDate] = @OldPartyDate) "
                + " AND ((@OldPartyPlace IS NULL AND [PartyPlace] IS NULL) OR [PartyPlace] = @OldPartyPlace) "
                + " AND ((@OldInsuranceCode IS NULL AND [InsuranceCode] IS NULL) OR [InsuranceCode] = @OldInsuranceCode) "
                + " AND ((@OldInsuranceDate IS NULL AND [InsuranceDate] IS NULL) OR [InsuranceDate] = @OldInsuranceDate) "
                + " AND ((@OldHealthInsuranceCode IS NULL AND [HealthInsuranceCode] IS NULL) OR [HealthInsuranceCode] = @OldHealthInsuranceCode) "
                + " AND ((@OldHealthInsuranceFromDate IS NULL AND [HealthInsuranceFromDate] IS NULL) OR [HealthInsuranceFromDate] = @OldHealthInsuranceFromDate) "
                + " AND ((@OldHealthInsuranceToDate IS NULL AND [HealthInsuranceToDate] IS NULL) OR [HealthInsuranceToDate] = @OldHealthInsuranceToDate) "
                + " AND ((@OldContractCode IS NULL AND [ContractCode] IS NULL) OR [ContractCode] = @OldContractCode) "
                + " AND ((@OldContractType IS NULL AND [ContractType] IS NULL) OR [ContractType] = @OldContractType) "
                + " AND ((@OldContractSignDate IS NULL AND [ContractSignDate] IS NULL) OR [ContractSignDate] = @OldContractSignDate) "
                + " AND ((@OldContractFromDate IS NULL AND [ContractFromDate] IS NULL) OR [ContractFromDate] = @OldContractFromDate) "
                + " AND ((@OldContractToDate IS NULL AND [ContractToDate] IS NULL) OR [ContractToDate] = @OldContractToDate) "
                + " AND ((@OldPHOTO IS NULL AND [Photo] IS NULL) OR [Photo] = @OldPhoto) "
                + " AND ((@OldWorkStateCode IS NULL AND [WorkStateCode] IS NULL) OR [WorkStateCode] = @OldWorkStateCode) "
                
                + "";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.CommandType = CommandType.Text;
            updateCommand.Parameters.AddWithValue("@NewEmployeeCode", newHRM_EMPLOYEE.EmployeeCode);
            if (newHRM_EMPLOYEE.DepartmentCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewDepartmentCode", newHRM_EMPLOYEE.DepartmentCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDepartmentCode", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.EnrollNumber != null)
            {
                updateCommand.Parameters.AddWithValue("@NewEnrollNumber", newHRM_EMPLOYEE.EnrollNumber);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEnrollNumber", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.FirstName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewFirstName", newHRM_EMPLOYEE.FirstName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewFirstName", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.LastName != null)
            {
                updateCommand.Parameters.AddWithValue("@NewLastName", newHRM_EMPLOYEE.LastName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewLastName", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Alias != null)
            {
                updateCommand.Parameters.AddWithValue("@NewAlias", newHRM_EMPLOYEE.Alias);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewAlias", DBNull.Value);
            }

            updateCommand.Parameters.AddWithValue("@NewSex", newHRM_EMPLOYEE.Sex);
            
            if (newHRM_EMPLOYEE.Marriage != null)
            {
                updateCommand.Parameters.AddWithValue("@NewMarriage", newHRM_EMPLOYEE.Marriage);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewMarriage", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Birthday.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewBirthday", newHRM_EMPLOYEE.Birthday);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewBirthday", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.BirthPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@NewBirthPlace", newHRM_EMPLOYEE.BirthPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewBirthPlace", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.MainAddress != null)
            {
                updateCommand.Parameters.AddWithValue("@NewMainAddress", newHRM_EMPLOYEE.MainAddress);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewMainAddress", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.ContactAddress != null)
            {
                updateCommand.Parameters.AddWithValue("@NewContactAddress", newHRM_EMPLOYEE.ContactAddress);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewContactAddress", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.CellPhone != null)
            {
                updateCommand.Parameters.AddWithValue("@NewCellPhone", newHRM_EMPLOYEE.CellPhone);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewCellPhone", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Email != null)
            {
                updateCommand.Parameters.AddWithValue("@NewEmail", newHRM_EMPLOYEE.Email);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEmail", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Nationality != null)
            {
                updateCommand.Parameters.AddWithValue("@NewNationality", newHRM_EMPLOYEE.Nationality);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewNationality", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Ethnic != null)
            {
                updateCommand.Parameters.AddWithValue("@NewEthnic", newHRM_EMPLOYEE.Ethnic);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEthnic", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Religion != null)
            {
                updateCommand.Parameters.AddWithValue("@NewReligion", newHRM_EMPLOYEE.Religion);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewReligion", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Education != null)
            {
                updateCommand.Parameters.AddWithValue("@NewEducation", newHRM_EMPLOYEE.Education);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEducation", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Language != null)
            {
                updateCommand.Parameters.AddWithValue("@NewLanguage", newHRM_EMPLOYEE.Language);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewLanguage", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Informatic != null)
            {
                updateCommand.Parameters.AddWithValue("@NewInformatic", newHRM_EMPLOYEE.Informatic);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewInformatic", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Professional != null)
            {
                updateCommand.Parameters.AddWithValue("@NewProfessional", newHRM_EMPLOYEE.Professional);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewProfessional", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Position != null)
            {
                updateCommand.Parameters.AddWithValue("@NewPosition", newHRM_EMPLOYEE.Position);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPosition", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.School != null)
            {
                updateCommand.Parameters.AddWithValue("@NewSchool", newHRM_EMPLOYEE.School);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewSchool", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IDCard != null)
            {
                updateCommand.Parameters.AddWithValue("@NewIDCard", newHRM_EMPLOYEE.IDCard);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIDCard", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IDCardDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIDCardDate", newHRM_EMPLOYEE.IDCardDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIDCardDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IDCardPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@NewIDCardPlace", newHRM_EMPLOYEE.IDCardPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIDCardPlace", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.BeginDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewBeginDate", newHRM_EMPLOYEE.BeginDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewBeginDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsOffWork.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsOffWork", newHRM_EMPLOYEE.IsOffWork);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsOffWork", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.EndDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewEndDate", newHRM_EMPLOYEE.EndDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewEndDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.PayForm.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewPayForm", newHRM_EMPLOYEE.PayForm);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPayForm", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.PayMoney.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewPayMoney", newHRM_EMPLOYEE.PayMoney);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPayMoney", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.MinimumSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewMinimumSalary", newHRM_EMPLOYEE.MinimumSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewMinimumSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.RankSalary != null)
            {
                updateCommand.Parameters.AddWithValue("@NewRankSalary", newHRM_EMPLOYEE.RankSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewRankSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.StepSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewStepSalary", newHRM_EMPLOYEE.StepSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewStepSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.CoefficientSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewCoefficientSalary", newHRM_EMPLOYEE.CoefficientSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewCoefficientSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.DateSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewDateSalary", newHRM_EMPLOYEE.DateSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewDateSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.BasicSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewBasicSalary", newHRM_EMPLOYEE.BasicSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewBasicSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.InsuranceSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewInsuranceSalary", newHRM_EMPLOYEE.InsuranceSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewInsuranceSalary", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Allowance1.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance1", newHRM_EMPLOYEE.Allowance1);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance1", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Allowance2.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance2", newHRM_EMPLOYEE.Allowance2);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance2", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Allowance3.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance3", newHRM_EMPLOYEE.Allowance3);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance3", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.Allowance4.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance4", newHRM_EMPLOYEE.Allowance4);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewAllowance4", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsSocialInsurance.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsSocialInsurance", newHRM_EMPLOYEE.IsSocialInsurance);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsSocialInsurance", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsHealthInsurance.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsHealthInsurance", newHRM_EMPLOYEE.IsHealthInsurance);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsHealthInsurance", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsUnemploymentInsurance.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsUnemploymentInsurance", newHRM_EMPLOYEE.IsUnemploymentInsurance);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsUnemploymentInsurance", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsUnionMoney.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsUnionMoney", newHRM_EMPLOYEE.IsUnionMoney);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsUnionMoney", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsUnion.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsUnion", newHRM_EMPLOYEE.IsUnion);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsUnion", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.UnionCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewUnionCode", newHRM_EMPLOYEE.UnionCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewUnionCode", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.UnionDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewUnionDate", newHRM_EMPLOYEE.UnionDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewUnionDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.UnionPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@NewUnionPlace", newHRM_EMPLOYEE.UnionPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewUnionPlace", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.IsParty.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewIsParty", newHRM_EMPLOYEE.IsParty);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewIsParty", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.PartyCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewPartyCode", newHRM_EMPLOYEE.PartyCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPartyCode", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.PartyDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewPartyDate", newHRM_EMPLOYEE.PartyDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPartyDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.PartyPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@NewPartyPlace", newHRM_EMPLOYEE.PartyPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPartyPlace", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.InsuranceCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewInsuranceCode", newHRM_EMPLOYEE.InsuranceCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewInsuranceCode", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.InsuranceDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewInsuranceDate", newHRM_EMPLOYEE.InsuranceDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewInsuranceDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.HealthInsuranceCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewHealthInsuranceCode", newHRM_EMPLOYEE.HealthInsuranceCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewHealthInsuranceCode", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.HealthInsuranceFromDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewHealthInsuranceFromDate", newHRM_EMPLOYEE.HealthInsuranceFromDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewHealthInsuranceFromDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.HealthInsuranceToDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewHealthInsuranceToDate", newHRM_EMPLOYEE.HealthInsuranceToDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewHealthInsuranceToDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.ContractCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewContractCode", newHRM_EMPLOYEE.ContractCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewContractCode", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.ContractType != null)
            {
                updateCommand.Parameters.AddWithValue("@NewContractType", newHRM_EMPLOYEE.ContractType);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewContractType", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.ContractSignDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewContractSignDate", newHRM_EMPLOYEE.ContractSignDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewContractSignDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.ContractFromDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewContractFromDate", newHRM_EMPLOYEE.ContractFromDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewContractFromDate", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.ContractToDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@NewContractToDate", newHRM_EMPLOYEE.ContractToDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewContractToDate", DBNull.Value);
            }
            
            if (newHRM_EMPLOYEE.Photo != null)
            {
                updateCommand.Parameters.AddWithValue("@NewPhoto", newHRM_EMPLOYEE.Photo);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewPhoto", DBNull.Value);
            }
            if (newHRM_EMPLOYEE.WorkStateCode != null)
            {
                updateCommand.Parameters.AddWithValue("@NewWorkStateCode", newHRM_EMPLOYEE.WorkStateCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@NewWorkStateCode", DBNull.Value);
            }


            updateCommand.Parameters.AddWithValue("@OldEmployeeCode", oldHRM_EMPLOYEE.EmployeeCode);
            
            
            if (oldHRM_EMPLOYEE.DepartmentCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldDepartmentCode", oldHRM_EMPLOYEE.DepartmentCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDepartmentCode", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.EnrollNumber != null)
            {
                updateCommand.Parameters.AddWithValue("@OldEnrollNumber", oldHRM_EMPLOYEE.EnrollNumber);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEnrollNumber", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.FirstName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldFirstName", oldHRM_EMPLOYEE.FirstName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldFirstName", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.LastName != null)
            {
                updateCommand.Parameters.AddWithValue("@OldLastName", oldHRM_EMPLOYEE.LastName);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldLastName", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Alias != null)
            {
                updateCommand.Parameters.AddWithValue("@OldAlias", oldHRM_EMPLOYEE.Alias);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldAlias", DBNull.Value);
            }

            updateCommand.Parameters.AddWithValue("@OldSex", oldHRM_EMPLOYEE.Sex);
            
            if (oldHRM_EMPLOYEE.Marriage != null)
            {
                updateCommand.Parameters.AddWithValue("@OldMarriage", oldHRM_EMPLOYEE.Marriage);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldMarriage", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Birthday.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldBirthday", oldHRM_EMPLOYEE.Birthday);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldBirthday", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.BirthPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@OldBirthPlace", oldHRM_EMPLOYEE.BirthPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldBirthPlace", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.MainAddress != null)
            {
                updateCommand.Parameters.AddWithValue("@OldMainAddress", oldHRM_EMPLOYEE.MainAddress);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldMainAddress", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.ContactAddress != null)
            {
                updateCommand.Parameters.AddWithValue("@OldContactAddress", oldHRM_EMPLOYEE.ContactAddress);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldContactAddress", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.CellPhone != null)
            {
                updateCommand.Parameters.AddWithValue("@OldCellPhone", oldHRM_EMPLOYEE.CellPhone);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldCellPhone", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Email != null)
            {
                updateCommand.Parameters.AddWithValue("@OldEmail", oldHRM_EMPLOYEE.Email);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEmail", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Nationality != null)
            {
                updateCommand.Parameters.AddWithValue("@OldNationality", oldHRM_EMPLOYEE.Nationality);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldNationality", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Ethnic != null)
            {
                updateCommand.Parameters.AddWithValue("@OldEthnic", oldHRM_EMPLOYEE.Ethnic);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEthnic", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Religion != null)
            {
                updateCommand.Parameters.AddWithValue("@OldReligion", oldHRM_EMPLOYEE.Religion);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldReligion", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Education != null)
            {
                updateCommand.Parameters.AddWithValue("@OldEducation", oldHRM_EMPLOYEE.Education);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEducation", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Language != null)
            {
                updateCommand.Parameters.AddWithValue("@OldLanguage", oldHRM_EMPLOYEE.Language);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldLanguage", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Informatic != null)
            {
                updateCommand.Parameters.AddWithValue("@OldInformatic", oldHRM_EMPLOYEE.Informatic);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldInformatic", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Professional != null)
            {
                updateCommand.Parameters.AddWithValue("@OldProfessional", oldHRM_EMPLOYEE.Professional);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldProfessional", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Position != null)
            {
                updateCommand.Parameters.AddWithValue("@OldPosition", oldHRM_EMPLOYEE.Position);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPosition", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.School != null)
            {
                updateCommand.Parameters.AddWithValue("@OldSchool", oldHRM_EMPLOYEE.School);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldSchool", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IDCard != null)
            {
                updateCommand.Parameters.AddWithValue("@OldIDCard", oldHRM_EMPLOYEE.IDCard);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIDCard", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IDCardDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIDCardDate", oldHRM_EMPLOYEE.IDCardDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIDCardDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IDCardPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@OldIDCardPlace", oldHRM_EMPLOYEE.IDCardPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIDCardPlace", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.BeginDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldBeginDate", oldHRM_EMPLOYEE.BeginDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldBeginDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsOffWork.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsOffWork", oldHRM_EMPLOYEE.IsOffWork);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsOffWork", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.EndDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldEndDate", oldHRM_EMPLOYEE.EndDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldEndDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.PayForm.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldPayForm", oldHRM_EMPLOYEE.PayForm);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPayForm", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.PayMoney.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldPayMoney", oldHRM_EMPLOYEE.PayMoney);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPayMoney", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.MinimumSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldMinimumSalary", oldHRM_EMPLOYEE.MinimumSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldMinimumSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.RankSalary != null)
            {
                updateCommand.Parameters.AddWithValue("@OldRankSalary", oldHRM_EMPLOYEE.RankSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldRankSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.StepSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldStepSalary", oldHRM_EMPLOYEE.StepSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldStepSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.CoefficientSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldCoefficientSalary", oldHRM_EMPLOYEE.CoefficientSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldCoefficientSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.DateSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldDateSalary", oldHRM_EMPLOYEE.DateSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldDateSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.BasicSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldBasicSalary", oldHRM_EMPLOYEE.BasicSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldBasicSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.InsuranceSalary.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldInsuranceSalary", oldHRM_EMPLOYEE.InsuranceSalary);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldInsuranceSalary", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Allowance1.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance1", oldHRM_EMPLOYEE.Allowance1);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance1", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Allowance2.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance2", oldHRM_EMPLOYEE.Allowance2);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance2", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Allowance3.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance3", oldHRM_EMPLOYEE.Allowance3);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance3", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.Allowance4.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance4", oldHRM_EMPLOYEE.Allowance4);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldAllowance4", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsSocialInsurance.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsSocialInsurance", oldHRM_EMPLOYEE.IsSocialInsurance);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsSocialInsurance", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsHealthInsurance.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsHealthInsurance", oldHRM_EMPLOYEE.IsHealthInsurance);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsHealthInsurance", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsUnemploymentInsurance.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsUnemploymentInsurance", oldHRM_EMPLOYEE.IsUnemploymentInsurance);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsUnemploymentInsurance", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsUnionMoney.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsUnionMoney", oldHRM_EMPLOYEE.IsUnionMoney);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsUnionMoney", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsUnion.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsUnion", oldHRM_EMPLOYEE.IsUnion);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsUnion", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.UnionCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldUnionCode", oldHRM_EMPLOYEE.UnionCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldUnionCode", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.UnionDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldUnionDate", oldHRM_EMPLOYEE.UnionDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldUnionDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.UnionPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@OldUnionPlace", oldHRM_EMPLOYEE.UnionPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldUnionPlace", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.IsParty.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldIsParty", oldHRM_EMPLOYEE.IsParty);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldIsParty", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.PartyCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldPartyCode", oldHRM_EMPLOYEE.PartyCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPartyCode", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.PartyDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldPartyDate", oldHRM_EMPLOYEE.PartyDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPartyDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.PartyPlace != null)
            {
                updateCommand.Parameters.AddWithValue("@OldPartyPlace", oldHRM_EMPLOYEE.PartyPlace);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPartyPlace", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.InsuranceCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldInsuranceCode", oldHRM_EMPLOYEE.InsuranceCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldInsuranceCode", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.InsuranceDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldInsuranceDate", oldHRM_EMPLOYEE.InsuranceDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldInsuranceDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.HealthInsuranceCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldHealthInsuranceCode", oldHRM_EMPLOYEE.HealthInsuranceCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldHealthInsuranceCode", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.HealthInsuranceFromDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldHealthInsuranceFromDate", oldHRM_EMPLOYEE.HealthInsuranceFromDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldHealthInsuranceFromDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.HealthInsuranceToDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldHealthInsuranceToDate", oldHRM_EMPLOYEE.HealthInsuranceToDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldHealthInsuranceToDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.ContractCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldContractCode", oldHRM_EMPLOYEE.ContractCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldContractCode", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.ContractType != null)
            {
                updateCommand.Parameters.AddWithValue("@OldContractType", oldHRM_EMPLOYEE.ContractType);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldContractType", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.ContractSignDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldContractSignDate", oldHRM_EMPLOYEE.ContractSignDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldContractSignDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.ContractFromDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldContractFromDate", oldHRM_EMPLOYEE.ContractFromDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldContractFromDate", DBNull.Value);
            }
            if (oldHRM_EMPLOYEE.ContractToDate.HasValue == true)
            {
                updateCommand.Parameters.AddWithValue("@OldContractToDate", oldHRM_EMPLOYEE.ContractToDate);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldContractToDate", DBNull.Value);
            }

            if (oldHRM_EMPLOYEE.Photo != null)
            {
                updateCommand.Parameters.AddWithValue("@OldPhoto", oldHRM_EMPLOYEE.Photo);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPhoto", DBNull.Value);
            }

            if (oldHRM_EMPLOYEE.WorkStateCode != null)
            {
                updateCommand.Parameters.AddWithValue("@OldWorkStateCode", oldHRM_EMPLOYEE.WorkStateCode);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldWorkStateCode", DBNull.Value);
            }
            try
            {
                connection.Open();
               
                string query = updateCommand.CommandText;

                foreach (SqlParameter p in updateCommand.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }

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

        public static bool Delete(HRM_EMPLOYEE clsHRM_EMPLOYEE)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "DELETE FROM "
                + "     [HRM_EMPLOYEE] "
                + "WHERE "
                + "     [EmployeeCode] = @OldEmployeeCode "
                + " AND ((@OldDepartmentCode IS NULL AND [DepartmentCode] IS NULL) OR [DepartmentCode] = @OldDepartmentCode) "
                + " AND ((@OldEnrollNumber IS NULL AND [EnrollNumber] IS NULL) OR [EnrollNumber] = @OldEnrollNumber) "
                + " AND ((@OldFirstName IS NULL AND [FirstName] IS NULL) OR [FirstName] = @OldFirstName) "
                + " AND ((@OldLastName IS NULL AND [LastName] IS NULL) OR [LastName] = @OldLastName) "
                + " AND ((@OldAlias IS NULL AND [Alias] IS NULL) OR [Alias] = @OldAlias) "
                + " AND ((@OldSex IS NULL AND [Sex] IS NULL) OR [Sex] = @OldSex) "
                + " AND ((@OldMarriage IS NULL AND [Marriage] IS NULL) OR [Marriage] = @OldMarriage) "
                + " AND ((@OldBirthday IS NULL AND [Birthday] IS NULL) OR [Birthday] = @OldBirthday) "
                + " AND ((@OldBirthPlace IS NULL AND [BirthPlace] IS NULL) OR [BirthPlace] = @OldBirthPlace) "
                + " AND ((@OldMainAddress IS NULL AND [MainAddress] IS NULL) OR [MainAddress] = @OldMainAddress) "
                + " AND ((@OldContactAddress IS NULL AND [ContactAddress] IS NULL) OR [ContactAddress] = @OldContactAddress) "
                + " AND ((@OldCellPhone IS NULL AND [CellPhone] IS NULL) OR [CellPhone] = @OldCellPhone) "
                + " AND ((@OldEmail IS NULL AND [Email] IS NULL) OR [Email] = @OldEmail) "
                + " AND ((@OldNationality IS NULL AND [Nationality] IS NULL) OR [Nationality] = @OldNationality) "
                + " AND ((@OldEthnic IS NULL AND [Ethnic] IS NULL) OR [Ethnic] = @OldEthnic) "
                + " AND ((@OldReligion IS NULL AND [Religion] IS NULL) OR [Religion] = @OldReligion) "
                + " AND ((@OldEducation IS NULL AND [Education] IS NULL) OR [Education] = @OldEducation) "
                + " AND ((@OldLanguage IS NULL AND [Language] IS NULL) OR [Language] = @OldLanguage) "
                + " AND ((@OldInformatic IS NULL AND [Informatic] IS NULL) OR [Informatic] = @OldInformatic) "
                + " AND ((@OldProfessional IS NULL AND [Professional] IS NULL) OR [Professional] = @OldProfessional) "
                + " AND ((@OldPosition IS NULL AND [Position] IS NULL) OR [Position] = @OldPosition) "
                + " AND ((@OldSchool IS NULL AND [School] IS NULL) OR [School] = @OldSchool) "
                + " AND ((@OldIDCard IS NULL AND [IDCard] IS NULL) OR [IDCard] = @OldIDCard) "
                + " AND ((@OldIDCardDate IS NULL AND [IDCardDate] IS NULL) OR [IDCardDate] = @OldIDCardDate) "
                + " AND ((@OldIDCardPlace IS NULL AND [IDCardPlace] IS NULL) OR [IDCardPlace] = @OldIDCardPlace) "
                + " AND ((@OldBeginDate IS NULL AND [BeginDate] IS NULL) OR [BeginDate] = @OldBeginDate) "
                + " AND ((@OldIsOffWork IS NULL AND [IsOffWork] IS NULL) OR [IsOffWork] = @OldIsOffWork) "
                + " AND ((@OldEndDate IS NULL AND [EndDate] IS NULL) OR [EndDate] = @OldEndDate) "
                + " AND ((@OldPayForm IS NULL AND [PayForm] IS NULL) OR [PayForm] = @OldPayForm) "
                + " AND ((@OldPayMoney IS NULL AND [PayMoney] IS NULL) OR [PayMoney] = @OldPayMoney) "
                + " AND ((@OldMinimumSalary IS NULL AND [MinimumSalary] IS NULL) OR [MinimumSalary] = @OldMinimumSalary) "
                + " AND ((@OldRankSalary IS NULL AND [RankSalary] IS NULL) OR [RankSalary] = @OldRankSalary) "
                + " AND ((@OldStepSalary IS NULL AND [StepSalary] IS NULL) OR [StepSalary] = @OldStepSalary) "
                + " AND ((@OldCoefficientSalary IS NULL AND [CoefficientSalary] IS NULL) OR [CoefficientSalary] = @OldCoefficientSalary) "
                + " AND ((@OldDateSalary IS NULL AND [DateSalary] IS NULL) OR [DateSalary] = @OldDateSalary) "
                + " AND ((@OldBasicSalary IS NULL AND [BasicSalary] IS NULL) OR [BasicSalary] = @OldBasicSalary) "
                + " AND ((@OldInsuranceSalary IS NULL AND [InsuranceSalary] IS NULL) OR [InsuranceSalary] = @OldInsuranceSalary) "
                + " AND ((@OldAllowance1 IS NULL AND [Allowance1] IS NULL) OR [Allowance1] = @OldAllowance1) "
                + " AND ((@OldAllowance2 IS NULL AND [Allowance2] IS NULL) OR [Allowance2] = @OldAllowance2) "
                + " AND ((@OldAllowance3 IS NULL AND [Allowance3] IS NULL) OR [Allowance3] = @OldAllowance3) "
                + " AND ((@OldAllowance4 IS NULL AND [Allowance4] IS NULL) OR [Allowance4] = @OldAllowance4) "
                + " AND ((@OldIsSocialInsurance IS NULL AND [IsSocialInsurance] IS NULL) OR [IsSocialInsurance] = @OldIsSocialInsurance) "
                + " AND ((@OldIsHealthInsurance IS NULL AND [IsHealthInsurance] IS NULL) OR [IsHealthInsurance] = @OldIsHealthInsurance) "
                + " AND ((@OldIsUnemploymentInsurance IS NULL AND [IsUnemploymentInsurance] IS NULL) OR [IsUnemploymentInsurance] = @OldIsUnemploymentInsurance) "
                + " AND ((@OldIsUnionMoney IS NULL AND [IsUnionMoney] IS NULL) OR [IsUnionMoney] = @OldIsUnionMoney) "
                + " AND ((@OldIsUnion IS NULL AND [IsUnion] IS NULL) OR [IsUnion] = @OldIsUnion) "
                + " AND ((@OldUnionCode IS NULL AND [UnionCode] IS NULL) OR [UnionCode] = @OldUnionCode) "
                + " AND ((@OldUnionDate IS NULL AND [UnionDate] IS NULL) OR [UnionDate] = @OldUnionDate) "
                + " AND ((@OldUnionPlace IS NULL AND [UnionPlace] IS NULL) OR [UnionPlace] = @OldUnionPlace) "
                + " AND ((@OldIsParty IS NULL AND [IsParty] IS NULL) OR [IsParty] = @OldIsParty) "
                + " AND ((@OldPartyCode IS NULL AND [PartyCode] IS NULL) OR [PartyCode] = @OldPartyCode) "
                + " AND ((@OldPartyDate IS NULL AND [PartyDate] IS NULL) OR [PartyDate] = @OldPartyDate) "
                + " AND ((@OldPartyPlace IS NULL AND [PartyPlace] IS NULL) OR [PartyPlace] = @OldPartyPlace) "
                + " AND ((@OldInsuranceCode IS NULL AND [InsuranceCode] IS NULL) OR [InsuranceCode] = @OldInsuranceCode) "
                + " AND ((@OldInsuranceDate IS NULL AND [InsuranceDate] IS NULL) OR [InsuranceDate] = @OldInsuranceDate) "
                + " AND ((@OldHealthInsuranceCode IS NULL AND [HealthInsuranceCode] IS NULL) OR [HealthInsuranceCode] = @OldHealthInsuranceCode) "
                + " AND ((@OldHealthInsuranceFromDate IS NULL AND [HealthInsuranceFromDate] IS NULL) OR [HealthInsuranceFromDate] = @OldHealthInsuranceFromDate) "
                + " AND ((@OldHealthInsuranceToDate IS NULL AND [HealthInsuranceToDate] IS NULL) OR [HealthInsuranceToDate] = @OldHealthInsuranceToDate) "
                + " AND ((@OldContractCode IS NULL AND [ContractCode] IS NULL) OR [ContractCode] = @OldContractCode) "
                + " AND ((@OldContractType IS NULL AND [ContractType] IS NULL) OR [ContractType] = @OldContractType) "
                + " AND ((@OldContractSignDate IS NULL AND [ContractSignDate] IS NULL) OR [ContractSignDate] = @OldContractSignDate) "
                + " AND ((@OldContractFromDate IS NULL AND [ContractFromDate] IS NULL) OR [ContractFromDate] = @OldContractFromDate) "
                + " AND ((@OldContractToDate IS NULL AND [ContractToDate] IS NULL) OR [ContractToDate] = @OldContractToDate) "
                + " AND ((@OldWorkStateCode IS NULL AND [WorkStateCode] IS NULL) OR [WorkStateCode] = @OldWorkStateCode) "
                + "";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@OldEmployeeCode", clsHRM_EMPLOYEE.EmployeeCode);
            if (clsHRM_EMPLOYEE.DepartmentCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldDepartmentCode", clsHRM_EMPLOYEE.DepartmentCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDepartmentCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.EnrollNumber != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldEnrollNumber", clsHRM_EMPLOYEE.EnrollNumber);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEnrollNumber", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.FirstName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldFirstName", clsHRM_EMPLOYEE.FirstName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldFirstName", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.LastName != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldLastName", clsHRM_EMPLOYEE.LastName);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldLastName", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Alias != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldAlias", clsHRM_EMPLOYEE.Alias);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldAlias", DBNull.Value);
            }
             deleteCommand.Parameters.AddWithValue("@OldSex", clsHRM_EMPLOYEE.Sex);
           
            if (clsHRM_EMPLOYEE.Marriage != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldMarriage", clsHRM_EMPLOYEE.Marriage);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldMarriage", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Birthday.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldBirthday", clsHRM_EMPLOYEE.Birthday);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldBirthday", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.BirthPlace != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldBirthPlace", clsHRM_EMPLOYEE.BirthPlace);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldBirthPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.MainAddress != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldMainAddress", clsHRM_EMPLOYEE.MainAddress);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldMainAddress", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContactAddress != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldContactAddress", clsHRM_EMPLOYEE.ContactAddress);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldContactAddress", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.CellPhone != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldCellPhone", clsHRM_EMPLOYEE.CellPhone);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldCellPhone", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Email != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldEmail", clsHRM_EMPLOYEE.Email);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEmail", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Nationality != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldNationality", clsHRM_EMPLOYEE.Nationality);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldNationality", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Ethnic != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldEthnic", clsHRM_EMPLOYEE.Ethnic);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEthnic", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Religion != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldReligion", clsHRM_EMPLOYEE.Religion);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldReligion", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Education != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldEducation", clsHRM_EMPLOYEE.Education);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEducation", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Language != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldLanguage", clsHRM_EMPLOYEE.Language);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldLanguage", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Informatic != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldInformatic", clsHRM_EMPLOYEE.Informatic);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldInformatic", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Professional != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldProfessional", clsHRM_EMPLOYEE.Professional);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldProfessional", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Position != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldPosition", clsHRM_EMPLOYEE.Position);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPosition", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.School != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldSchool", clsHRM_EMPLOYEE.School);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldSchool", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IDCard != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldIDCard", clsHRM_EMPLOYEE.IDCard);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIDCard", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IDCardDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIDCardDate", clsHRM_EMPLOYEE.IDCardDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIDCardDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IDCardPlace != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldIDCardPlace", clsHRM_EMPLOYEE.IDCardPlace);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIDCardPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.BeginDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldBeginDate", clsHRM_EMPLOYEE.BeginDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldBeginDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsOffWork.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsOffWork", clsHRM_EMPLOYEE.IsOffWork);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsOffWork", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.EndDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldEndDate", clsHRM_EMPLOYEE.EndDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldEndDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PayForm.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldPayForm", clsHRM_EMPLOYEE.PayForm);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPayForm", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PayMoney.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldPayMoney", clsHRM_EMPLOYEE.PayMoney);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPayMoney", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.MinimumSalary.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldMinimumSalary", clsHRM_EMPLOYEE.MinimumSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldMinimumSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.RankSalary != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldRankSalary", clsHRM_EMPLOYEE.RankSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldRankSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.StepSalary.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldStepSalary", clsHRM_EMPLOYEE.StepSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldStepSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.CoefficientSalary.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldCoefficientSalary", clsHRM_EMPLOYEE.CoefficientSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldCoefficientSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.DateSalary.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldDateSalary", clsHRM_EMPLOYEE.DateSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldDateSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.BasicSalary.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldBasicSalary", clsHRM_EMPLOYEE.BasicSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldBasicSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.InsuranceSalary.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldInsuranceSalary", clsHRM_EMPLOYEE.InsuranceSalary);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldInsuranceSalary", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance1.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance1", clsHRM_EMPLOYEE.Allowance1);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance1", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance2.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance2", clsHRM_EMPLOYEE.Allowance2);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance2", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance3.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance3", clsHRM_EMPLOYEE.Allowance3);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance3", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.Allowance4.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance4", clsHRM_EMPLOYEE.Allowance4);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldAllowance4", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsSocialInsurance.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsSocialInsurance", clsHRM_EMPLOYEE.IsSocialInsurance);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsSocialInsurance", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsHealthInsurance.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsHealthInsurance", clsHRM_EMPLOYEE.IsHealthInsurance);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsHealthInsurance", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsUnemploymentInsurance.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsUnemploymentInsurance", clsHRM_EMPLOYEE.IsUnemploymentInsurance);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsUnemploymentInsurance", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsUnionMoney.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsUnionMoney", clsHRM_EMPLOYEE.IsUnionMoney);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsUnionMoney", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsUnion.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsUnion", clsHRM_EMPLOYEE.IsUnion);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsUnion", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.UnionCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldUnionCode", clsHRM_EMPLOYEE.UnionCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldUnionCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.UnionDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldUnionDate", clsHRM_EMPLOYEE.UnionDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldUnionDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.UnionPlace != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldUnionPlace", clsHRM_EMPLOYEE.UnionPlace);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldUnionPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.IsParty.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldIsParty", clsHRM_EMPLOYEE.IsParty);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldIsParty", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PartyCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldPartyCode", clsHRM_EMPLOYEE.PartyCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPartyCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PartyDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldPartyDate", clsHRM_EMPLOYEE.PartyDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPartyDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.PartyPlace != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldPartyPlace", clsHRM_EMPLOYEE.PartyPlace);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldPartyPlace", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.InsuranceCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldInsuranceCode", clsHRM_EMPLOYEE.InsuranceCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldInsuranceCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.InsuranceDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldInsuranceDate", clsHRM_EMPLOYEE.InsuranceDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldInsuranceDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.HealthInsuranceCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldHealthInsuranceCode", clsHRM_EMPLOYEE.HealthInsuranceCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldHealthInsuranceCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.HealthInsuranceFromDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldHealthInsuranceFromDate", clsHRM_EMPLOYEE.HealthInsuranceFromDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldHealthInsuranceFromDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.HealthInsuranceToDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldHealthInsuranceToDate", clsHRM_EMPLOYEE.HealthInsuranceToDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldHealthInsuranceToDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldContractCode", clsHRM_EMPLOYEE.ContractCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldContractCode", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractType != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldContractType", clsHRM_EMPLOYEE.ContractType);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldContractType", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractSignDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldContractSignDate", clsHRM_EMPLOYEE.ContractSignDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldContractSignDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractFromDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldContractFromDate", clsHRM_EMPLOYEE.ContractFromDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldContractFromDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.ContractToDate.HasValue == true)
            {
                deleteCommand.Parameters.AddWithValue("@OldContractToDate", clsHRM_EMPLOYEE.ContractToDate);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldContractToDate", DBNull.Value);
            }
            if (clsHRM_EMPLOYEE.WorkStateCode != null)
            {
                deleteCommand.Parameters.AddWithValue("@OldWorkStateCode", clsHRM_EMPLOYEE.WorkStateCode);
            }
            else
            {
                deleteCommand.Parameters.AddWithValue("@OldWorkStateCode", DBNull.Value);
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
            sql = sql + " SELECT ";
            sql = sql + "     [DepartmentName] AS [Phòng Ban]";
            sql = sql + "     ,[EmployeeCode] AS [Mã Nhân Viên]";
            
            //sql = sql + "     ,[EnrollNumber] AS [STT Nhân Viên]";
            sql = sql + "     ,[FirstName] AS [Họ Lót]";
            sql = sql + "     ,[LastName] AS [Tên]";
            sql = sql + "     ,[Alias] AS [Tên Thường Gọi]";
            sql = sql + "     ,[Sex] AS [Giới Tính]";
            //sql = sql + "     ,[Marriage] AS [Tình Trạng Hôn Nhân]";
            //sql = sql + "     ,[Birthday] AS [Ngày Sinh]";
            //sql = sql + "     ,[BirthPlace] AS [Nơi Sinh]";
            sql = sql + "     ,[MainAddress] AS [Địa Chỉ]";
            sql = sql + "     ,[ContactAddress] AS [Thường Trú]";
            sql = sql + "     ,[CellPhone] AS [SĐT]";
            sql = sql + "     ,[Email] AS [Email]";
            sql = sql + "     ,[WorkStateName] AS [Trạng Thái]";
            //sql = sql + "     ,[Photo] AS [Ảnh]";
            //sql = sql + "     ,[Ethnic] AS [Dân Tộc]";
            //sql = sql + "     ,[Religion] AS [Tôn Giáo]";
            //sql = sql + "     ,[Education] AS [Học Vấn]";
            //sql = sql + "     ,[Language] AS [Ngôn Ngữ]";
            //sql = sql + "     ,[Informatic] AS [Tin Học]";
            sql = sql + "     ,[ProfessionalName] AS [Chuyên Môn]";
            sql = sql + "     ,[SchoolName] AS [Trường]";
            sql = sql + "     ,[IDCard] AS [CMND]";
            sql = sql + "     ,[IDCardDate] AS [Ngày Cấp]";
            sql = sql + "     ,[IDCardPlace] AS [Nơi Cấp]";
            //sql = sql + "     ,[BeginDate] AS [Ngày Vào Làm]";
            //sql = sql + "     ,[IsOffWork] AS [Đã Thôi Việc]";
            //sql = sql + "     ,[EndDate] AS [Ngày Thôi Việc]";
            //sql = sql + "     ,[PayForm] AS [Hình Thức Trả Lương]";
            //sql = sql + "     ,[PayMoney] AS [Trả Tiền]";
            //sql = sql + "     ,[MinimumSalary] AS [Lương Tối Thiểu]";
            //sql = sql + "     ,[RankSalary] AS [Ngạch Lương]";
            //sql = sql + "     ,[StepSalary] AS [Bậc Lương]";
            //sql = sql + "     ,[CoefficientSalary] AS [Hệ Số Lương]";
            //sql = sql + "     ,[DateSalary] AS [Ngày Trả Lương]";
            //sql = sql + "     ,[BasicSalary] AS [Lương Cơ Bản]";
            //sql = sql + "     ,[InsuranceSalary] AS [Tiền Bảo Hiểm]";
            //sql = sql + "     ,[Allowance1] AS [Phụ Cấp 1]";
            //sql = sql + "     ,[Allowance2] AS [Phụ Cấp 2]";
            //sql = sql + "     ,[Allowance3] AS [Phụ Cấp 3]";
            //sql = sql + "     ,[Allowance4] AS [Phụ Cấp 4]";
            //sql = sql + "     ,[IsSocialInsurance] AS [BHXH]";
            //sql = sql + "     ,[IsHealthInsurance] AS [BHYT]";
            //sql = sql + "     ,[IsUnemploymentInsurance] AS [Bảo Hiểm Thất Nghiệp]";
            //sql = sql + "     ,[IsUnionMoney] AS [Tiền Công Đoàn]";
            //sql = sql + "     ,[IsUnion] AS [Đoàn Viên]";
            //sql = sql + "     ,[UnionCode] AS [Mã Đoàn Viên]";
            //sql = sql + "     ,[UnionDate] AS [Ngày Vào Đoàn]";
            //sql = sql + "     ,[UnionPlace] AS [Nơi Vào Đoàn]";
            //sql = sql + "     ,[IsParty] AS [Đảng Viên]";
            //sql = sql + "     ,[PartyCode] AS [Mã Đảng Viên]";
            //sql = sql + "     ,[PartyDate] AS [Ngày Vào Đảng]";
            //sql = sql + "     ,[PartyPlace] AS [Nơi Vào Đảng]";
            //sql = sql + "     ,[InsuranceCode] AS [Mã Bảo Hiểm]";
            //sql = sql + "     ,[InsuranceDate] AS [Ngày Cấp]";
            //sql = sql + "     ,[HealthInsuranceCode] AS [Mã BHYT]";
            //sql = sql + "     ,[HealthInsuranceFromDate] AS [Ngày Bắt Đầu]";
            //sql = sql + "     ,[HealthInsuranceToDate] AS [Ngày Kết Thúc]";
            sql = sql + "     ,[ContractCode] AS [Mã Hợp Đồng LĐ]";
            sql = sql + "     ,[ContractType] AS [Kiểu Hợp Đồng]";
            sql = sql + "     ,[ContractSignDate] AS [Ngày Ký]";
            sql = sql + "     ,[ContractFromDate] AS [Kể Từ Ngày]";
            sql = sql + "     ,[ContractToDate] AS [Đến Ngày]";
            sql = sql + " FROM HRM_EMPLOYEE A, DIC_SCHOOL B, DIC_PROFESSIONAL C, DIC_DEPARTMENT D, DIC_WORK_STATE E";
            sql = sql + " WHERE A.School = B.SchoolCode ";
            sql = sql + " AND A.Professional = C.ProfessionalCode ";
            sql = sql + " AND A.DepartmentCode = D.DepartmentCode ";
            sql = sql + " AND A.WorkStateCode = E.WorkStateCode";
            sql = sql + " AND A.WorkStateCode IN ('TT000001','TT000003')";            
            return Select_Table(sql);

        }

        public static bool Delete(string code)
        {
            SqlConnection connection = DAO_BASE.Get_Connection();
            string deleteStatement
                = "UPDATE"
                + "  [HRM_EMPLOYEE]"
                + " SET "
                + " WorkStateCode ='TT000004'"
                + "  WHERE [EmployeeCode] = @Code";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.CommandType = CommandType.Text;
            deleteCommand.Parameters.AddWithValue("@Code", code);
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
    }

}
