using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerStats.DataModel
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public Referee Referee { get; set; }

    }
}