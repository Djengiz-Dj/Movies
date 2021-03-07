using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartServices _shoppingCartServices;

        public ShoppingCartController(IShoppingCartServices shoppingCartServices)
        {
            _shoppingCartServices = shoppingCartServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
