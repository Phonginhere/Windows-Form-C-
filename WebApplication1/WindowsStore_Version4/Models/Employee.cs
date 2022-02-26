using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WindowsStore_Version4.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeeEmail { get; set; }

        [Required]
        public string EmployeePhone { get; set; }

        [Required]
        public string EmployeeDepartment { get; set; }

        public virtual ICollection<AssignTask> AssignTask { get; set; }
    }
}