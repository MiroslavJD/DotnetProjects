using Microsoft.EntityFrameworkCore;
using project.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using project.Models;
using System;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add configuration settings
builder.Configuration.AddJsonFile("appsettings.json");

// Initialize the Configuration object
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!dbContext.Teams.Any())
    {
        // Add teams
        var teams = new[]
        {
            new Team { Name = "L.A. Lakers" },
            new Team { Name = "Chicago Bulls" },
            new Team { Name = "Brooklyn Nets" },
            new Team { Name = "New York Knicks" },
            new Team { Name = "Atlanta Hawks" },
            new Team { Name = "Miami Heat" }
        };

        dbContext.Teams.AddRange(teams);
        dbContext.SaveChanges();
    }

    if (!dbContext.MatchResults.Any())
    {

        // Get teams from the database
        var teams = dbContext.Teams.ToList();

        var awayTeams = teams.Skip(1).Concat(teams.Take(1)).ToList();
        // Add match results
        var matchResults = new[]
        {
            new MatchResult
        {
            Team1Name = teams[0].Name,
            Team2Name = awayTeams[1].Name,
            Team1Score = 120,
            Team2Score = 118
        },
        new MatchResult
        {
            Team1Name = teams[1].Name,
            Team2Name = awayTeams[0].Name,
            Team1Score = 97,
            Team2Score = 95
        },
        new MatchResult
        {
            Team1Name = teams[0].Name,
            Team2Name = awayTeams[2].Name,
            Team1Score = 100,
            Team2Score = 110
        },
        new MatchResult
        {
            Team1Name = teams[2].Name,
            Team2Name = awayTeams[0].Name,
            Team1Score = 112,
            Team2Score = 110
        },
        new MatchResult
        {
            Team1Name = teams[0].Name,
            Team2Name = awayTeams[3].Name,
            Team1Score = 111,
            Team2Score = 113
        },
        new MatchResult
        {
            Team1Name = teams[3].Name,
            Team2Name = awayTeams[0].Name,
            Team1Score = 99,
            Team2Score = 104
        },
        new MatchResult
        {
            Team1Name = teams[0].Name,
            Team2Name = awayTeams[4].Name,
            Team1Score = 105,
            Team2Score = 105
        },
        new MatchResult
        {
            Team1Name = teams[4].Name,
            Team2Name = awayTeams[0].Name,
            Team1Score = 89,
            Team2Score = 95
        },
        new MatchResult
        {
            Team1Name = teams[0].Name,
            Team2Name = awayTeams[5].Name,
            Team1Score = 115,
            Team2Score = 100
        },
        new MatchResult
        {
            Team1Name = teams[5].Name,
            Team2Name = awayTeams[0].Name,
            Team1Score = 104,
            Team2Score = 102
        },
        new MatchResult
        {
            Team1Name = teams[1].Name,
            Team2Name = awayTeams[2].Name,
            Team1Score = 103,
            Team2Score = 100
        },
        new MatchResult
        {
            Team1Name = teams[2].Name,
            Team2Name = awayTeams[1].Name,
            Team1Score = 104,
            Team2Score = 106
        },
        new MatchResult
        {
            Team1Name = teams[1].Name,
            Team2Name = awayTeams[3].Name,
            Team1Score = 103,
            Team2Score = 100
        },
        new MatchResult
        {
            Team1Name = teams[3].Name,
            Team2Name = awayTeams[1].Name,
            Team1Score = 95,
            Team2Score = 102
        },
        new MatchResult
        {
            Team1Name = teams[1].Name,
            Team2Name = awayTeams[4].Name,
            Team1Score = 101,
            Team2Score = 111
        },
        new MatchResult
        {
            Team1Name = teams[4].Name,
            Team2Name = awayTeams[1].Name,
            Team1Score = 107,
            Team2Score = 102
        },
        new MatchResult
        {
            Team1Name = teams[1].Name,
            Team2Name = awayTeams[5].Name,
            Team1Score = 106,
            Team2Score = 101
        },
        new MatchResult
        {
            Team1Name = teams[5].Name,
            Team2Name = awayTeams[1].Name,
            Team1Score = 104,
            Team2Score = 100
        },
            // Add more match results as needed
        };

        dbContext.MatchResults.AddRange(matchResults);
        dbContext.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();