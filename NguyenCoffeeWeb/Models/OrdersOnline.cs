using System;
using System.Collections.Generic;

namespace NguyenCoffeeWeb.Models
{
    public partial class OrdersOnline
    {
        public OrdersOnline()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? UserId { get; set; }
        public DateOnly? PackagingDate { get; set; }
        public DateOnly? ShippedDate { get; set; }
        public string? Status { get; set; }

        public virtual Account? User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
