using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WindowsStore_Version4.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public string ClientPhone { get; set; }

        [Required]
        public string ClientEmail { get; set; }

        [Required]
        public string ClientCompany { get; set; }


        public virtual ICollection<AssignTask> AssignTask { get; set; }
    }
}