using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAuthenticationAuthorization.Models;

namespace TaskAuthenticationAuthorization.Controllers
{
    public class DiscountController : Controller
    {
        private readonly UserContext db;
        private readonly ShoppingContext shopping;
        public DiscountController(UserContext context, ShoppingContext shoppingContext)
        {
            db = context;
            shopping = shoppingContext;
        }
        [Authorize(Policy = "OnlyForVIP")]
        public IActionResult Index(string email)
        {
            int ID = db.Users.FirstOrDefault(x => x.Email == email).Id;
            return View(shopping.Customers.FirstOrDefault(x => x.ID == ID));
        }
    }
}
