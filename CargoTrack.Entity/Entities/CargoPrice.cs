using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class CargoPrice : BaseEntity
    {
        public DistanceZone Zone { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public decimal MinWeight { get; set; }
        public decimal MaxWeight { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
