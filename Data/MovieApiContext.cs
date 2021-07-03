using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApiV.Model;

namespace MovieApiV2.Data
{
    public class MovieApiContext : DbContext
    {
        public MovieApiContext(DbContextOptions<MovieApiContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
 