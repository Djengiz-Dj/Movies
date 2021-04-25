using Microsoft.AspNetCore.Mvc;
using Movies.Entities;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public IActionResult Index()
        {
            var allCategories = _categoryServices.GetAllCategories();
            return View(allCategories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryServices.Add(category);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _categoryServices.GetCategoryById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _categoryServices.Edit(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = _categoryServices.GetCategoryById(id);
            return View(category);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _categoryServices.GetCategoryById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            _categoryServices.Delete(category.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
