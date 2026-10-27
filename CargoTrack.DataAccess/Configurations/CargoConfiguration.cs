using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            // Metin alanları
            builder.Property(x => x.TrackingNumber).HasMaxLength(20);
            builder.Property(x => x.Content).HasMaxLength(200);
            builder.Property(x => x.DeliveryCode).HasMaxLength(6);

            // Ölçüler
            builder.Property(x => x.Weight).HasPrecision(10, 2);
            builder.Property(x => x.Width).HasPrecision(10, 2);
            builder.Property(x => x.Length).HasPrecision(10, 2);
            builder.Property(x => x.Height).HasPrecision(10, 2);
            builder.Property(x => x.Desi).HasPrecision(10, 2);
            builder.Property(x => x.ChargeableWeight).HasPrecision(10, 2);

            // Para
            builder.Property(x => x.Price).HasPrecision(18, 2);

            // Index'ler
            builder.HasIndex(x => x.TrackingNumber).IsUnique();
            builder.HasIndex(x => x.Status);
        }
    }
}
