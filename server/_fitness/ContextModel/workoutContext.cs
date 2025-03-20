

using _fitness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _fitness.ContextModel
{
    public class workoutContext : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> _builder)
        {
            _builder.ToTable("Workout");
            _builder.HasKey(x =>x.Id);
            _builder.Property(x => x.UserId).HasMaxLength(50);
            _builder.Property(x => x.Excercise).HasMaxLength(50);
            _builder.Property(x => x.Duration).HasMaxLength(50);
            _builder.Property(x => x.CaloriesBurned).HasMaxLength(50);
            _builder.Property(x => x.Date).HasMaxLength(50);

        }
    }
}
