using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.ApplicationLogic.Abstractions
{
    public interface IChallengerRepository : IRepository<Challengers>
    {
        Challengers GetChallenge(int id);
    }
}
