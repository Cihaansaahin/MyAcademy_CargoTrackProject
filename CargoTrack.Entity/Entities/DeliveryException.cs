using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class DeliveryException :BaseEntity
    {
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; } = null!;

        public DeliveryFailureReason Reason { get; set; }
        public string? Description { get; set; }
        public DateTime AttemptDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
    }
}
