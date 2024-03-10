using System;
using System.Collections.Generic;

namespace MoodKafe_Client_Test.Models
{
    public partial class OrderInTable
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid? UserId { get; set; }
        public short? TableNumber { get; set; }
        public string? ImageAi { get; set; }

        public virtual Account? User { get; set; }
    }
}
