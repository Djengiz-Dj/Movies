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
            _actorRepository.AddActor(actor);
        }

        public void Delete(int actorId)
        {
            _actorRepository.DeleteActor(actorId);
        }

        public void Edit(Actor actor)
        {
            _actorRepository.EditActor(actor);
        }

        public Actor GetActorById(int actorId)
        {
            var result = _actorRepository.GetActorById(actorId);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _actorRepository.GetAllActors();
            return result;
        }
    }
}

