﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Service.Queries.DTOs
{
    public class productInStockDto
    {
        public int ProductInStockId { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
    }
}
