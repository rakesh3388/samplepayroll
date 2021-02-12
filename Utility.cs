using ExamSprout.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout
{
    public class Utility
    {
        public static SelectList FnGetEmployeeList(string selectedValue)
        {
            var response = new List<SelectListItem>();

            foreach (var employee in EmployeeDb.GetEmployees())
            {
                response.Add(new SelectListItem { Text = employee.Name, Value = employee.Id.ToString() });
            }

            var listTitle = response.Select(x => new { Value = x.Value, Text = x.Text }).ToList();
            return new SelectList(response, "Value", "Text", selectedValue);
        }

        // Instantiate random number generator.  
        private static readonly Random _random = new Random();

        // Generates a random number within a range.      
        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
