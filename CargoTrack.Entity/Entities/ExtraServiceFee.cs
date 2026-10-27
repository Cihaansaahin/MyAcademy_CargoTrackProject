using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class ExtraServiceFee : BaseEntity
    {
        public ExtraService Service { get; set; }
        public decimal Fee { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
