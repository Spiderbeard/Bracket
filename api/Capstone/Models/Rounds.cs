using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Rounds
    {
        public int RoundNumber { get; set; }
        public bool IsActive { get; set; }
        public int TournamentId { get; set; }
        public int RoundId { get; set; }

        public List<Match> Matches {  get;  set;  }
    }
}
