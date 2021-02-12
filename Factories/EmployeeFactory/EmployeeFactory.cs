using ExamSprout.Enum;
using ExamSprout.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout.Factories.EmployeeFactory
{
    public class EmployeeFactory
    {
        public IEmployeeService CalculateSalary(EmployeeType empType)
        {
            switch (empType)
            {
                case EmployeeType.REGULAR:
                    return new RegularEmployee();
                case EmployeeType.CONTRACT:
                    return new ContractEmployee();
                default:
                    throw new NotImplementedException();
            }
        }


    }
}
