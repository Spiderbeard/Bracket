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
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantsDAO participantsDAO;

        public ParticipantsController(IParticipantsDAO _participantsDAO)
        {
            participantsDAO = _participantsDAO;
        }

        [HttpPost]
        public ActionResult<List<Participants>> BulkAddPaticipants(List<Participants> participantsToAdd)
        {
            List<Participants> returnList = new List<Participants>();

            try
            {
                foreach(Participants guy in participantsToAdd)
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
