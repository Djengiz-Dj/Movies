using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IProductionRepository
    {
        void AddProduction(Production production);
        void EditProduction(Production production);
        void DeleteProduction(int productionId);

        Production GetProductionById(int productionId);

        IEnumerable<Production> GetAllProductions();
    }
}
