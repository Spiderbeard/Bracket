using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface IRoundsDAO
    {
        Rounds AddRound(Rounds round);
        List<Rounds> GetAllRounds();
        Rounds GetRound(int roundId);
        bool MarkRoundsInactive(int roundId);
        void GetMatchesByRound(int roundId);
        List<Rounds> GetRoundsByTournamentID(List<int> tournamentIDs,string connectionString);




    }
}
