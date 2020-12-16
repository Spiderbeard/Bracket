using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string Name { get; set; }
        public int NumberOfParticipants { get; set; }
        public int CurrentRound { get; set; }
        public int OrganizerId { get; set; }


        public List<Rounds> Rounds { get; set; }
    }
}
