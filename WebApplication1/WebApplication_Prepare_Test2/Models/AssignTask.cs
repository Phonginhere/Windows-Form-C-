using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Prepare_Test2.Models
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
        [Display(Name = "Nhiệm vụ")]
        [StringLength(maximumLength: 75, ErrorMessage = "Nhập từ 2 đến 75", MinimumLength = 2)]
        public String Task { get; set; }
        [Required]
        [Display(Name = "Ghi chú")]
        [StringLength(maximumLength: 100, ErrorMessage = "Nhập từ 2 đến 100", MinimumLength = 2)]
        public String Note { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual Client Client { get; set; }
    }
}