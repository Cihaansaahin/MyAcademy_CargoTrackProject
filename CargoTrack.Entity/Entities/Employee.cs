using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class Employee :BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public EmployeePosition Position { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; } = null!;

        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
