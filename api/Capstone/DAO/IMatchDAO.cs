using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IMatchDAO
    {
        Match AddMatch(Match match);
        List<Match> GetAllMatches();
        Match GetMatch(int matchId);
        bool UpdateScoreTeamOne(Match updated);
        bool UpdateScoreTeamTwo(Match updated);
        List<Match> GetMatchByRoundId(List<int> roundIds);


    }
}
