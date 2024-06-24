using PSN.Domain.Entities;
using PSN.Infrastructure.Persistence.Contexts;
using PSN.Infrastructure.Persistence.Interfaces;

namespace PSN.Infrastructure.Persistence.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(PSNContext context) : base(context) { }
    }
}
