using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace project.Pages
{
    public class MatchResultsModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public MatchResultsModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<MatchResult> MatchResults { get; set; }

        public async Task OnGetAsync()
        {
            MatchResults = await _dbContext.MatchResults.ToListAsync();
        }
    }
}