using employeeManagement.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Services
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;
        }

        public List<Department> loadDept()
        {
            try
            {
                List<Department> deptList = new List<Department>();

                deptList = _context.Department.ToList();

                return deptList;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void addEmployee(Employee employee)
        {
            try
            {
                _context.Add(employee);
                _context.SaveChangesAsync();
                return;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void deleteEmployee(Employee employee)
        {
            try
            {
                _context.Employee.Remove(employee);
                _context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Employee> EmployeeList()
        {
            try
            {
                return _context.Employee
                .Include(d => d.Department).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        

        public void updateEmployee(Employee employee)
        {
            try
            {
                _context.Update(employee);
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void NotFound()
        {
            throw new NotImplementedException();
        }

    }
}
