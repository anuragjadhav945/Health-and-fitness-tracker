using _fitness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _fitness.ContextModel
{

    public class trendContext : IEntityTypeConfiguration<Trend>
    {
        public void Configure(EntityTypeBuilder<Trend> _builder)
        {
            _builder.ToTable("Trend");
            _builder.HasKey(x => x.Id);
            _builder.Property(x => x.UserId);
            _builder.Property(x => x.Weight).HasMaxLength(50);
            _builder.Property(x => x.BMI).HasMaxLength(50);
            _builder.Property(x => x.Date).HasMaxLength(50);
        }
    }
}
