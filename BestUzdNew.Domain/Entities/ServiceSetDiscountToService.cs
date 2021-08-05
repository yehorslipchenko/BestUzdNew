using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceSetDiscountToService : Entity
    {
        public int ServiceSetDiscountId { get; set; }
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }
        public virtual ServiceSetDiscount ServiceSetDiscount { get; set; }
    }
}
