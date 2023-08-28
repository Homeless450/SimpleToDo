using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User 
    {
        public User()
        {
            Goals = new List<Goal>();
        }
        public int Id { get; set; }
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
