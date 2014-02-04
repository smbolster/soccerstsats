using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soccerstats.Data
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Description { get; set; }
        public List<string> Teams { get; set; }
    }
}