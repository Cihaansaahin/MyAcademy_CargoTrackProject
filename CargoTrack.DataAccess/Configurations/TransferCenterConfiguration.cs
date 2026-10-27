using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class TransferCenterConfiguration : IEntityTypeConfiguration<TransferCenter>
    {
        public void Configure(EntityTypeBuilder<TransferCenter> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Code).HasMaxLength(20);
            builder.Property(x => x.AddressLine).HasMaxLength(250);

            builder.HasIndex(x => x.Code)
                .IsUnique()
                .HasFilter("[IsDeleted] = 0");
        }
    }
}
