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
        

        public ShoppingCartServices(IShoppingCartRepository shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }
    }
}
