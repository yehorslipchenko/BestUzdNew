using BestUzdNew.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    public interface IServiceForServiceGroupEntity
    {
        Task CreateServiceGroupAsync(ServiceGroup serviceGroup);
        Task<ICollection<ServiceGroup>> GetServiceGroupAsync();
    }
}
