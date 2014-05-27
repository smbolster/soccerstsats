using SoccerStats.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.Data
{
    public class Repository : SoccerStats.Data.IRepository
    {
        Context db = new Context();
        public IQueryable<Game> Games()
        {
            return db.Games;
        }
        public IQueryable<Game> LeagueGames(int LeagueId)
        {
            return db.Games.Where(l => l.LeagueId == LeagueId);
        }
        public IQueryable<League> Leagues()
        {
            return db.Leagues;
        }
        public IQueryable<Organization> Organizations()
        {
            return db.Organizations;
        }
        public IQueryable<Player> Players()
        {
            return db.Players;
        }
        public IQueryable<Referee> Referees()
        {
            return db.Referees;
        }

    }
}
