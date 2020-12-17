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
        private static IMatchDAO matchDAO;


        public MatchController(IMatchDAO _matchDAO)
        {
            matchDAO = _matchDAO;
          
        }

        [HttpPost]
        public ActionResult<List<Match>> AddMatch(List<Match> matchsToInsert)
        {
            List<Match> output = new List<Match>();

            try
            {
                foreach (Match match in matchsToInsert)
                {
                    output.Add(matchDAO.AddMatch(match));
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
