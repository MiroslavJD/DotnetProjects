using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace project.Pages
{
    public class TeamsModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public TeamsModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

         public List<Team>? Teams { get; set; } = new List<Team>();

        public async Task OnGetAsync()
        {
             Teams = await _dbContext.Teams.Include(t => t.MatchResults).ToListAsync();
        }
    }
}