using Microsoft.EntityFrameworkCore;
using SimpleWebSql.Data.Entity;

namespace SimpleWebSql.Data
{
    public class MovieDbContext:DbContext
    { public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

    }
}
