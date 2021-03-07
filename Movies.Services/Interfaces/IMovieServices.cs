using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IMovieServices
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieId);


        Movie GetMovieById(int movieId);
        IEnumerable<Movie> GetAllMovies();
    }
}
