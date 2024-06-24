using PSN.Domain.Entities;
using PSN.Infrastructure.Persistence.Contexts;
using PSN.Infrastructure.Persistence.Interfaces;

namespace PSN.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(PSNContext context) : base(context) { }
    }
}
