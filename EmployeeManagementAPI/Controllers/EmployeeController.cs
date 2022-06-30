using employeeManagement.Services;
using EmployeeManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IEmployee _empRepo;

        public EmployeeController(IConfiguration configuration, IEmployee empRepo)
        {
            _configuration = configuration;
            _empRepo = empRepo;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmpList()
        {
            //try
            //{
                return _empRepo.EmployeeList();
                //return View(employees);
            //}
            //catch (Exception ex)
            //{
            //    //_logger.LogError(ex.Message);

                //return RedirectToAction("Index");
            //}
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
