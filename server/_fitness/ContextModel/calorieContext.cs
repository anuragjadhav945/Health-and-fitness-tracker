using _fitness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _fitness.ContextModel
{
    public class calorieContext : IEntityTypeConfiguration<Calorie>
    {
        public void Configure(EntityTypeBuilder<Calorie> _builder)
        {
            _builder.ToTable("Calorie");
            _builder.HasKey(x => x.Id);
            _builder.Property(x => x.UserId);
            _builder.Property(x => x.CaloriesBurned).HasMaxLength(50);
            _builder.Property(x => x.CaloriesBurned).HasMaxLength(50);
            _builder.Property(x => x.DailyGoal).HasMaxLength(50);
        }

        
    }
}
