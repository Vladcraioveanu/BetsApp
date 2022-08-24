using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Swordland.ApplicationLogic.Data
{
    public class Tickets
    {
        public int TicketsId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int MatchNumber { get; set; }

        public int CardNumber { get; set; }

        public string UserId { get; set; }

        public User Users { get; set; }
    }
}
