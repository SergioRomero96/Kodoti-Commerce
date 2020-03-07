using Catalog.Persistence.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Service.EventHandlers.Commands
{
    //Comando no retorna nada cuando se ejecute porque el metodo va a ser un void
    public class ProductCreateCommand: INotification
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
