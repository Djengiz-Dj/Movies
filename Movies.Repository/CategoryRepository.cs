using Movies.Data;
using Movies.Entities;
using Movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int categoryId)
        {
            Category category = GetCategoryById(categoryId);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void Edit(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var result = _context.Categories.AsEnumerable();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = _context.Categories.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
