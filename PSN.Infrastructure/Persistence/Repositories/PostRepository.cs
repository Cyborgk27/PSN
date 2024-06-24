using PSN.Domain.Entities;
using PSN.Infrastructure.Persistence.Contexts;
using PSN.Infrastructure.Persistence.Interfaces;

namespace PSN.Infrastructure.Persistence.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(PSNContext context) : base(context) { }
    }
}
