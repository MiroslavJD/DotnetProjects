using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using project.Models;

namespace project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public IndexModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Team>? Teams { get; set; }

        public async Task OnGetAsync()
        {
            Teams = await _dbContext.Teams.ToListAsync();
        }
    
        public IActionResult OnPost(int team1Id, int team2Id)
        {
            // Save the match results to the database
            // You can create a new MatchResult object and save it to the _dbContext.MatchResults

            return RedirectToPage("/Index");
        }
    }
}