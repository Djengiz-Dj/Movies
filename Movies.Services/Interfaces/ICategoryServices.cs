using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface ICategoryServices
    {
        void Add(Category category);
        void Edit(Category category);
        void Delete(int categoryId);

        Category GetCategoryById(int id);

        IEnumerable<Category> GetAllCategories();
    }
}
