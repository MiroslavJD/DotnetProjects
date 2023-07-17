using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Data;
using project.Models;
using System.Linq;

namespace project.Pages
{
    public class HighlightMatchModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public MatchResult HighlightMatch { get; set; }

        public HighlightMatchModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            HighlightMatch = GetHighlightMatch();
        }

        private MatchResult GetHighlightMatch()
        {
            return _dbContext.MatchResults
                .OrderByDescending(m => m.Team1Score + m.Team2Score)
                .FirstOrDefault();
        }
    }
}