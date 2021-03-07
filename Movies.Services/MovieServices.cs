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

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }

        public void EditMovie(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public Movie GetMovieById(int movieId)
        {
            var result = _movieRepository.GetMovieById(movieId);
            return result;
        }
    }
}
