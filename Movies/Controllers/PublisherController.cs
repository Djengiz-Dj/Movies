using Microsoft.AspNetCore.Mvc;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherServices _publisherServices;

        public PublisherController(IPublisherServices publisherServices)
        {
            _publisherServices = publisherServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
