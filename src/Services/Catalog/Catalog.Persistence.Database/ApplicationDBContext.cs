using Catalog.Domain;
using Catalog.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(
            //Inicializa el constructor de la clase que esta heredando
            DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Database schema: usa un esquema personalizado
            modelBuilder.HasDefaultSchema("Catalog");

            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ProductConfiguration(modelBuilder.Entity<Product>());
            new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }
    }
}
