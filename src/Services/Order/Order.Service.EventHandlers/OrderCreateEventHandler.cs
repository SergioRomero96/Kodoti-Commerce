using MediatR;
using Microsoft.Extensions.Logging;
using Order.Domain;
using Order.Persistence.Database;
using Order.Service.EventHandlers.Commands;
using Order.Service.Proxies.Catalog;
using Order.Service.Proxies.Catalog.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Order.Common.Enums;

namespace Order.Service.EventHandlers
{
    public class OrderCreateEventHandler : INotificationHandler<OrderCreateCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<OrderCreateEventHandler> _logger;
        private readonly ICatalogProxy _catalogProxy;

        public OrderCreateEventHandler(
            ApplicationDbContext context,
            ILogger<OrderCreateEventHandler> logger,
            ICatalogProxy catalogProxy)
        {
            _context = context;
            _logger = logger;
            _catalogProxy = catalogProxy;
        }

        public async Task Handle(OrderCreateCommand notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("--- New order creation started");
            var entry = new Domain.Order();

            // Si falla, hara un rollback a toda la transaccion y no va a generar la orden
            // El proceso se conoce como orquestación (Darle toda la responsabilidad a un microservicio)
            using(var trx = await _context.Database.BeginTransactionAsync())
            {
                // 01. Prepare detail
                _logger.LogInformation("--- Preparing detail");
                PrepareDetail(entry, notification);

                // 02. Prepare header
                _logger.LogInformation("--- Preparing header");
                PrepareHeader(entry, notification);

                // 03. Create order
                _logger.LogInformation("--- Creating order");
                await _context.AddAsync(entry);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"--- Order {entry.OrderId} was created");

                // 04. Update Stocks
                try
                {
                    await _catalogProxy.UpdateStockAsync(new ProductInStockUpdateStockCommand
                    {
                        Items = notification.Items.Select(x => new ProductInStockUpdateItem
                        {
                            Action = ProductInStockAction.Substract,
                            ProductId = x.ProductId,
                            Stock = x.Quantity
                        })
                    });
                    _logger.LogInformation("--- Updating stock");
                }
                catch (Exception e)
                {
                    _logger.LogError("No se puedo crear la orden debido a la falta de stock");
                }

                // Logica para actualizar el stock
                await trx.CommitAsync();

            }
        }

        private void PrepareDetail(Domain.Order order, OrderCreateCommand command)
        {
            order.Items = command.Items.Select(x => new OrderDetail
            {
                ProductId = x.ProductId,
                Quantity = x.Quantity,
                UnitPrice = x.Price,
                Total = x.Price * x.Quantity
            }).ToList();
        }

        private void PrepareHeader(Domain.Order order, OrderCreateCommand command)
        {
            order.Status = OrderStatus.Pending;
            order.PaymentType = command.PaymentType;
            order.ClientId = command.ClientId;
            order.CreatedAt = DateTime.UtcNow;

            // Sum
            order.Total = order.Items.Sum(x => x.Total);
        }
    }
}
