using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string TIN { get; set; }
        public string EmployeeType { get; set; }
        public float SalaryPm { get; set; }
        public float RatePerDay { get; set; }
        public float TaxRate { get; set; }
    }
}
