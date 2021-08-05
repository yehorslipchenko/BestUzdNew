using BestUzdNew.Domain.Contracts;

#nullable disable

namespace BestUzdNew.Domain.Entities
{
    public partial class Translation : Entity
    {
        public string Alias { get; set; }
        public string Translation1 { get; set; }
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}
