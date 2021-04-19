using Microsoft.AspNetCore.Mvc;
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
        //[HttpPost]
        //public JsonResult CreateActorAJAX(Actor actor)
        //{

        //}
    }
}

