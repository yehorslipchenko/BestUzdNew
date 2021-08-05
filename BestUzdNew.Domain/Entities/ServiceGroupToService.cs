using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceGroupToService : Entity
    {
        public int ServiceGroupId { get; set; }
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
        public virtual ServiceGroup ServiceGroup { get; set; }
    }
}
