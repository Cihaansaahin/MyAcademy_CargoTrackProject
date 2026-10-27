using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class DeliveryExceptionConfiguration : IEntityTypeConfiguration<DeliveryException>
    {
        public void Configure(EntityTypeBuilder<DeliveryException> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(500);
        }
    }
}
