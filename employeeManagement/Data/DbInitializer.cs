using employeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var department = new Department[]
            {
            new Department{Name="HR"},
            new Department{Name="IT"},
            new Department{Name="QA"},
            new Department{Name="Finance"}
            };
            foreach (Department d in department)
            {
                context.Department.Add(d);
            }
            context.SaveChanges();

            var students = new Employee[]
            {
            new Employee{Name="Pooja",Location="Vasco",Email="pooja@abc.com",Mobile="7896754637",DeptID=2},
            new Employee{Name="Vansh",Location="Margao",Email="vansh@abc.com",Mobile="9823167453",DeptID=4},
            new Employee{Name="Prajal",Location="Panjim",Email="prajal@abc.com",Mobile="8752176538",DeptID=1},
            new Employee{Name="Darsh",Location="Quepem",Email="darsh@abc.com",Mobile="9867253423",DeptID=3},
            new Employee{Name="Saachi",Location="Fatorda",Email="saachi@abc.com",Mobile="7856476382",DeptID=3},
            new Employee{Name="Laksh",Location="Mapusa",Email="laksh@abc.com",Mobile="7687342516",DeptID=1},
            new Employee{Name="Shambhavi",Location="Paroda",Email="shambhavi@abc.com",Mobile="8976574563",DeptID=4},
            new Employee{Name="Varad",Location="Verna",Email="varad@abc.com",Mobile="8984537622",DeptID=2},
            new Employee{Name="Reyansh",Location="Pernem",Email="reyansh@abc.com",Mobile="8768798767",DeptID=3},
            new Employee{Name="sejal",Location="Ponda",Email="sejal@abc.com",Mobile="9797879798",DeptID=1},
            new Employee{Name="ekansh",Location="shiroda",Email="ekansh@abc.com",Mobile="9797879798",DeptID=2},
            new Employee{Name="priyanka",Location="Honda",Email="priyanka@abc.com",Mobile="9797879798",DeptID=4},
            new Employee{Name="Prashant",Location="cortalim",Email="prashant@abc.com",Mobile="7856476381",DeptID=3},
            new Employee{Name="Prajakta",Location="Vasco",Email="prajakta@abc.com",Mobile="9797879798",DeptID=1},
            };
            foreach (Employee s in students)
            {
                context.Employee.Add(s);
            }
            context.SaveChanges();

            
        }
    }
}
