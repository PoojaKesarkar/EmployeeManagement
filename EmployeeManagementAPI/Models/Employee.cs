using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(10), MinLength(10)]
        public string Mobile { get; set; }


        [Required]
        public int DeptID { get; set; }
        [ForeignKey("DeptID")]
        public virtual Department Department { get; set; }
    }
}
