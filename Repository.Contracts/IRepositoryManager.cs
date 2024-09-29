namespace Repository.Contracts
{
    public interface IRepositoryManager
    {
        ICustomerRepository CustomerSource { get; }

        ICustomerRepository CustomerLocal { get; }

        ILocationRepository LocationSource { get; }

        ILocationRepository LocationLocal { get; }

        IChangeLogRepository ChangeLog { get; }

        ISyncRepository Sync {  get; }
    }
}
