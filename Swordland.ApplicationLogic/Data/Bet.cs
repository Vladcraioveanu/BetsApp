using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.ApplicationLogic.Data
{
    public class Bet
    {

        public int BetId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string CardNumber { get; set; }

        public string Sum { get; set; }


        public int ChallengerId { get; set; }
        public Challengers Challenger { get; set; }

    }
}
