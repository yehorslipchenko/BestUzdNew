namespace BestUzdNew.DataAccess
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private BestUzdNewContext _context;
        private IUnitOfWork _currentUnitOfWork;

        public UnitOfWorkFactory()
        {
            SetNewContext();
            SetNewUnitOfWork();
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (_currentUnitOfWork.IsDisposed)
                {
                    SetNewContext();
                    SetNewUnitOfWork();
                }

                return _currentUnitOfWork;
            }
        }

        private void SetNewContext()
        {
            _context = new BestUzdNewContext();
        }

        private void SetNewUnitOfWork()
        {
            _currentUnitOfWork = new UnitOfWork(_context);
        }
    }
}
