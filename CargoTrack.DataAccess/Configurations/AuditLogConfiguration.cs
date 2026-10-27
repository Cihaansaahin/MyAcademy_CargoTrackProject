using CargoTrack.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.DataAccess.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            builder.Property(x => x.UserName).HasMaxLength(256);
            builder.Property(x => x.EntityName).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasIndex(x => new { x.EntityName, x.EntityId });
        }
    }
}
