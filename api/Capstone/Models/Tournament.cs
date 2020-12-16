using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Tournament
    {
        public int tournament_id { get; set; }
        public string name { get; set; }
        public int numberofparticipants { get; set; }
        public int currentround { get; set; }
        public int organizer_id { get; set; }

    }
}
