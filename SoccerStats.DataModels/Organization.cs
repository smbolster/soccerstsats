using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class Organization
    {
        public Organization()
        {
            this.Leagues = new List<League>();
            this.Players = new List<Player>();
            this.Referees = new List<Referee>();
        }

        public int OrgID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<League> Leagues { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Referee> Referees { get; set; }
    }
}
