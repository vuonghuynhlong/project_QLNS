using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.ENTITY
{
    public class HRM_EMPLOYEE
    {
        private String m_EmployeeCode;
        private String m_DepartmentCode;
        private String m_EnrollNumber;
        private String m_FirstName;
        private String m_LastName;
        private String m_Alias;
        private bool m_Sex;
        private String m_Marriage;
        private Nullable<DateTime> m_Birthday;
        private String m_BirthPlace;
        private String m_MainAddress;
        private String m_ContactAddress;
        private String m_CellPhone;
        private String m_Email;
        private String m_Nationality;
        private String m_Ethnic;
        private String m_Religion;
        private String m_Education;
        private String m_Language;
        private String m_Informatic;
        private String m_Professional;
        private String m_Position;
        private String m_School;
        private String m_IDCard;
        private Nullable<DateTime> m_IDCardDate;
        private String m_IDCardPlace;
        private Nullable<DateTime> m_BeginDate;
        private Nullable<Boolean> m_IsOffWork;
        private Nullable<DateTime> m_EndDate;
        private Nullable<Int32> m_PayForm;
        private Nullable<Decimal> m_PayMoney;
        private Nullable<Decimal> m_MinimumSalary;
        private String m_RankSalary;
        private Nullable<Int32> m_StepSalary;
        private Nullable<Decimal> m_CoefficientSalary;
        private Nullable<DateTime> m_DateSalary;
        private Nullable<Decimal> m_BasicSalary;
        private Nullable<Decimal> m_InsuranceSalary;
        private Nullable<Decimal> m_Allowance1;
        private Nullable<Decimal> m_Allowance2;
        private Nullable<Decimal> m_Allowance3;
        private Nullable<Decimal> m_Allowance4;
        private Nullable<Boolean> m_IsSocialInsurance;
        private Nullable<Boolean> m_IsHealthInsurance;
        private Nullable<Boolean> m_IsUnemploymentInsurance;
        private Nullable<Boolean> m_IsUnionMoney;
        private Nullable<Boolean> m_IsUnion;
        private String m_UnionCode;
        private Nullable<DateTime> m_UnionDate;
        private String m_UnionPlace;
        private Nullable<Boolean> m_IsParty;
        private String m_PartyCode;
        private Nullable<DateTime> m_PartyDate;
        private String m_PartyPlace;
        private String m_InsuranceCode;
        private Nullable<DateTime> m_InsuranceDate;
        private String m_HealthInsuranceCode;
        private Nullable<DateTime> m_HealthInsuranceFromDate;
        private Nullable<DateTime> m_HealthInsuranceToDate;
        private String m_ContractCode;
        private String m_ContractType;
        private Nullable<DateTime> m_ContractSignDate;
        private Nullable<DateTime> m_ContractFromDate;
        private Nullable<DateTime> m_ContractToDate;
        private String m_WorkStateCode;
        private byte[] m_Photo;
        public HRM_EMPLOYEE() { }

        public String EmployeeCode
        {
            get
            {
                return m_EmployeeCode;
            }
            set
            {
                m_EmployeeCode = value;
            }
        }
        public String DepartmentCode
        {
            get
            {
                return m_DepartmentCode;
            }
            set
            {
                m_DepartmentCode = value;
            }
        }

        public String EnrollNumber
        {
            get
            {
                return m_EnrollNumber;
            }
            set
            {
                m_EnrollNumber = value;
            }
        }

        public String FirstName
        {
            get
            {
                return m_FirstName;
            }
            set
            {
                m_FirstName = value;
            }
        }

        public String LastName
        {
            get
            {
                return m_LastName;
            }
            set
            {
                m_LastName = value;
            }
        }

        public String Alias
        {
            get
            {
                return m_Alias;
            }
            set
            {
                m_Alias = value;
            }
        }

        public bool Sex
        {
            get
            {
                return m_Sex;
            }
            set
            {
                m_Sex = value;
            }
        }

        public String Marriage
        {
            get
            {
                return m_Marriage;
            }
            set
            {
                m_Marriage = value;
            }
        }

        public Nullable<DateTime> Birthday
        {
            get
            {
                return m_Birthday;
            }
            set
            {
                m_Birthday = value;
            }
        }

        public String BirthPlace
        {
            get
            {
                return m_BirthPlace;
            }
            set
            {
                m_BirthPlace = value;
            }
        }

        public String MainAddress
        {
            get
            {
                return m_MainAddress;
            }
            set
            {
                m_MainAddress = value;
            }
        }

        public String ContactAddress
        {
            get
            {
                return m_ContactAddress;
            }
            set
            {
                m_ContactAddress = value;
            }
        }

        public String CellPhone
        {
            get
            {
                return m_CellPhone;
            }
            set
            {
                m_CellPhone = value;
            }
        }

        public String Email
        {
            get
            {
                return m_Email;
            }
            set
            {
                m_Email = value;
            }
        }

        public String Nationality
        {
            get
            {
                return m_Nationality;
            }
            set
            {
                m_Nationality = value;
            }
        }

        public String Ethnic
        {
            get
            {
                return m_Ethnic;
            }
            set
            {
                m_Ethnic = value;
            }
        }

        public String Religion
        {
            get
            {
                return m_Religion;
            }
            set
            {
                m_Religion = value;
            }
        }

        public String Education
        {
            get
            {
                return m_Education;
            }
            set
            {
                m_Education = value;
            }
        }

        public String Language
        {
            get
            {
                return m_Language;
            }
            set
            {
                m_Language = value;
            }
        }

        public String Informatic
        {
            get
            {
                return m_Informatic;
            }
            set
            {
                m_Informatic = value;
            }
        }

        public String Professional
        {
            get
            {
                return m_Professional;
            }
            set
            {
                m_Professional = value;
            }
        }

        public String Position
        {
            get
            {
                return m_Position;
            }
            set
            {
                m_Position = value;
            }
        }

        public String School
        {
            get
            {
                return m_School;
            }
            set
            {
                m_School = value;
            }
        }

        public String IDCard
        {
            get
            {
                return m_IDCard;
            }
            set
            {
                m_IDCard = value;
            }
        }


        

        public Nullable<DateTime> IDCardDate
        {
            get
            {
                return m_IDCardDate;
            }
            set
            {
                m_IDCardDate = value;
            }
        }

        public String IDCardPlace
        {
            get
            {
                return m_IDCardPlace;
            }
            set
            {
                m_IDCardPlace = value;
            }
        }

        public Nullable<DateTime> BeginDate
        {
            get
            {
                return m_BeginDate;
            }
            set
            {
                m_BeginDate = value;
            }
        }

        public Nullable<Boolean> IsOffWork
        {
            get
            {
                return m_IsOffWork;
            }
            set
            {
                m_IsOffWork = value;
            }
        }

        public Nullable<DateTime> EndDate
        {
            get
            {
                return m_EndDate;
            }
            set
            {
                m_EndDate = value;
            }
        }

        public Nullable<Int32> PayForm
        {
            get
            {
                return m_PayForm;
            }
            set
            {
                m_PayForm = value;
            }
        }

        public Nullable<Decimal> PayMoney
        {
            get
            {
                return m_PayMoney;
            }
            set
            {
                m_PayMoney = value;
            }
        }

        public Nullable<Decimal> MinimumSalary
        {
            get
            {
                return m_MinimumSalary;
            }
            set
            {
                m_MinimumSalary = value;
            }
        }

        public String RankSalary
        {
            get
            {
                return m_RankSalary;
            }
            set
            {
                m_RankSalary = value;
            }
        }

        public Nullable<Int32> StepSalary
        {
            get
            {
                return m_StepSalary;
            }
            set
            {
                m_StepSalary = value;
            }
        }

        public Nullable<Decimal> CoefficientSalary
        {
            get
            {
                return m_CoefficientSalary;
            }
            set
            {
                m_CoefficientSalary = value;
            }
        }

        public Nullable<DateTime> DateSalary
        {
            get
            {
                return m_DateSalary;
            }
            set
            {
                m_DateSalary = value;
            }
        }

        public Nullable<Decimal> BasicSalary
        {
            get
            {
                return m_BasicSalary;
            }
            set
            {
                m_BasicSalary = value;
            }
        }

        public Nullable<Decimal> InsuranceSalary
        {
            get
            {
                return m_InsuranceSalary;
            }
            set
            {
                m_InsuranceSalary = value;
            }
        }

        public Nullable<Decimal> Allowance1
        {
            get
            {
                return m_Allowance1;
            }
            set
            {
                m_Allowance1 = value;
            }
        }

        public Nullable<Decimal> Allowance2
        {
            get
            {
                return m_Allowance2;
            }
            set
            {
                m_Allowance2 = value;
            }
        }

        public Nullable<Decimal> Allowance3
        {
            get
            {
                return m_Allowance3;
            }
            set
            {
                m_Allowance3 = value;
            }
        }

        public Nullable<Decimal> Allowance4
        {
            get
            {
                return m_Allowance4;
            }
            set
            {
                m_Allowance4 = value;
            }
        }

        public Nullable<Boolean> IsSocialInsurance
        {
            get
            {
                return m_IsSocialInsurance;
            }
            set
            {
                m_IsSocialInsurance = value;
            }
        }

        public Nullable<Boolean> IsHealthInsurance
        {
            get
            {
                return m_IsHealthInsurance;
            }
            set
            {
                m_IsHealthInsurance = value;
            }
        }

        public Nullable<Boolean> IsUnemploymentInsurance
        {
            get
            {
                return m_IsUnemploymentInsurance;
            }
            set
            {
                m_IsUnemploymentInsurance = value;
            }
        }

        public Nullable<Boolean> IsUnionMoney
        {
            get
            {
                return m_IsUnionMoney;
            }
            set
            {
                m_IsUnionMoney = value;
            }
        }

        public Nullable<Boolean> IsUnion
        {
            get
            {
                return m_IsUnion;
            }
            set
            {
                m_IsUnion = value;
            }
        }

        public String UnionCode
        {
            get
            {
                return m_UnionCode;
            }
            set
            {
                m_UnionCode = value;
            }
        }

        public Nullable<DateTime> UnionDate
        {
            get
            {
                return m_UnionDate;
            }
            set
            {
                m_UnionDate = value;
            }
        }

        public String UnionPlace
        {
            get
            {
                return m_UnionPlace;
            }
            set
            {
                m_UnionPlace = value;
            }
        }

        public Nullable<Boolean> IsParty
        {
            get
            {
                return m_IsParty;
            }
            set
            {
                m_IsParty = value;
            }
        }

        public String PartyCode
        {
            get
            {
                return m_PartyCode;
            }
            set
            {
                m_PartyCode = value;
            }
        }

        public Nullable<DateTime> PartyDate
        {
            get
            {
                return m_PartyDate;
            }
            set
            {
                m_PartyDate = value;
            }
        }

        public String PartyPlace
        {
            get
            {
                return m_PartyPlace;
            }
            set
            {
                m_PartyPlace = value;
            }
        }

        public String InsuranceCode
        {
            get
            {
                return m_InsuranceCode;
            }
            set
            {
                m_InsuranceCode = value;
            }
        }

        public Nullable<DateTime> InsuranceDate
        {
            get
            {
                return m_InsuranceDate;
            }
            set
            {
                m_InsuranceDate = value;
            }
        }

        public String HealthInsuranceCode
        {
            get
            {
                return m_HealthInsuranceCode;
            }
            set
            {
                m_HealthInsuranceCode = value;
            }
        }

        public Nullable<DateTime> HealthInsuranceFromDate
        {
            get
            {
                return m_HealthInsuranceFromDate;
            }
            set
            {
                m_HealthInsuranceFromDate = value;
            }
        }

        public Nullable<DateTime> HealthInsuranceToDate
        {
            get
            {
                return m_HealthInsuranceToDate;
            }
            set
            {
                m_HealthInsuranceToDate = value;
            }
        }

        public String ContractCode
        {
            get
            {
                return m_ContractCode;
            }
            set
            {
                m_ContractCode = value;
            }
        }

        public String ContractType
        {
            get
            {
                return m_ContractType;
            }
            set
            {
                m_ContractType = value;
            }
        }

        public Nullable<DateTime> ContractSignDate
        {
            get
            {
                return m_ContractSignDate;
            }
            set
            {
                m_ContractSignDate = value;
            }
        }

        public Nullable<DateTime> ContractFromDate
        {
            get
            {
                return m_ContractFromDate;
            }
            set
            {
                m_ContractFromDate = value;
            }
        }

        public Nullable<DateTime> ContractToDate
        {
            get
            {
                return m_ContractToDate;
            }
            set
            {
                m_ContractToDate = value;
            }
        }

        public String WorkStateCode
        {
            get
            {
                return m_WorkStateCode;
            }
            set
            {
                m_WorkStateCode = value;
            }
        }

        public byte[] Photo
        {
            get
            {
                return m_Photo;
            }
            set
            {
                m_Photo = value;
            }
        }
    }

}
