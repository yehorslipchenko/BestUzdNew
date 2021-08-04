namespace BestUzdNew.DataAccess
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork UnitOfWork { get; }
    }
}