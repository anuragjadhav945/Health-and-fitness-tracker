using _fitness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _fitness.ContextModel
{
    public class userContext : IEntityTypeConfiguration<users>
    {
        public void Configure(EntityTypeBuilder<users> _builder)
        {
            _builder.ToTable("users");
            _builder.HasKey( x => x.Id);
            _builder.Property(x => x.Name).HasMaxLength(50);
            _builder.Property(x => x.Email).HasMaxLength(50);
            _builder.Property(x => x.Password).HasMaxLength(50);
            _builder.Property(x => x.Createddate).HasMaxLength(50);
        }
    }
}
