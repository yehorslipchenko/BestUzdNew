using System.Collections.Generic;
using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class User : Entity
    {
        public User()
        {
            ServiceDiscounts = new HashSet<ServiceDiscount>();
            ServiceGroupDiscounts = new HashSet<ServiceGroupDiscount>();
            ServiceSetDiscounts = new HashSet<ServiceSetDiscount>();
        }

        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int UserInformationId { get; set; }
        public int UserRoleId { get; set; }

        public virtual UserInformation UserInformation { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<ServiceDiscount> ServiceDiscounts { get; set; }
        public virtual ICollection<ServiceGroupDiscount> ServiceGroupDiscounts { get; set; }
        public virtual ICollection<ServiceSetDiscount> ServiceSetDiscounts { get; set; }
    }
}
