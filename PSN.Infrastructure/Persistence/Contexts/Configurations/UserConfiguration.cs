using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSN.Domain.Entities;

namespace PSN.Infrastructure.Persistence.Contexts.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("UserId");

            builder.HasMany(x => x.Posts)
                .WithOne(p => p.User);

            builder.HasMany(x => x.Comments)
                .WithOne(c => c.User);
        }
    }
}
