﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Match
    {
        public int MatchNumber { get; set; }
        public bool IsActive { get; set; }
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public bool Team1Winner { get; set; }
        public bool Team2Winner { get; set; }
        public int RoundId { get; set; }
        public int MatchId { get; set; }
        public int Team1 { get; set; }
        public int Team2 { get; set; }

        public int Participant1_Id { get; set; }
        public string Participant1_name { get; set; }
        public bool Participant1_isActive { get; set; }

        public int Participant2_Id { get; set;  }
        public string Participant2_name { get;  set; }
        public bool Participant2_isActive { get; set; }
    }
}
