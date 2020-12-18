using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IParticipantsDAO
    {
        Participants AddParticipants(Participants participants);
        List<Participants> GetAllParticipants();
        Participants GetParticipants(int participantId);
        List<Match> GetParticipantsByMatchIds(List<int> MatchIDs,string connectionString);



    }
}
