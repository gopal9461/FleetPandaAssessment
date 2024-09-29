using Entities.Attributes;
using System.Runtime.InteropServices;

namespace Entities.Models
{
    public class Customer
    {
        [Id]
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public List<Location> Locations { get; set; } = new List<Location>();

        public string LocationNames { get
            {
                var lNames = new List<string>();
                foreach(var location in Locations)
                {
                    if(location is not null) lNames.Add(location.Address?? "");
                }

                return string.Join("\n", lNames);
            } }

        public override bool Equals(object? obj)
        {
            if (obj is not Customer other) return false;

            return this.CustomerId == other.CustomerId && this.Name == other.Name && this.Email == other.Email && this.Phone == other.Phone;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.CustomerId, this.Name, this.Email, this.Phone);
        }
    }
}
