using BestUzdNew.DataAccess;
using BestUzdNew.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using BestUzdNew.Domain.Constants;

namespace BestUzdNew.Logic
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateUserAsync(User user)
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                var basicRole = uow.GetRepository<UserRole>().Query.Single(x => x.NameAlias == UserRoleAliases.BasicRoleAlias);
                user.UserRole = basicRole;

                uow.GetRepository<UserInformation>().Create(user.UserInformation);
                uow.GetRepository<User>().Create(user);

                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<User>> GetUsersAsync()
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<User>()
                             .Query
                             .Include(x => x.UserInformation)
                             .ToListAsync();
            }
        }
    }
}
