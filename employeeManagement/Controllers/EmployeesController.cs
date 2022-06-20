using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using employeeManagement.Models;
using employeeManagement.Services;
using Microsoft.Extensions.Logging;

namespace employeeManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeContext _context;
        private readonly IEmployee _empRepo;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(EmployeeContext context, IEmployee empRepo, ILogger<EmployeesController> logger)
        {
            _context = context;
            _empRepo = empRepo;
            _logger = logger;
        }

        
        public async Task<IActionResult> Index()
        {
            try
            {
                List<Employee> employees = _empRepo.EmployeeList();
                return View(employees);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return RedirectToAction("Index");
            }
            
        }

        
        public IActionResult Create()
        {
            try
            {
                ViewBag.DeptList = _empRepo.loadDept();
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID,Name,Location,Email,Mobile,DeptID")] Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _empRepo.addEmployee(employee);
                    
                }
                // return View(employee);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return RedirectToAction("Index");
            }
            
        }

        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                ViewBag.DeptList = _empRepo.loadDept();
                var employee = await _context.Employee.FindAsync(id);
                if (employee == null)
                {
                    return NotFound();
                }
                return View(employee);
            }
            catch (Exception exep)
            {
                _logger.LogError(exep.Message);

                return RedirectToAction("Index");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Location,Email,Mobile,DeptID")] Employee employee)
        {
            if (id != employee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _empRepo.updateEmployee(employee);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.ID))
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var employee = await _context.Employee
                    .FindAsync(id);
                if (employee == null)
                {
                    return NotFound();
                }
                else
                {
                    _empRepo.deleteEmployee(employee);
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return RedirectToAction("Index");
            }
            
        }
        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.ID == id);
        }
    }
}
