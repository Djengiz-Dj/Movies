using Movies.Data;
using Movies.Entities;
using Movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly DataContext _context;

        public PublisherRepository(DataContext context)
        {
            _context = context;
        }

        public void AddPublisher(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void DeletePublisher(int publisherId)
        {
            Publisher publisher = GetPublisherById(publisherId);
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
        }

        public void EditPublisher(Publisher publisher)
        {
            _context.Publishers.Update(publisher);
            _context.SaveChanges();
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            var result = _context.Publishers.AsEnumerable();
            return result;
        }

        public Publisher GetPublisherById(int publisherId)
        {
            var result = _context.Publishers.FirstOrDefault(x => x.Id == publisherId);
            return result;
        }
    }
}
