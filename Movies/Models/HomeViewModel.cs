using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> AllMovieList { get; set; }
    }
}
