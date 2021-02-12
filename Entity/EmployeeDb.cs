using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamSprout.Enum;
namespace ExamSprout.Entity
{
    public class EmployeeDb
    {
        //
        public static List<EmployeeDb> employeeList = new List<EmployeeDb>();
        public EmployeeDb()
        {
          
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string TIN { get; set; }
        public string EmployeeType { get; set; }
        public float SalaryPm { get; set; }
        public float RatePerDay { get; set; }

        public static List<EmployeeDb> GetEmployees()
        {
            return employeeList;
        }

        public static EmployeeDb GetEmployeesbyId(int employeeId)
        {
            return GetEmployees().Find(x => x.Id == employeeId);
        }
    }

    

}
