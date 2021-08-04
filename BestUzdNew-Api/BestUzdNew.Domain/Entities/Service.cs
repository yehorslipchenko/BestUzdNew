using System.Collections.Generic;
using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Service : Entity
    {
        public Service()
        {
            Orders = new HashSet<Order>();
            ServiceDiscounts = new HashSet<ServiceDiscount>();
        }

        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ServiceDiscount> ServiceDiscounts { get; set; }
    }
}
