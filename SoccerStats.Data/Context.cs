﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerStats.DataModels;

namespace SoccerStats.Data
{
    public class Context : DbContext
    {
        public Context()
            : base("soccerStatsEntities")
        { }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<TeamPlayer> TeamPlayer { get; set; }

    }
}
