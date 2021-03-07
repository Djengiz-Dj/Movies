using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IPublisherServices
    {
        void AddPublisher(Publisher publisher);
        void EditPublisher(Publisher publisher);
        void DeletePublisher(int publisherId);

        Publisher GetPublisherById(int publisherId);
        IEnumerable<Publisher> GetAllPublisher();
    }
}
