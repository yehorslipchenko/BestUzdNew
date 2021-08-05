using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Order : Entity
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int ServiceId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual Service Service { get; set; }
    }
}
