using PSN.Domain.Entities;
using PSN.Domain.Interfaces;

namespace PSN.Infrastructure.Persistence.Interfaces
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
    }
}
