using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IActorRepository
    {
        void AddActor(Actor actor);
        void EditActor(Actor actor);
        void DeleteActor(int actorId);

        Actor GetActorById(int actorId);

        IEnumerable<Actor> GetAllActors();
    }
}
