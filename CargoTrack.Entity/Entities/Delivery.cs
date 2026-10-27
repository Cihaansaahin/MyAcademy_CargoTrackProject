using CargoTrack.Entity.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class Delivery : BaseEntity
    {
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; } = null!;

        public DateTime DeliveredDate { get; set; }
        public string ReceivedByName { get; set; } = null!;
        public string? ReceiverRelation { get; set; }
        public string? Note { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}
