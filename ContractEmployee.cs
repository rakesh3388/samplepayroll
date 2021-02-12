using ExamSprout.Entity;
using ExamSprout.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout
{
    public class ContractEmployee : IEmployeeService
    {
        public EmployeeSalary calculateSalary(int employeeId, float value)
        {
            var salary = new EmployeeSalary();
            var employee = EmployeeDb.GetEmployeesbyId(employeeId);
            var totalPay = employee.RatePerDay * value;

            var tt = Math.Round(totalPay, 2);
            salary.totol_amount = String.Format("{0:0.00}", employee.SalaryPm);
            salary.days_worked = String.Format("{0:0.00}", value);
            salary.net_payable = String.Format("{0:0.00}", tt);
            salary.rate_perday = String.Format("{0:0.00}", employee.RatePerDay);
            salary.work_type = employee.EmployeeType;
            return salary;
        }
    }
}
