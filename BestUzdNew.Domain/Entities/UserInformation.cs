using System.Collections.Generic;
using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class UserInformation : Entity
    {
        public UserInformation()
        {
            Users = new HashSet<User>();
        }

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
