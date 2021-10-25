using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SimpleWebSql.Data;
using SimpleWebSql.Data.Entity;

namespace SimpleWebSql.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MovieDbContext _movieDbContext;
        public List<Movie> MovieData { get; set; }

        public IndexModel(ILogger<IndexModel> logger, MovieDbContext movieDbContext)
        {
            _logger = logger;
            _movieDbContext = movieDbContext;
        }

        public async Task OnGet()
        {
            MovieData = await _movieDbContext.Movie.ToListAsync();
        }
    }
}
