using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class ExtraServiceFeeConfiguration : IEntityTypeConfiguration<ExtraServiceFee>
    {
        public void Configure(EntityTypeBuilder<ExtraServiceFee> builder)
        {
            builder.Property(x => x.Fee).HasPrecision(18, 2);

            builder.HasIndex(x => x.Service)
                .IsUnique()
                .HasFilter("[IsDeleted] = 0");
        }
    }
} 
