using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }
        public int Id { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }

    }
}
