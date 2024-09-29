using Entities.Attributes;
using Entities.Models;
using Repository;
using Repository.Contracts;
using Service.Contracts;

namespace Service
{
    public class SyncService : ISyncService
    {
        private readonly IRepositoryManager _repository;
        public SyncService()
        {
            _repository = new RepositoryManager();
        }

        public async Task<IEnumerable<Customer>> GetCustomersWithLocationFromLocal()
        {
            return await _repository.CustomerLocal.GetCustomersWithLocation();
        }

        public async Task SyncData()
        {
            var sourceCustomers = await _repository.CustomerSource.GetCustomers();
            var sourceLocations = await _repository.LocationSource.GetLocations();
            var localCustomers = await _repository.CustomerLocal.GetCustomers();
            var localLocations = await _repository.LocationLocal.GetLocations();

            await _repository.Sync.SyncData(sourceCustomers, sourceLocations);

            var changes = new List<ChangeLog>();
            var customerChanges = GetChangesForCustomer(localCustomers, sourceCustomers);
            var locationChanges = GetChangesForLocation(localLocations, sourceLocations);
            changes.AddRange(customerChanges);
            changes.AddRange(locationChanges);

            await _repository.ChangeLog.SaveChangeLogs(changes);
        }

        private List<ChangeLog> GetChangesForCustomer(IEnumerable<Customer> currentData, IEnumerable<Customer> newData)
        {
            var changes = new List<ChangeLog>();

            foreach (var customer in newData)
            {
                var currentCustomer = currentData.Where(x => x.CustomerId == customer.CustomerId).SingleOrDefault();
                if (currentCustomer is null) continue;
                if (currentCustomer.Equals(customer)) continue;

                var rowWiseChanges = GetChangesPerRow(currentCustomer, customer);
                changes.AddRange(rowWiseChanges);
            }

            return changes;
        }

        private List<ChangeLog> GetChangesForLocation(IEnumerable<Location> currentData, IEnumerable<Location> newData)
        {
            var changes = new List<ChangeLog>();

            foreach (var location in newData)
            {
                var currentLocation = currentData.Where(x => x.LocationId == location.LocationId).SingleOrDefault();
                if (currentLocation is null) continue;
                if (currentLocation.Equals(location)) continue;

                var rowWiseChanges = GetChangesPerRow(currentLocation, location);
                changes.AddRange(rowWiseChanges);
            }

            return changes;
        }

        private List<ChangeLog> GetChangesPerRow<T>(T current, T other)
        {
            var changes = new List<ChangeLog>();

            var entityType = typeof(T);
            var properties = entityType.GetProperties();
            var idProperty = properties.FirstOrDefault(x => x.GetCustomAttributes(typeof(IdAttribute), false).Any());
            if (idProperty is null) return changes;

            foreach (var property in properties)
            {
                var currentValue = property.GetValue(current);
                var newValue = property.GetValue(other);

                if (!Equals(currentValue, newValue))
                {
                    var changeLog = new ChangeLog()
                    {
                        TableName = entityType.Name,
                        RecordId = (int)idProperty.GetValue(current)!,
                        ColumnName = property.Name,
                        PreviousValue = currentValue?.ToString(),
                        NewValue = newValue?.ToString()
                    };
                    changes.Add(changeLog);
                }
            }

            return changes;
        }
    }
}
