using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Enums
{
    public enum DistanceZone
    {
        SameCity = 1,        // Aynı il
        SameRegion = 2,      // Aynı bölge, farklı il
        DifferentRegion = 3  // Farklı bölge
    }
}
