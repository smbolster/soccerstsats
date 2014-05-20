using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class Organization
    {
        public int OrgID { get; set; }
        public List<League> Leagues { get; set; }
    }
}
