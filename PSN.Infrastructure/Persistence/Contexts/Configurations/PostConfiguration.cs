using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSN.Domain.Entities;

namespace PSN.Infrastructure.Persistence.Contexts.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("PostId");

            builder.HasOne(x => x.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(x => x.PostId);
        }
    }
}
