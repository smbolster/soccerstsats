using SoccerStats.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.Data
{
    
    public class TeamRepository
    {
        Context db = new Context();

        public IQueryable<League> GetLeagues()
        {
            return db.Leagues;
        }

    }
}
