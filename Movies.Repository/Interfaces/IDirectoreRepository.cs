using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IDirectoreRepository
    {
        void Add(Directore directore);
        void Edit(Directore directore);
        void Delete(int directoreId);

        IEnumerable<Directore> GetAllDirectores();

        Directore GetDirectoreById(int id);

    }
}
