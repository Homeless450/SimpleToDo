using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Models
{ 
    public class User 
    {
        public User()
        {
            Goals = new List<Goal>();
        }
        public virtual ICollection<Goal> Goals { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
