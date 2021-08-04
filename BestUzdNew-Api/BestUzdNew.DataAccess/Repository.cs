using BestUzdNew.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BestUzdNew.DataAccess
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly BestUzdNewContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(BestUzdNewContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> Query { get { return _dbSet; } }

        public async Task<T> FindById(int id)
        {
            return await _dbSet.SingleAsync(x => x.Id == id);
        }

        public void AddOrUpdate(T item)
        {
            if (item.Id == default)
            {
                Create(item);
            }
            else
            {
                Update(item);
            }
        }

        public void Create(T item)
        {
            _dbSet.Add(item);
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }
    }
}
