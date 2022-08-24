using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swordland.Models
{
    public class ChallengersViewModel
    {
        public int ChallengeId { get; set; }
        public string StageName { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }

       // public string Alias { get; set; }
        public ICollection<Bet> Bets { get; set; }
    }
}
