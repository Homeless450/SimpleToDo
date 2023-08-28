using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Goal
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int UserId { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime? EndDay { get; set; }
        public bool Repeating { get; set; }
        public bool Completed { get; set; } = false;
    }
}
