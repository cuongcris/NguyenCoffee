﻿using System;
using System.Collections.Generic;

namespace MoodKafe_Client_Test.Models
{
    public partial class Account
    {
        public Account()
        {
            OrderInTables = new HashSet<OrderInTable>();
            OrdersOnlines = new HashSet<OrdersOnline>();
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public short? Type { get; set; }

        public virtual ICollection<OrderInTable> OrderInTables { get; set; }
        public virtual ICollection<OrdersOnline> OrdersOnlines { get; set; }
    }
}
