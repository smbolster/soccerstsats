﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerStats.DataModel
{
    public class League
    {
        public League()
        {
            Teams = new List<Team>();
        }
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Description { get; set; }
        public List<Team> Teams { get; set; }
        public string Test { get; set; }
    }
}