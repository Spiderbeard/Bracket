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
    public class RoundsController : ControllerBase
    {
        private readonly IRoundsDAO roundsDAO;


        public RoundsController(IRoundsDAO _roundsDAO)
        {
            roundsDAO = _roundsDAO;
        }


        [HttpPost]
        public ActionResult<List<Rounds>>SetRounds(List<Rounds> roundList)
        {
            List<Rounds> output = new List<Rounds>();

            try
            {
                foreach(Rounds round in roundList)
                {
                    output.Add(roundsDAO.AddRound(round));
                }

                return Ok(output);




            }
            catch (Exception e)
            {

                return BadRequest(e);
            }





        }

    }
}
