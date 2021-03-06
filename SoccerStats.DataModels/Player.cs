﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class Player : Person
    {
        public Player()
        {
            this.TeamPlayers = new HashSet<TeamPlayer>();
        }
    
        public string Number { get; set; }
        public int OrgId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<TeamPlayer> TeamPlayers { get; set; }

    }
}
