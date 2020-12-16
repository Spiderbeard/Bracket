using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IParticipantsDAO
    {
        Participant AddParticipants(Participant participant);
        List<Participant> GetAllParticipants();
        Participant GetParticipant(int participantId);


    }
}
