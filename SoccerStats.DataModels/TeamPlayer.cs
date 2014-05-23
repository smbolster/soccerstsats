using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats.DataModels
{
    public class TeamPlayer
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
