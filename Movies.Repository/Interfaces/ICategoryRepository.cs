using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Edit(Category category);
        void Delete(int categoryId);

        Category GetCategoryById(int id);

        IEnumerable<Category> GetAllCategories();
    }
}
