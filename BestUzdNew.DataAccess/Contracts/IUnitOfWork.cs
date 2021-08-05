using BestUzdNew.Domain.Contracts;
using System;
using System.Threading.Tasks;

namespace BestUzdNew.DataAccess
{
    /// <summary>
    /// Please 
    /// </summary>
    public interface IUnitOfWork : IDisposable
    { 
        bool IsDisposed { get; }
        Task SaveChangesAsync();
        IRepository<T> GetRepository<T>() where T : Entity;
    }
}