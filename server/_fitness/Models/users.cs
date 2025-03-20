using System.ComponentModel.DataAnnotations;

namespace _fitness.Models
{
    public class users
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        public required string Password { get; set; }
        
        public DateTime Createddate { get; set; }
        public required string Email { get; set; }
    }
}
