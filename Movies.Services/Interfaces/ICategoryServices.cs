using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface ICategoryServices
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int categoryId);

        Category GetCategoryById(int categoryId);

        IEnumerable<Category> GetAllCategories();
    }
}
