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
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
        [RegularExpression(@"^(?=.*[A-Z]).+$", ErrorMessage = "Password must contain at least one uppercase letter")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Full Name is required")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Full name cannot contain numbers")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^(?:0|\+84)[3|5|7|8|9][0-9]{8}$", ErrorMessage = "Invalid phone number format")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        public short? Type { get; set; }

        public virtual ICollection<OrderInTable> OrderInTables { get; set; }
        public virtual ICollection<OrdersOnline> OrdersOnlines { get; set; }
    }
}
