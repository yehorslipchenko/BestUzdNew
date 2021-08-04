using BestUzdNew.Domain.Contracts;
using System.Collections.Generic;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class DiscountType : Entity
    {
        public DiscountType()
        {
            ServiceDiscounts = new HashSet<ServiceDiscount>();
            ServiceGroupDiscounts = new HashSet<ServiceGroupDiscount>();
            ServiceSetDiscounts = new HashSet<ServiceSetDiscount>();
        }

        public string NameAlias { get; set; }
        public string DescriptionAlias { get; set; }

        public virtual ICollection<ServiceDiscount> ServiceDiscounts { get; set; }
        public virtual ICollection<ServiceGroupDiscount> ServiceGroupDiscounts { get; set; }
        public virtual ICollection<ServiceSetDiscount> ServiceSetDiscounts { get; set; }
    }
}
