using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
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
        public int OrgId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
