using BestUzdNew.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BestUzdNew.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BestUzdNewContext _context;
        private bool _disposed = false;

        public bool IsDisposed { get { return _disposed; } }

        public UnitOfWork(BestUzdNewContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : Entity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            UpdateSoftDeleteStatuses();
            await _context.SaveChangesAsync();
        }

        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }

        private void UpdateSoftDeleteStatuses()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["IsDeleted"] = false;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["IsDeleted"] = true;
                        break;
                }
            }
        }

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}
