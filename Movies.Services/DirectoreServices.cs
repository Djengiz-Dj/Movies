﻿using Movies.Entities;
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

        public void AddDirectore(Directore directore)
        {
            _directoreRepository.AddDirectore(directore);
        }

        public void DeleteDirectore(int directoreId)
        {
            _directoreRepository.DeletDirectore(directoreId);
        }

        public void EditDirectore(Directore directore)
        {
            _directoreRepository.EditDirectore(directore);
        }

        public IEnumerable<Directore> GetAllDirectores()
        {
            var result = _directoreRepository.GetAllDirectores();
            return result;
        }

        public Directore GetDirectoreById(int directoreId)
        {
            var result = _directoreRepository.GetDirectoreById(directoreId);
            return result;
        }
    }
}
