﻿using System;
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
    public class TournamentsController : ControllerBase
    {
        private readonly ITournamentDAO tournamentDAO;

        public TournamentsController(ITournamentDAO _tournamentDAO)
        {
            tournamentDAO = _tournamentDAO;
        }

        [HttpPost]
        public ActionResult<Tournament> AddTournament(Tournament newTournament)
        {
            try
            {
                return Ok(tournamentDAO.AddTournament(newTournament));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult <List<Tournament>> AllYourTournamentsAreBelongToMe(int organizerId)
        {
            try
            {
                return Ok(tournamentDAO.AllYourTournamentAreBelongToMe(organizerId));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
            
        }

    }
}
