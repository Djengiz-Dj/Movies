using Movies.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieViewModel
    {
        #region Movie Data

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        [Display(Name = "Director")]
        public string DirectorName { get; set; }
        [Display(Name ="Director")]
        public int DirectorId { get; set; }

        [StringLength(30)]
        public string Country { get; set; }
        public Directore Directore { get; set; }
        [Display(Name ="Year of Releise")]
        public DateTime YearOfReleise { get; set; }
        public int Duration { get; set; }

        [StringLength(30)]
        [Display (Name ="Production")]
        public string ProductionHouse { get; set; }
        [Display(Name ="Production")]
        public int ProductionId { get; set; }
        public Production Production { get; set; }

        [StringLength(30)]
        public string ScreenPlay { get; set; }
        [Display(Name ="User")]
        public int UserId { get; set; }

        [StringLength(30)]
        public string Genre { get; set; }

        [StringLength(30)]
        [Display(Name ="Category")]
        public string CategoryName { get; set; }
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display (Name ="Date of Releise")]
        public int DateOfReleise { get; set; }

        public double Price { get; set; }

        [StringLength(30)]
        [Display(Name ="Movie Type")]
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
        [Display(Name ="Photo")]
        public string PhotoURL { get; set; }
        [Display(Name ="Sold Items")]
        public int SoldItems { get; set; }
        [StringLength(100)]
        [Display (Name ="Filming Location")]
        public string FilmingLocations { get; set; }
        [StringLength(20)]
        [Display(Name ="Age Restriction")]
        public string AgeRestriction { get; set; }
        public double Rating { get; set; }
        [Display(Name ="Date Added")]
        public DateTime DateAdded { get; set; }
        #endregion

        #region Actor Data

        [StringLength(50)]
        public string ActoreNameDTO { get; set; }

        [StringLength(30)]
        public string ActorCountryDTO { get; set; }
        public DateTime ActorDateBirthDTO { get; set; }

        public int ActorMovieIdDTO { get; set; }
        #endregion

        #region  Category

        [StringLength(150)]
        public string CategoryNameDTO { get; set; }
        #endregion

        #region Directore
        [StringLength(30)]
        public string DirectorNameDTO { get; set; }

        [StringLength(30)]
        public string DirectorCountryDTO { get; set; }

        [StringLength(30)]
        public string DirectoreLanguageDTO { get; set; }
        public DateTime DirectoreDateBirthDTO { get; set; }

        public int DirectoreMovieIdDTO { get; set; }
        #endregion

        #region Production
        [StringLength(30)]
        public string ProductionNameDTO { get; set; }

        [StringLength(30)]
        public string ProductionCountryDTO { get; set; }

        [StringLength(50)]
        public string ProductionAddressDTO { get; set; }
        #endregion
    }
}
