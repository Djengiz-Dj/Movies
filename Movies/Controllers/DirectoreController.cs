using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class DirectoreController : Controller
    {
        private readonly IDirectoreServices _directoreServices;

        public DirectoreController(IDirectoreServices directoreServices)
        {
            _directoreServices = directoreServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
