using PSN.Infrastructure.Persistence.Contexts;
using PSN.Infrastructure.Persistence.Interfaces;

namespace PSN.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PSNContext _context;
        public IUserRepository User { get; private set; }
        public IPostRepository Post { get; private set; }
        public ICommentRepository Comment { get; private set; }

        public UnitOfWork(PSNContext context)
        {
            _context = context;
            User = new UserRepository(_context);
            Post = new PostRepository(_context);
            Comment = new CommentRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
