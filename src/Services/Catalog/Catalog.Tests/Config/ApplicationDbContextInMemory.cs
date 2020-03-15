using Catalog.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Tests.Config
{
    public static class ApplicationDbContextInMemory
    {
        public static ApplicationDBContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDBContext>()
                .UseInMemoryDatabase(databaseName: $"Catalog.Db")
                .Options;

            return new ApplicationDBContext(options);
        }
    }
}
