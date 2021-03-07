using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class WishListServices : IWishListServices
    {
        private readonly IWishListRepository  _whishListRepository;

        public WishListServices(IWishListRepository wishListRepository)
        {
            _whishListRepository = wishListRepository;
        }
    }
}
