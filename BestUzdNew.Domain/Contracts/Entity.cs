namespace BestUzdNew.Domain.Contracts
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
