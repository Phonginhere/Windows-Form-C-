using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_Prepare_Test2.Models
{
    public class Client
    {
        
        public int ClientId { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Nhập từ 2 đến 75", MinimumLength = 2)]
        public string ClientName { get; set; }
        [Required]
        [StringLength(maximumLength: 11, ErrorMessage = "Nhập từ 10 đến 11", MinimumLength = 10)]
        public string ClientPhone { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Nhập từ 2 đến 50", MinimumLength = 2)]
        public string ClientEmail { get; set; }
        [Required]
        [StringLength(maximumLength: 75, ErrorMessage = "Nhập từ 2 đến 75", MinimumLength = 2)]
        public string ClientCompany { get; set; }

        public virtual ICollection<AssignTask> AssignTask { get; set; }
    }
}