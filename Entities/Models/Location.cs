using Entities.Attributes;

namespace Entities.Models
{
    public class Location
    {
        [Id]
        public int LocationId { get; set; }
        public int CustomerId { get; set; }
        public string? Address { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Location other) return false;

            return this.LocationId == other.LocationId && this.CustomerId == other.CustomerId && this.Address == other.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.LocationId, this.CustomerId, this.Address);
        }
    }
}
