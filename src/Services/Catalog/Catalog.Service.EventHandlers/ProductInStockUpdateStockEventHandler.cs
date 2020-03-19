using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.EventHandlers.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Catalog.Common.Enums;

namespace Catalog.Service.EventHandlers
{
    public class ProductInStockUpdateStockEventHandler : INotificationHandler<ProductInStockUpdateStockCommand>
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<ProductInStockUpdateStockEventHandler> _logger;

        public ProductInStockUpdateStockEventHandler(
            ApplicationDBContext context,
            ILogger<ProductInStockUpdateStockEventHandler> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task Handle(ProductInStockUpdateStockCommand notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- ProductInStockUpdateStockCommand started");
            //selecciona los productos
            var products = notification.Items.Select(x => x.ProductId);
            
            var stocks = await _context.Stocks.Where(x => products.Contains(x.ProductId)).ToListAsync();

            _logger.LogInformation("--- Retrieve products from database");

            //Iteracion de los productos que se estan recibiendo
            foreach(var item in notification.Items)
            {
                var entry = stocks.SingleOrDefault(x => x.ProductId == item.ProductId);
                if(item.Action == ProductInStockAction.Substract)
                {
                    if(entry == null || item.Stock > entry.Stock)
                    {
                        _logger.LogError($"--- Product {entry.ProductId} - doesn't have enough stock");
                        throw new ProductInStockUpdateStockCommandException($"Product {entry.ProductId} - doesn't have enough stock");
                    }

                    _logger.LogInformation($"--- Product {entry.ProductId} - its stock was substracted and its new stock is {entry.Stock}");
                    entry.Stock -= item.Stock;
                }
                else
                {
                    if(entry == null)
                    {
                        entry = new ProductInStock
                        {
                            ProductId = item.ProductId
                        };
                        await _context.AddAsync(entry);

                        _logger.LogInformation($"--- New stock record was created for {entry.ProductId} because didn't exists before");
                    }
                    entry.Stock += item.Stock;
                    _logger.LogInformation($"--- Product {entry.ProductId} - its stock was increased and its new stock is {entry.Stock}");
                }
            }

            await _context.SaveChangesAsync();

            _logger.LogInformation("--- ProductInStockUpdateStockCommand ended");
        }
    }
}
