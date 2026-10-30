using CargoTrack.DataAccess.Seed;
using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasIndex(x => x.PlateCode).IsUnique();

            builder.HasData(CitySeedData.Cities);
        }
    }
}
