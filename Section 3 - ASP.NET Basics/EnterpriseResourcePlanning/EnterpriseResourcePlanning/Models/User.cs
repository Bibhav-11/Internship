using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseResourcePlanning.Models
{
    [Index(nameof(UserName), IsUnique = true)]
    public class User
    {
        public int Id { get; set; } 

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }    

        public string Role { get; set; }   
    }
}
