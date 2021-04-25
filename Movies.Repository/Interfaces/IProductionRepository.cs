using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IProductionRepository
    {
        void Add(Production production);
        void Edit(Production production);
        void Delete(int productionId);

        Production GetProductionById(int id);

        IEnumerable<Production> GetAllProductions();
    }
}
