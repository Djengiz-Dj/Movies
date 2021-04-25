using Movies.Data;
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

        public void Add(Directore directore)
        {
            _context.Directores.Add(directore);
            _context.SaveChanges();
        }

        public void Delete(int directoreId)
        {
            Directore directore = GetDirectoreById(directoreId);
            _context.Directores.Remove(directore);
            _context.SaveChanges();
        }

        public void Edit(Directore directore)
        {
            _context.Directores.Update(directore);
            _context.SaveChanges();
        }

        public IEnumerable<Directore> GetAllDirectores()
        {
            var result = _context.Directores.AsEnumerable();
            return result;
        }

        public Directore GetDirectoreById(int id)
        {
            var result = _context.Directores.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
