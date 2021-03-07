using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IDirectoreServices
    {
        void AddDirectore(Directore directore);
        void EditDirectore(Directore directore);
        void DeleteDirectore(int directoreId);

        Directore GetDirectoreById(int directoreId);

        IEnumerable<Directore> GetAllDirectores();

    }
}
