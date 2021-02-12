using AutoMapper;
using ExamSprout.Entity;
using ExamSprout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<EmployeeDb, EmployeeViewModel>().ReverseMap();
        }
    }
}
