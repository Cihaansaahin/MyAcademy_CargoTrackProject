using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class CargoPriceConfiguration : IEntityTypeConfiguration<CargoPrice>
    {
        public void Configure(EntityTypeBuilder<CargoPrice> builder)
        {
            builder.Property(x => x.MinWeight).HasPrecision(10, 2);
            builder.Property(x => x.MaxWeight).HasPrecision(10, 2);
            builder.Property(x => x.Price).HasPrecision(18, 2);

            builder.HasIndex(x => new { x.Zone, x.DeliveryType });
        }
    }
}
