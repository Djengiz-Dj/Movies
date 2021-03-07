using Movies.Entities;
using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class PublisherServices : IPublisherServices
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherServices(IPublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public void AddPublisher(Publisher publisher)
        {
            _publisherRepository.AddPublisher(publisher);
        }

        public void DeletePublisher(int publisherId)
        {
            _publisherRepository.DeletePublisher(publisherId);
        }

        public void EditPublisher(Publisher publisher)
        {
            _publisherRepository.EditPublisher(publisher);
        }

        public IEnumerable<Publisher> GetAllPublisher()
        {
            var result = _publisherRepository.GetAllPublishers();
            return result;
        }

        public Publisher GetPublisherById(int publisherId)
        {
            var result = _publisherRepository.GetPublisherById(publisherId);
            return result;
        }
    }
}
