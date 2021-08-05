using BestUzdNew.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    public interface IServiceForServiceEntity
    {
        Task CreateServiceAsync(Service service, Translation nameTranslation, Translation descriptionTranslation);
        Task<ICollection<Service>> GetServicesAsync();
    }
}