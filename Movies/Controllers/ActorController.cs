using Microsoft.AspNetCore.Mvc;
using Movies.Entities;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorServices _actorServices;

        public ActorController(IActorServices actorServices)
        {
            _actorServices = actorServices;
        }

        public IActionResult Index()
        {
            var allActors = _actorServices.GetAllActors();
            return View(allActors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            _actorServices.Add(actor);
            return RedirectToAction("Index");
        }
      
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var actor = _actorServices.GetActorById(id);
            return View(actor);
        }
        [HttpPost]
        public IActionResult Edit(Actor actor)
        {
            _actorServices.Edit(actor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var actor = _actorServices.GetActorById(id);
            return View(actor);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = _actorServices.GetActorById(id);
            return View(actor);
        }
        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            _actorServices.Delete(actor.Id);
            return RedirectToAction(nameof(Index));
        }
       
    }
}

