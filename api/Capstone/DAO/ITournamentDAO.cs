using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface ITournamentDAO
    {
        Tournament AddTournament(Tournament tournament);

        List<Tournament> GetTournamentByOrganizerId(int OrganizerId);
        List<Tournament> AllYourTournamentAreBelongToMe(int OrganizerId);

        List<Tournament> GetAllTournaments();
    }
}
