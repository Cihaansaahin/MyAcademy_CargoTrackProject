using CargoTrack.Entity.Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }

        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
