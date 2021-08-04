using BestUzdNew.Domain.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace BestUzdNew.DataAccess
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T item);
        Task<T> FindById(int id);
        /// <summary>
        /// Only for read operations
        /// </summary>
        /// <returns>Query</returns>
        IQueryable<T> Query { get; }
        void Remove(T item);
        void Update(T item);
        void AddOrUpdate(T item);
    }
}