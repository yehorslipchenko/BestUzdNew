using System.Collections.Generic;
using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceGroup : Entity
    {
        public ServiceGroup()
        {
            ServiceGroupDiscounts = new HashSet<ServiceGroupDiscount>();
        }

        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }

        public virtual ICollection<ServiceGroupDiscount> ServiceGroupDiscounts { get; set; }
    }
}
