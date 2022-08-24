using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.EFDataAccess
{
    public class BetRepository : BaseRepository<Bet>, IBetRepository
    {
        public BetRepository(SwordlandDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckUniqueEmailByChallengerId(string Email, int ChallengerId)
        {
            throw new NotImplementedException();
        }
    }
}
