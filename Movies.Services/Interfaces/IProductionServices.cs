using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IProductionServices
    {
        void Add(Production production);
        void Edit(Production production);
        void Delete(int productionId);


        Production GetProductionById(int id);
        IEnumerable<Production> GetAllProduction();
    }
}
