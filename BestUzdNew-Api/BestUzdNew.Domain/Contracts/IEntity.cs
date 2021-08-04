using BestUzdNew.Domain.Contracts;

namespace BestUzdNew.Domain
{
    public interface IEntity : ISoftDelete
    {
        public int Id { get; set; }
    }
}
