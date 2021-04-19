using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieCountry { get; set; }
        public string MovieLanguage { get; set; }
        public string MovieProduction { get; set; }
        public string MovieCategory { get; set; }
        public string MovieType { get; set; }
        public string ShortMovieDescription{ get; set; }
        public string MovieDuration { get; set; }
        public string MovieSubtitles { get; set; }
        public string MovieStarring { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
