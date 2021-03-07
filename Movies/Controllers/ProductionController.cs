using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class ProductionController : Controller
    {
        private readonly IProductionServices _productionServices;

        public ProductionController(IProductionServices productionServices)
        {
            _productionServices = productionServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
