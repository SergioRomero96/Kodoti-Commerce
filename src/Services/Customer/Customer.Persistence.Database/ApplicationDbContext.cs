﻿using Customer.Domain;
using Customer.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Database schema
            modelBuilder.HasDefaultSchema("Customer");

            // Model Constraints
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ClientConfiguration(modelBuilder.Entity<Client>());
        }
    }
}
