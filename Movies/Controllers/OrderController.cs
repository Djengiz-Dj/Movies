using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderService;

        public OrderController(IOrderServices orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
