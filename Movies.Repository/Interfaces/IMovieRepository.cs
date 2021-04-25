using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Repository.Interfaces
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        void Edit(Movie movie);
        void Edit(int id);
        void Delete(int movieId);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetAllMoviesWithFullRelationalData();

    }
}
