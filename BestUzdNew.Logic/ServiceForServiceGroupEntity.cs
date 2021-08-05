using BestUzdNew.DataAccess;
using BestUzdNew.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    class ServiceForServiceGroupEntity : IServiceForServiceGroupEntity
    {

        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public ServiceForServiceGroupEntity (IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateServiceGroupAsync(ServiceGroup serviceGroup)
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                uow.GetRepository<ServiceGroup>().Create(serviceGroup);
                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<ServiceGroup>> GetServiceGroupAsync()
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<ServiceGroup>()
                             .Query
                             .ToListAsync();
            }
        }
    }
}
