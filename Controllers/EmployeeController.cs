using AutoMapper;
using ExamSprout.Entity;
using ExamSprout.Enum;
using ExamSprout.Factories.EmployeeFactory;
using ExamSprout.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamSprout.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeFactory employeeFactory;
        private readonly IMapper _mapper;
        public EmployeeController(EmployeeFactory employeeFactory, IMapper _mapper)
        {
            this.employeeFactory = employeeFactory;
            this._mapper = _mapper;
        }

        // GET: EmployeeController1
        public ActionResult Index()
        {
            ViewBag.EmployeeList = Utility.FnGetEmployeeList("");
            return View();
        }
        public JsonResult GetEmployee(int id)
        {
            if(id > 0)
            {
                var entity = EmployeeDb.GetEmployeesbyId(id);
                var employee =  _mapper.Map<EmployeeDb, EmployeeViewModel>(entity);
                return Json(employee);
            }
            else
            {
                return Json("");
            }
            
        }


        public JsonResult GetSalary(int id,float value,string employeeType)
        {
            if (id > 0)
            {
                
                EmployeeType.TryParse(employeeType, out EmployeeType type);
                var res = employeeFactory.CalculateSalary(type);
                var result =  res.calculateSalary(id, value);
                return Json(result);
            }
            else
            {
                return Json("");
            }

        }

        // GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            return View(EmployeeDb.employeeList);
        }

        // GET: EmployeeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController1/Create
        [HttpPost]
        public ActionResult Create(EmployeeViewModel collection)
        {
            try
            {
                var employee = _mapper.Map<EmployeeViewModel,EmployeeDb >(collection);
                employee.Id = Utility.RandomNumber(50, 5000);
                EmployeeDb.employeeList.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
