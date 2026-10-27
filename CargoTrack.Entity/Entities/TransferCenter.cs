using CargoTrack.Entity.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class TransferCenter : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string AdressLine { get; set; } = null!;
        public bool IsActive { get; set; } = true;


        public int CityId { get; set; }
        public City City { get; set; } = null!;


        public ICollection<Branch> Branches { get; set; } = new List<Branch>();
        public object AddressLine { get; set; }
    }
}
