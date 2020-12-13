using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.DAO
{
    interface IRoundsDAO
    {
        Rounds AddRound(Rounds round);
        List<Rounds> GetAllRounds();
        Rounds GetRound(int roundId);
        bool MarkRoundsInactive(int roundId);



    }
}
