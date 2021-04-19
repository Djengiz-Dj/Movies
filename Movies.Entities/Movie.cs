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

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        [Display(Name ="Director")]
        public string DirectorName { get; set; }
        [Display(Name ="Director")]
        public int DirectorId { get; set; }

        [StringLength(30)]
        public string Country { get; set; }
        public Directore Directore { get; set; }
        [Display(Name = "Year Of Releise")]
        public DateTime YearOfReleise { get; set; }
        public int Duration { get; set; }

        [StringLength(30)]
        [Display(Name = "Production")]
        public string ProductionHouse { get; set; }
        [Display(Name = "Production")]
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        [StringLength(30)]
        public string Actor { get; set; }

        [StringLength(30)]
        [Display(Name = "Screen Play")]
        public string ScreenPlay { get; set; }

        public int UserId { get; set; }

        [StringLength(30)]
        public string Genre { get; set; }

        [StringLength(30)]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display(Name = "Date Of Release")]
        public int DateOfRelease { get; set; }

        public double Price { get; set; }

        [StringLength(30)]
        [Display(Name = "Movie Type")]
        public string MovieType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(100)]
        public string Starring { get; set; }

        [StringLength(30)]
        public string Audio { get; set; }

        [StringLength(30)]
        public string Subtitles { get; set; }
      
        public int Copies { get; set; }
        public int Weight { get; set; }

        [StringLength(30)]
        public string Shipping { get; set; }
        public string PhotoURL { get; set; }
        [Display(Name = "Sold Items")]
        public int SoldItems { get; set; }
        [StringLength(100)]
        [Display(Name = "Filming Locations")]
        public string FilmingLocations { get; set; }
        [StringLength(20)]
        [Display(Name = "Age Restriction")]
        public string AgeRestriction { get; set; }
        public double Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
