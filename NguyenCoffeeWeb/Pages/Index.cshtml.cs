﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenCoffeeWeb.Models;
using System.Text.Json;

namespace NguyenCoffeeWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly postgresContext _dbContext;

        public IndexModel(ILogger<IndexModel> logger, postgresContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task OnGetAsync()
        {
            bool cookieExists = Request.Cookies.ContainsKey("EmailInCookie");
            if (cookieExists)
            {
                string emailInCookie = Request.Cookies["EmailInCookie"];
                Account acc = await _dbContext.Accounts.SingleOrDefaultAsync(a => a.Email == emailInCookie);
                if (acc != null)
                {
                    HttpContext.Session.SetString("Account", JsonSerializer.Serialize(acc));
                    HttpContext.Session.SetString("Type", acc.Type.ToString());
                }
            }
        }
    }
}