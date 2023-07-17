using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
public class AppDbContext : DbContext
{
        public DbSet<Team> Teams { get; set; }
        public DbSet<MatchResult> MatchResults { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
     modelBuilder.Entity<MatchResult>()
        .HasOne<Team>()
        .WithMany()
        .HasForeignKey(mr => mr.Team1Name)
        .HasPrincipalKey(t => t.Name);

    modelBuilder.Entity<MatchResult>()
        .HasOne<Team>()
        .WithMany()
        .HasForeignKey(mr => mr.Team2Name)
        .HasPrincipalKey(t => t.Name);
}
}
}