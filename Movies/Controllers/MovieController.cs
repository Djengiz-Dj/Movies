using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Entities;
using Movies.Models;
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
        private readonly IConvertingService _convertingService;
        private readonly IActorServices _actorServices;
        private readonly ICategoryServices _categoryServices;
        private readonly IDirectoreServices _directoreServices;
        private readonly IProductionServices _productionServices;

       

        public MovieController(IMovieServices movieServices, 
            IConvertingService convertingService, 
            IActorServices actorServices, 
            ICategoryServices categoryServices, 
            IDirectoreServices directoreServices, 
            IProductionServices productionServices)
        {
            _movieServices = movieServices;
            _convertingService = convertingService;
            _actorServices = actorServices;
            _categoryServices = categoryServices;
            _directoreServices = directoreServices;
            _productionServices = productionServices;
        }

        public IActionResult Index()
        {
            var movies = _movieServices.GetAllMovies();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var actors = _actorServices.GetAllActors();
            var categories = _categoryServices.GetAllCategories();
            var directores = _directoreServices.GetAllDirectores();
            var productions = _productionServices.GetAllProduction();

            var dropdowns = _movieServices.FillDropdowns(actors, categories, directores, productions);

            ViewBag.ActorList = dropdowns.Item1;
            ViewBag.CategoryList = dropdowns.Item2;
            ViewBag.DirectorList = dropdowns.Item3;
            ViewBag.ProductionList = dropdowns.Item4;


            //List<SelectListItem> Category = new List<SelectListItem>()
            //{
            //    new SelectListItem(){Text="Action", Value="1"},
            //    new SelectListItem(){Text="Adventure", Value="2"},
            //    new SelectListItem(){Text="Animation", Value="3"},
            //    new SelectListItem(){Text="Comedy", Value="4"},
            //    new SelectListItem(){Text="Crime", Value="5"},
            //    new SelectListItem(){Text="Crime and Mystery", Value="6"},
            //    new SelectListItem(){Text="Fantasy", Value="7"},
            //    new SelectListItem(){Text="Historical", Value="8"},
            //    new SelectListItem(){Text="Historical Fiction", Value="9"},
            //    new SelectListItem(){Text="Horror", Value="10"},
            //    new SelectListItem(){Text="Musical", Value="11"},
            //    new SelectListItem(){Text="Mystery", Value="12"},
            //    new SelectListItem(){Text="Romance", Value="13"},
            //    new SelectListItem(){Text="Satire", Value="14"},
            //    new SelectListItem(){Text="Science Fiction", Value="15"},
            //    new SelectListItem(){Text="Speculative", Value="16"},
            //    new SelectListItem(){Text="Thriller", Value="17"},
            //    new SelectListItem(){Text="Western", Value="18"},
            //    new SelectListItem(){Text=" ", Value="19"},
            //};
            //ViewBag.Category = Category;  
            return View();
        }
        [HttpPost]
        public IActionResult Create(MovieViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    _movieServices.Add(movie);
            //}
            //return RedirectToAction(nameof(Index));
            var movie = new Movie();
            movie.Title = model.Title;
            movie.DirectorName = model.DirectorName;
            movie.DirectorId = model.DirectorId;
            movie.Country = model.Country;
            movie.YearOfReleise = model.YearOfReleise;
            movie.Duration = model.Duration;
            movie.ProductionHouse = model.ProductionHouse;
            movie.ProductionId = model.ProductionId;
            movie.ScreenPlay = model.ScreenPlay;
            movie.Genre = model.Genre;
            movie.CategoryName = model.CategoryName;
            movie.DateOfRelease = model.DateOfReleise;
            movie.Price = model.Price;
            movie.MovieType = model.MovieType;
            movie.Description = model.Description;
            movie.Language = model.Language;
            movie.Starring = model.Starring;
            movie.Audio = model.Audio;
            movie.Subtitles = model.Subtitles;
            movie.Copies = model.Copies;
            movie.Weight = model.Weight;
            movie.Shipping = model.Shipping;
            movie.PhotoURL = model.PhotoURL;
            movie.SoldItems = model.SoldItems;
            movie.FilmingLocations = model.FilmingLocations;
            movie.AgeRestriction = model.AgeRestriction;
            movie.Rating = model.Rating;
            movie.DateAdded = DateTime.Now;

            _movieServices.Add(movie);
            return RedirectToAction("index");

        }

    
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var movie = _movieServices.GetMovieById(id);

            var actores = _actorServices.GetAllActors();
            var categories = _categoryServices.GetAllCategories();
            var directores = _directoreServices.GetAllDirectores();
            var productions = _productionServices.GetAllProduction();

            var dropdowns = _movieServices.FillDropdowns(actores, categories, directores, productions);

            ViewBag.ActorList = dropdowns.Item1;
            ViewBag.CategoryList = dropdowns.Item2;
            ViewBag.DirectorList = dropdowns.Item3;
            ViewBag.ProductionList = dropdowns.Item4;
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(int id, Movie movie)
        {
            _movieServices.Edit(movie);
            //_movieServices.EditMovie(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieServices.GetMovieById(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult DeleteConfirmation(int id)
        {
            //opcija 1 za delete
            var movie = _movieServices.GetMovieById(id);
            _movieServices.Delete(movie.Id);
            // opcija 2 za delete
            // _movieServices.DeleteMovie(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var movie = _movieServices.GetMovieById(id);
            return View(movie);
        }
    }
}
