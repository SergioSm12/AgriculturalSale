using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace AgriculturalSale.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly  ApplicationDbContext _context;

        public EntityBaseRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task AddAsync(T entity)
        {
            await this._context.Set<T>().AddAsync(entity);
            await this._context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await this._context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);
            EntityEntry entityEntry = this._context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await this._context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await this._context.Set<T>().ToListAsync();
       

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = this._context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) => await this._context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = this._context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }
    }
}
