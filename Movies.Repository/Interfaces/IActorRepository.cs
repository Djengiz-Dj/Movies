using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IActorRepository
    {
        void Add(Actor actor);
        void Edit(Actor actor);
        void Delete(int actorId);

        Actor GetActorById(int id);

        IEnumerable<Actor> GetAllActors();
    }
}
