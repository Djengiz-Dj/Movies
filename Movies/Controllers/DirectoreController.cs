using Microsoft.AspNetCore.Mvc;
using Movies.Entities;
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
            var allDirectore = _directoreServices.GetAllDirectores();
            return View(allDirectore);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Directore directore)
        {
            _directoreServices.Add(directore);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var directore = _directoreServices.GetDirectoreById(id);
            return View(directore);
        }
        [HttpPost]
        public IActionResult Edit(Directore directore)
        {
            _directoreServices.Edit(directore);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var directore = _directoreServices.GetDirectoreById(id);
            return View(directore);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var directore = _directoreServices.GetDirectoreById(id);
            return View(directore);
        }
        [HttpPost]
        public IActionResult Delete(Directore directore)
        {
            _directoreServices.Delete(directore.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
