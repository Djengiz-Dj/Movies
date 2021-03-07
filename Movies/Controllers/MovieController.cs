using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieServices _movieServices;

        public MovieController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            List<SelectListItem> Genre = new List<SelectListItem>()
            {
                new SelectListItem(){Text="Action", Value="1"},
                new SelectListItem(){Text="Adventure", Value="2"},
                new SelectListItem(){Text="Animation", Value="3"},
                new SelectListItem(){Text="Comedy", Value="4"},
                new SelectListItem(){Text="Crime", Value="5"},
                new SelectListItem(){Text="Crime and Mystery", Value="6"},
                new SelectListItem(){Text="Fantasy", Value="7"},
                new SelectListItem(){Text="Historical", Value="8"},
                new SelectListItem(){Text="Historical Fiction", Value="9"},
                new SelectListItem(){Text="Horror", Value="10"},
                new SelectListItem(){Text="Musical", Value="11"},
                new SelectListItem(){Text="Mystery", Value="12"},
                new SelectListItem(){Text="Romance", Value="13"},
                new SelectListItem(){Text="Satire", Value="14"},
                new SelectListItem(){Text="Science Fiction", Value="15"},
                new SelectListItem(){Text="Speculative", Value="16"},
                new SelectListItem(){Text="Thriller", Value="17"},
                new SelectListItem(){Text="Western", Value="18"},
                new SelectListItem(){Text=" ", Value="19"},
            };
            ViewBag.Genre = Genre;  
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
