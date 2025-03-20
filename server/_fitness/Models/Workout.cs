namespace _fitness.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Excercise { get; set; }
        public int Duration { get; set; }
        public int CaloriesBurned{ get; set; }
    }
}
