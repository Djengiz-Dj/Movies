using Microsoft.AspNetCore.Mvc;
using Movies.Entities;
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
            var allProduction = _productionServices.GetAllProduction();
            return View(allProduction);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Production production)
        {
            _productionServices.Add(production);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var production = _productionServices.GetProductionById(id);
            return View(production);
        }
        [HttpPost]
        public IActionResult Edit(Production production)
        {
            _productionServices.Edit(production);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var production = _productionServices.GetProductionById(id);
            return View(production);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var production = _productionServices.GetProductionById(id);
            return View(production);
        }
        [HttpPost]
        public IActionResult Delete(Production production)
        {
            _productionServices.Delete(production.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
