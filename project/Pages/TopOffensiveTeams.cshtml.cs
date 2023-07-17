using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Data;
using project.Models;

namespace project.Pages
{
    public class TopOffensiveTeamsModel : PageModel
    {
        private readonly AppDbContext _dbContext;

        public List<Team> TopOffensiveTeams { get; set; } = new List<Team>();
        public List<Team> TopDefensiveTeams { get; set; } = new List<Team>();

        public TopOffensiveTeamsModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            var teams = _dbContext.Teams.ToList();
            foreach (var team in teams)
            {
                team.OpponentTotalPoints = GetOpponentTotalPoints(team);
                team.TotalPoints = GetTotalPoints(team);
            }

            TopOffensiveTeams = teams
                .OrderByDescending(t => t.TotalPoints)
                .Take(5)
                .ToList();

            TopDefensiveTeams = teams
                .OrderBy(t => t.OpponentTotalPoints)
                .Take(5)
                .ToList();
        }

        private int GetOpponentTotalPoints(Team team)
        {
            int homePoints = _dbContext.MatchResults
                .Where(m => m.Team2Name == team.Name)
                .Sum(m => m.Team1Score);
            int awayPoints = _dbContext.MatchResults
                .Where(m => m.Team1Name == team.Name)
                .Sum(m => m.Team2Score);
            return homePoints + awayPoints;
        }
        
         private int GetTotalPoints(Team team)
        {
            int homePoints = _dbContext.MatchResults
                .Where(m => m.Team1Name == team.Name)
                .Sum(m => m.Team1Score);
            int awayPoints = _dbContext.MatchResults
                .Where(m => m.Team2Name == team.Name)
                .Sum(m => m.Team2Score);
            return homePoints + awayPoints;
        }
    }
}