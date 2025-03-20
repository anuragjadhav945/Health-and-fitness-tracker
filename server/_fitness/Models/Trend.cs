using System.ComponentModel.DataAnnotations;

namespace _fitness.Models
{
    public class Trend
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double BMI { get; set; }
    }
}
