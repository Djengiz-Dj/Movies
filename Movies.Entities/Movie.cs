using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string DirectorName { get; set; }
        public int DirectorId { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        public Directore Directore { get; set; }
        public DateTime YearOfReleise { get; set; }
        public int Duration { get; set; }

        [StringLength(150)]
        public string ProductionHouse { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }

        [StringLength(100)]
        public string ScreenPlay { get; set; }

        [StringLength(150)]
        public string PublisherName { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int UserId { get; set; }

        [StringLength(100)]
        public string Genre { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int DateOfRelease { get; set; }

        public double Price { get; set; }

        [StringLength(100)]
        public string MovieType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(300)]
        public string Starring { get; set; }

        [StringLength(50)]
        public string Audio { get; set; }

        [StringLength(50)]
        public string Subtitles { get; set; }
        public int Edition { get; set; }
        public int Copies { get; set; }
        public int Weight { get; set; }

        [StringLength(50)]
        public string Shipping { get; set; }
        public string PhotoURL { get; set; }
        public int SoldItems { get; set; }
        [StringLength(200)]
        public string FilmingLocations { get; set; }
        [StringLength(20)]
        public string AgeRestriction { get; set; }
        public double Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
