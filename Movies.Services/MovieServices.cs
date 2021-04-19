using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Entities;
using Movies.Repository.Interfaces;
using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository _movieRepository;

        public MovieServices(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void Delete(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }

        public void Edit(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }
        public void Edit(int id)
        {
            _movieRepository.EditMovie(id);
        }


        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesWitFullhRelationalData()
        {
            var result = _movieRepository.GetAllMoviesWithFullRelationalData();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _movieRepository.GetMovieById(id);
            return result;
        }
        #region Helper Functions
        public Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns
            (IEnumerable<Actor> actors, 
            IEnumerable<Category> categories, 
            IEnumerable<Directore> directores, 
            IEnumerable<Production> productions)
        {
            List<SelectListItem> Actors = new List<SelectListItem>
            {
                new SelectListItem {Value="0", Text = "Select Actore..."}
            };
            List<SelectListItem> Categories = new List<SelectListItem>
            { 
                new SelectListItem {Value = "0", Text = "Select Category ..."}
            };
            List<SelectListItem> Directores = new List<SelectListItem>
            {  
                new SelectListItem { Value = "0", Text="Select Director ..."} 
            };
            List<SelectListItem> Productions = new List<SelectListItem>
            { 
                new SelectListItem{Value = "0", Text = ("Select Production ....")}
            };
            foreach (var actor in actors)
            {
                Actors.Add(new SelectListItem { Value = actor.Id.ToString(), Text = actor.Name });
            }
            foreach (var category in categories)
            {
                Categories.Add(new SelectListItem { Value = category.Id.ToString(), Text = category.Name });
            }
            foreach (var directore in directores)
            {
                Directores.Add(new SelectListItem { Value = directore.Id.ToString(), Text = directore.Name });
            }
            foreach (var production in productions)
            {
                Productions.Add(new SelectListItem { Value = production.Id.ToString(), Text = production.Name });
            }

            return Tuple.Create(Actors, Categories, Directores, Productions);
        }
        #endregion
    }
}
