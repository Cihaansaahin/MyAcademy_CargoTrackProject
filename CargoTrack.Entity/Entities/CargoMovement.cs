using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class CargoMovement : BaseEntity
    {
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; } = null!;

        public CargoStatus? FromStatus { get; set; }
        public CargoStatus ToStatus { get; set; }
        public DateTime MovementDate { get; set; }
        public string? Description { get; set; }

        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }

        public int? TransferCenterId { get; set; }
        public TransferCenter? TransferCenter { get; set; }

        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
