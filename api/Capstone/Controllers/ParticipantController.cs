using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantsDAO participantsDAO;

        public ParticipantController(IParticipantsDAO _participantsDAO)
        {
            participantsDAO = _participantsDAO;
        }

        [HttpPost]
        public ActionResult<List<Participant>> BulkAddPaticipants(List<Participant> participantsToAdd)
        {
            List<Participant> returnList = new List<Participant>();

            try
            {
                foreach(Participant guy in participantsToAdd)
                {
                   returnList.Add(participantsDAO.AddParticipants(guy));
                }

                return Ok(returnList);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }










    }

}
