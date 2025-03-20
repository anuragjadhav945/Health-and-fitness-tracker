using System.ComponentModel.DataAnnotations;

namespace _fitness.Models
{
    public class Calorie
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int CaloriesConsumed { get; set; }
        [Required]
        public int CaloriesBurned { get; set; }
        [Required]
        public int DailyGoal { get; set; }

    }
}
