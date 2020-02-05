using System;
using System.Collections.Generic;
using System.Text;
using FilmoweLove.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmoweLove.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<FilmoweLove.Models.NewMovies> NewMovies { get; set; }
        public DbSet<FilmoweLove.Models.NewSeries> NewSeries { get; set; }
        
    }
}
