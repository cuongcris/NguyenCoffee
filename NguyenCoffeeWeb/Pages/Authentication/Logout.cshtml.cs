using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NguyenCoffeeWeb.Pages.Authentication
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.Session.Remove("Account");
            Response.Cookies.Delete("EmailInCookie");
            Response.Cookies.Delete("PassInCookie");

            return RedirectToPage("/Index");
        }
    }
}
