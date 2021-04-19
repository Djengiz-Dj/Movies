using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IDirectoreServices
    {
        void Add(Directore directore);
        void Edit(Directore directore);
        void Delete(int directoreId);

        Directore GetDirectoreById(int directoreId);

        IEnumerable<Directore> GetAllDirectores();

    }
}
