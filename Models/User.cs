using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Models
{ 
    public class User : IdentityUser<int>
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

        public bool ActivityStatus { get; set; }
    }
}