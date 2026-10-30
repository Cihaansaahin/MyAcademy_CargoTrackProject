
using CargoTrack.Entity.Common;
using CargoTrack.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CargoTrack.DataAccess.Context
{
    public class CargoTrackDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public CargoTrackDbContext(DbContextOptions<CargoTrackDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<TransferCenter> TransferCenters { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<CargoMovement> CargoMovements { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryException> DeliveryExceptions { get; set; }
        public DbSet<CargoPrice> CargoPrices { get; set; }
        public DbSet<ExtraServiceFee> ExtraServiceFees { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(CargoTrackDbContext).Assembly);

            var ourForeignKeys = builder.Model.GetEntityTypes()
                .Where(e => e.ClrType.Assembly == typeof(BaseEntity).Assembly)
                .SelectMany(e => e.GetForeignKeys());

            foreach (var foreignKey in ourForeignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Soft delete te :  BaseEntity'den türeyen her tabloya "IsDeleted = 0" filtresi
            var softDeletableTypes = builder.Model.GetEntityTypes()
                .Where(e => typeof(BaseEntity).IsAssignableFrom(e.ClrType));

            foreach (var entityType in softDeletableTypes)
            {
                var parameter = Expression.Parameter(entityType.ClrType, "x");
                var isDeleted = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
                var notDeleted = Expression.Not(isDeleted);
                var lambda = Expression.Lambda(notDeleted, parameter);

                builder.Entity(entityType.ClrType).HasQueryFilter(lambda);
            }
        }
    }
}
