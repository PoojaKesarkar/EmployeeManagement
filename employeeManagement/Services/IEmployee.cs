using employeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Services
{
    public interface IEmployee
    {
        List<Employee> EmployeeList();

        List<Department> loadDept();
        void addEmployee(Employee employee);
        void updateEmployee(Employee employee);
        void deleteEmployee(Employee employee);

        //List<Employee> FindEmployee(int ID);



    }
}
