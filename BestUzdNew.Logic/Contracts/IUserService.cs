using BestUzdNew.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    public interface IUserService
    {
        Task CreateUserAsync(User user);
        Task<ICollection<User>> GetUsersAsync();
    }
}