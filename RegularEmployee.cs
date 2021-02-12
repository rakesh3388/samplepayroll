using ExamSprout.Entity;
using ExamSprout.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout
{
    public class RegularEmployee : IEmployeeService
    {
        public EmployeeSalary calculateSalary(int employeeId, float value)
        {
            var salary = new EmployeeSalary();

            var employee = EmployeeDb.GetEmployeesbyId(employeeId);
            var oneDaySalary = employee.SalaryPm / 22;
            var absentDeduction = oneDaySalary * value;
            var taxDeduction = employee.SalaryPm * Constants.TaxRate / 100;

            var totalPay = employee.SalaryPm - absentDeduction - (taxDeduction);
            var tt = Math.Round(totalPay, 2);

            salary.totol_amount = String.Format("{0:0.00}", employee.SalaryPm);
            salary.absents = String.Format("{0:0.00}", value);
            salary.absent_deduction = String.Format("{0:0.00}", absentDeduction);
            salary.tax_deduction = String.Format("{0:0.00}", taxDeduction);
            salary.net_payable = String.Format("{0:0.00}", tt);
            salary.work_type = employee.EmployeeType;
            return salary;
        }
    }

}
