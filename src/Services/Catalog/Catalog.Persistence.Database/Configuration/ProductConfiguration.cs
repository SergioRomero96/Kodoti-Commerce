using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        //Nos permite personalizar el compartamiento de nuestro dominio producto
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            //configurar clave primaria
            entityBuilder.HasKey(x => x.ProductId);
            //configurar propiedad es requerido, y maximo 100 caracteres
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            //Products by default(en el momento que se genere la migracion)
            var products = new List<Product>();
            var random = new Random();
            for(var i = 1; i <= 100; i++)
            {
                products.Add(new Product { 
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100,1000),
                });
            }

            entityBuilder.HasData(products);
        }
    }
}
