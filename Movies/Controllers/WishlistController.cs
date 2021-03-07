using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class WishlistController : Controller
    {
        private readonly IWishListServices _wishListServices;

        public WishlistController(IWishListServices wishListServices)
        {
            _wishListServices = wishListServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
