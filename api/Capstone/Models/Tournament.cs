using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; } = 0;
        public string Name { get; set; } = "";
        public int NumberOfParticipants { get; set; } = 0;
        public int CurrentRound { get; set; } = 0;
        public int OrganizerId { get; set; } = 0;


        public List<Rounds> Rounds { get; set; } = new List<Rounds>();
    }
}
