using Microsoft.AspNetCore.Mvc.Rendering;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IMovieServices
    {
        void Add(Movie movie);
        void Edit(Movie movie);
        void Delete(int movieId);


        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();

        Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>, List<SelectListItem>> FillDropdowns(
            IEnumerable<Actor> actors,
            IEnumerable<Category> categories,
            IEnumerable<Directore> directores,
            IEnumerable<Production> productions);

        IEnumerable<Movie> GetAllMoviesWitFullhRelationalData();
    }
}
