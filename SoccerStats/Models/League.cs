using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerStats.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Teams { get; set; }
        public string Description { get; set; }
    }
}