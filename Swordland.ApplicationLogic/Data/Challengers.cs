using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Swordland.ApplicationLogic.Data
{
    public class Challengers
    {
        public int ChallengeId { get; set; }
        public string StageName { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public ICollection<Bet> Bets { get; set; }

    }
}
