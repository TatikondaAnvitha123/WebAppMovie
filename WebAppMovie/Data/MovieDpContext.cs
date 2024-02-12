using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMovie.Models;

namespace WebAppMovie.Data
{
    public class MovieDpContext : DbContext
    {
        public MovieDpContext (DbContextOptions<MovieDpContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
