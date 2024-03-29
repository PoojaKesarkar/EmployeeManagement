﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace employeeManagement.Models
{
    public class Department
    {
        
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Key]
        public int DeptID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
