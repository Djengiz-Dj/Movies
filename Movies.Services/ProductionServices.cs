using Movies.Entities;
using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class ProductionServices : IProductionServices
    {
        private readonly IProductionRepository _productionRepository;

        public ProductionServices(IProductionRepository productionRepository)
        {
            _productionRepository = productionRepository;
        }

        public void Add(Production production)
        {
            _productionRepository.AddProduction(production);
        }

        public void Delete(int productionId)
        {
            _productionRepository.DeleteProduction(productionId);
        }

        public void Edit(Production production)
        {
            _productionRepository.EditProduction(production);
        }

        public IEnumerable<Production> GetAllProduction()
        {
            var result = _productionRepository.GetAllProductions();
            return result;
        }

        public Production GetProductionById(int id)
        {
            var result = _productionRepository.GetProductionById(id);
            return result;
        }
    }
}
