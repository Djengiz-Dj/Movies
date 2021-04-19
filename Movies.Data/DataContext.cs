using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        // *** have to tell the datacontext class about our models ***
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Directore> Directores { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    //sluzi na datacontext...za dataceeding
        //    base.OnModelCreating(builder);
        //}
    }
}
