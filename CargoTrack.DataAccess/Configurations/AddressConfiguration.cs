using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.District).HasMaxLength(50);
            builder.Property(x => x.AddressLine).HasMaxLength(250);
            builder.Property(x => x.PostalCode).HasMaxLength(10);
        }
    } 

}
