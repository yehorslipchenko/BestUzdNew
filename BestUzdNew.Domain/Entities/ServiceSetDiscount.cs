using System;
using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class ServiceSetDiscount : Entity
    {
        public int DiscountTypeId { get; set; }
        public double Value { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual DiscountType DiscountType { get; set; }
        public virtual User User { get; set; }
    }
}
