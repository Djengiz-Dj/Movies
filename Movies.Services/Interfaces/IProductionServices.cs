using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IProductionServices
    {
        void AddProduction(Production production);
        void EditProduction(Production production);
        void DeleteProduction(int productionId);


        Production GetProductionById(int productionId);
        IEnumerable<Production> GetAllProduction();
    }
}
