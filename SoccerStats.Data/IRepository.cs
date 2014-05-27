using System;
namespace SoccerStats.Data
{
    public interface IRepository
    {
        System.Linq.IQueryable<SoccerStats.DataModels.Game> Games();
        System.Linq.IQueryable<SoccerStats.DataModels.Game> LeagueGames(int LeagueId);
        System.Linq.IQueryable<SoccerStats.DataModels.League> Leagues();
        System.Linq.IQueryable<SoccerStats.DataModels.Organization> Organizations();
        System.Linq.IQueryable<SoccerStats.DataModels.Player> Players();
        System.Linq.IQueryable<SoccerStats.DataModels.Referee> Referees();
    }
}
