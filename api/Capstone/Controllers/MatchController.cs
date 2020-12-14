using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.DAO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MatchController : ControllerBase
    {
        private static IMatchDAO MatchSqlDAO;
        private static IParticipantsDAO ParticipantsSqlDAO;
        private static IRoundsDAO RoundsSqlDAO;
        private static ITournamentDAO TournamentSqlDAO;

        public MatchController(IMatchDAO _matchDAO, IParticipantsDAO _participantsDAO, IRoundsDAO _roundsDAO, ITournamentDAO _tournamentDAO)
        {
            MatchSqlDAO = _matchDAO;
            ParticipantsSqlDAO = _participantsDAO;
            RoundsSqlDAO = _roundsDAO;
            TournamentSqlDAO = _tournamentDAO;

        }

        [HttpPost]
        public ActionResult<Match> AddMatch(Match matchToInsert)
        {
            Match match = MatchSqlDAO.AddMatch(matchToInsert);
            if (match != null)
            {
                return Ok(match);
            }
            else return NotFound();
        }
    }
}
