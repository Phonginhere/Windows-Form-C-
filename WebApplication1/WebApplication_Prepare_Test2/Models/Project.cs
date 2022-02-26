using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Prepare_Test2.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Nhập từ 2 đến 50", MinimumLength = 2)]
        public string ProjectName { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ProjectStart { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ProjectEnd { get; set; }
        [Required]
        [StringLength(maximumLength: 75, ErrorMessage = "Nhập từ 2 đến 75", MinimumLength = 2)]
        public string ProjectDescription { get; set; }

        public virtual ICollection<AssignTask> AssignTask { get; set; }
    }
}