using BestUzdNew.Domain.Contracts;
using System.Collections.Generic;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Language : Entity
    {
        public Language()
        {
            Translations = new HashSet<Translation>();
        }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ImageSrc { get; set; }

        public virtual ICollection<Translation> Translations { get; set; }
    }
}
