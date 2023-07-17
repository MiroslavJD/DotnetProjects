using System.Collections.Generic;
using System.Linq;

namespace project.Models
{
public class Team
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int TotalPoints { get; set; }
     public List<MatchResult> MatchResults { get; set; } = new List<MatchResult>(); 
    public int OpponentTotalPoints { get; set; }

}
}