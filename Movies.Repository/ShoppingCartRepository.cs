using Movies.Data;
using Movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly DataContext _context;

        public ShoppingCartRepository(DataContext context)
        {
            _context = context;
        }
    }
}
