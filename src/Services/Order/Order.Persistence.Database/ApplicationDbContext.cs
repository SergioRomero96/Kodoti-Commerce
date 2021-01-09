using Microsoft.EntityFrameworkCore;
using Order.Domain;
using Order.Persistence.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Domain.Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Order");

            // Model Constraints
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new OrderConfiguration(modelBuilder.Entity<Domain.Order>());
            new OrderDetailConfiguration(modelBuilder.Entity<OrderDetail>());
        }
    }
}
