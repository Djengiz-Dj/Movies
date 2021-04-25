using Movies.Entities;
using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class ActorServices : IActorServices
    {
        private readonly IActorRepository _actorRepository;

        public ActorServices(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public void Add(Actor actor)
        {
            _actorRepository.Add(actor);
        }

        public void Delete(int actorId)
        {
            _actorRepository.Delete(actorId);
        }

        public void Edit(Actor actor)
        {
            _actorRepository.Edit(actor);
        }

        public Actor GetActorById(int id)
        {
            var result = _actorRepository.GetActorById(id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _actorRepository.GetAllActors();
            return result;
        }
    }
}

