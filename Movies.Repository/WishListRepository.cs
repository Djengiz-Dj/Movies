using Movies.Data;
using Movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository
{
    public class WishListRepository : IWishListRepository
    {
        private readonly DataContext _context;

        public WishListRepository(DataContext context)
        {
            _context = context;
        }
    }
}
