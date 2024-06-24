using Microsoft.EntityFrameworkCore;
using PSN.Domain.Entities;
using PSN.Domain.Interfaces;
using PSN.Infrastructure.Persistence.Contexts;

namespace PSN.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly PSNContext _context;
        private readonly DbSet<T> _entity;

        public GenericRepository(PSNContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var getAll = await _entity
                .Where(x => 
                x.State.Equals(1))
                .AsNoTracking()
                .ToListAsync();
            return getAll;
        }
        public async Task<T> GetByIdAsync(int id)
        {
            var getById = await _entity!
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            return getById!;
        }
        public async Task<bool> RegisterAsync(T entity)
        {
            entity.State = 1;

            await _context.AddAsync(entity);

            var recordAffected = await _context.SaveChangesAsync();
            return recordAffected > 0;
        }
        public async Task<bool> EditAsync(T entity)
        {
            _context.Update(entity);
            _context.Entry(entity).Property(x
                => x.State).IsModified = false;

            var recordAffected = await _context.SaveChangesAsync();
            return recordAffected > 0;
        }
        public async Task<bool> RemoveAsync(int id)
        {
            T entity = await GetByIdAsync(id);

            entity!.State = 0;

            _context.Update(entity);

            var recordAffected = await _context.SaveChangesAsync();
            return recordAffected > 0;
        }
    }
}
