﻿using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Entities;
using Movies.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();

        }

        public void DeleteMovie(int movieId)
        {
            Movie movie = GetMovieById(movieId);
            _context.Movies.Remove(movie);
            _context.SaveChanges();

        }
        public void DeleteMovie(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
        public void EditMovie(int id)
        {
            var movie = GetMovieById(id);
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }
        public IEnumerable<Movie> GetAllMoviesWithFullRelationalData()
        {
            var result = _context.Movies
               .Include(a => a.Actor)
               .Include(c => c.Category)
               .Include(d => d.Directore)
               .Include(p => p.Production)
               .AsEnumerable();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _context.Movies.FirstOrDefault(x => x.Id == id);
            return result;
        }

       
    }
}
