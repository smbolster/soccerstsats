using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerStats.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int PlayerId { get; set; }
        
        //navigation
        public List<Player> Players { get; set; }

    }
}