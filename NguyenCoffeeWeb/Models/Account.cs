using System.ComponentModel.DataAnnotations;

namespace NguyenCoffeeWeb.Models
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
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Type is required")]
        [Range(0,1, ErrorMessage = "Type must be either 0 or 1")]
        public short? Type { get; set; }

        public virtual ICollection<OrderInTable> OrderInTables { get; set; }
        public virtual ICollection<OrdersOnline> OrdersOnlines { get; set; }
    }
}
