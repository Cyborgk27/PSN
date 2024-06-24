using Microsoft.EntityFrameworkCore;
using PSN.Domain.Entities;
using System.Reflection;

namespace PSN.Infrastructure.Persistence.Contexts
{
    public partial class PSNContext : DbContext
    {
        public PSNContext() { }

        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;

        public PSNContext(DbContextOptions<PSNContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
