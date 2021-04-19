using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class ShoppingCartServices : IShoppingCartServices
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMovieRepository _movieRepository;

        public ShoppingCartServices(
            IShoppingCartRepository shoppingCartRepository,
            IMovieRepository movieRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _movieRepository = movieRepository;
        }
    }
}
