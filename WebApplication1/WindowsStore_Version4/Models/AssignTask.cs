using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WindowsStore_Version4.Models
{
    public class AssignTask
    {
        public int AssignTaskId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ClientId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public string Task { get; set; }

        [Required]
        public string Note { get; set; }


        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; }
        public virtual Project Project { get; set; }
    }
}