using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IDirectoreRepository
    {
        void AddDirectore(Directore directore);
        void EditDirectore(Directore directore);
        void DeletDirectore(int directoreId);

        IEnumerable<Directore> GetAllDirectores();

        Directore GetDirectoreById(int id);

    }
}
