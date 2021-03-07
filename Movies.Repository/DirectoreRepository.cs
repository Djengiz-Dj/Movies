﻿using Movies.Data;
using Movies.Entities;
using Movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Repository
{
    public class DirectoreRepository : IDirectoreRepository
    {
        private readonly DataContext _context;

        public DirectoreRepository(DataContext context)
        {
            _context = context;
        }

        public void AddDirectore(Directore directore)
        {
            _context.Directores.Add(directore);
            _context.SaveChanges();
        }

        public void DeletDirectore(int directoreId)
        {
            Directore directore = GetDirectoreById(directoreId);
            _context.Directores.Remove(directore);
            _context.SaveChanges();
        }

        public void EditDirectore(Directore directore)
        {
            _context.Directores.Update(directore);
            _context.SaveChanges();
        }

        public IEnumerable<Directore> GetAllDirectores()
        {
            var result = _context.Directores.AsEnumerable();
            return result;
        }

        public Directore GetDirectoreById(int directoreId)
        {
            var result = _context.Directores.FirstOrDefault(x => x.Id == directoreId);
            return result;
        }
    }
}