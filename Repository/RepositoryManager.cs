using Repository.Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<ICustomerRepository> _customerSource;
        private readonly Lazy<ICustomerRepository> _customerLocal;
        private readonly Lazy<ILocationRepository> _locationSource;
        private readonly Lazy<ILocationRepository> _locationLocal;
        private readonly Lazy<IChangeLogRepository> _changeLog;
        private readonly Lazy<ISyncRepository> _sync;

        public RepositoryManager()
        {
            _customerSource = new Lazy<ICustomerRepository>(() => new CustomerRepositorySource());
            _customerLocal = new Lazy<ICustomerRepository> (() => new CustomerRepositoryLocal());
            _locationSource = new Lazy<ILocationRepository>(() => new LocationRepositorySource());
            _locationLocal = new Lazy<ILocationRepository> (() => new LocationRepositoryLocal());
            _changeLog = new Lazy<IChangeLogRepository>(() => new ChangeLogRepository());
            _sync = new Lazy<ISyncRepository>(() => new SyncRepository());
        }

        public ICustomerRepository CustomerSource => _customerSource.Value;

        public ICustomerRepository CustomerLocal => _customerLocal.Value;

        public ILocationRepository LocationSource => _locationSource.Value;

        public ILocationRepository LocationLocal => _locationLocal.Value;

        public IChangeLogRepository ChangeLog => _changeLog.Value;

        public ISyncRepository Sync => _sync.Value;
    }
}
