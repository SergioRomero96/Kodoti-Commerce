using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<productInStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductInStockId);

            //Products by default(en el momento que se genere la migracion)
            var products = new List<productInStock>();
            var random = new Random();
            for (var i = 1; i <= 100; i++)
            {
                products.Add(new productInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 100)
                });
            }

            entityBuilder.HasData(products);
        }
    }
}
