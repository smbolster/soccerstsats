using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class Referee : Person
    {
        public Referee()
        {
            this.Games = new HashSet<Game>();
        }
    
        public int OrgId { get; set; }
        public virtual ICollection<Game> Games { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
