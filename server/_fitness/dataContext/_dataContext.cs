using _fitness.ContextModel;
using _fitness.Models;
using Microsoft.EntityFrameworkCore;

namespace _fitness.dataContext
{
    public class _dataContext :DbContext
    {
        public _dataContext(DbContextOptions<_dataContext> options):base(options)
        {             
        }
        public DbSet<users> User { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Trend> Trends { get; set; }
        public DbSet<Calorie> Calories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new userContext());
            modelBuilder.ApplyConfiguration(new workoutContext());
            modelBuilder.ApplyConfiguration(new trendContext());
            modelBuilder.ApplyConfiguration(new calorieContext());

        }
        

    }
}
