using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IParticipantsDAO
    {
        Participants AddParticipants(Participants participant);
        List<Participants> GetAllParticipants();
        Participants GetParticipant(int participantId);


    }
}
