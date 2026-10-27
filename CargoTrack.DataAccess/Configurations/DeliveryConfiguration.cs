using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.Property(x => x.ReceivedByName).HasMaxLength(100);
            builder.Property(x => x.ReceiverRelation).HasMaxLength(50);
            builder.Property(x => x.Note).HasMaxLength(500);

            builder.HasOne(x => x.Cargo)
                .WithOne(c => c.Delivery)
                .HasForeignKey<Delivery>(x => x.CargoId);
        }
    }
}
