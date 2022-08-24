using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swordland.Models
{
    public class BetViewModel
    {
        public int BetId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string CardNumber { get; set; }

        public string Sum { get; set; }


        public int ChallengerId { get; set; }

        public Challengers Challengers { get; set; }
    }
}
