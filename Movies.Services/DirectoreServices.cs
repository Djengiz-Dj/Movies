using Movies.Entities;
using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class DirectoreServices : IDirectoreServices
    {
        private readonly IDirectoreRepository _directoreRepository;

        public DirectoreServices(IDirectoreRepository directoreRepository)
        {
            _directoreRepository = directoreRepository;
        }

        public void Add(Directore directore)
        {
            _directoreRepository.Add(directore);
        }

        public void Delete(int directoreId)
        {
            _directoreRepository.Delete(directoreId);
        }

        public void Edit(Directore directore)
        {
            _directoreRepository.Edit(directore);
        }

        public IEnumerable<Directore> GetAllDirectores()
        {
            var result = _directoreRepository.GetAllDirectores();
            return result;
        }

        public Directore GetDirectoreById(int id)
        {
            var result = _directoreRepository.GetDirectoreById(id);
            return result;
        }
    }
}
