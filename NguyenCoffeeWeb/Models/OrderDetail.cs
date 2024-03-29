﻿using System;
using System.Collections.Generic;

namespace NguyenCoffeeWeb.Models
{
    public partial class OrderDetail
    {
        public Guid ProductId { get; set; }
        public float? UnitPrice { get; set; }
        public int? Quanlity { get; set; }
        public long? OrderInTableId { get; set; }
        public string OrderId { get; set; }

        public virtual OrdersOnline? Order { get; set; }
        public virtual OrderInTable? OrderInTable { get; set; }
        public virtual Product Product { get; set; }
    }
}
