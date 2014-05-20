using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerStats.DataModel
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }

    }
}