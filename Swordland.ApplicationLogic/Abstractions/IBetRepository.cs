using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.ApplicationLogic.Abstractions
{
    public interface IBetRepository : IRepository<Bet>
    {
        bool CheckUniqueEmailByChallengerId(string Email, int ChallengerId);
    }
}
