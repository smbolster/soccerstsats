using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class Game
    {

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int HomeTeam { get; set; }
        public int AwayTeam { get; set; }
        public int  RefId { get; set; }
        public int LeagueId { get; set; }
        public virtual League League { get; set; }
        public virtual Referee Referee { get; set; }
        public virtual Team HomeTeam1 { get; set; }
        public virtual Team AwayTeam1 { get; set; }
    }
}
