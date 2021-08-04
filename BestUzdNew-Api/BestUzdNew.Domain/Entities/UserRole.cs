using System.Collections.Generic;
using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class UserRole : Entity
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        public string NameAlias { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
