using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soccerstats.Data
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }

    }
}