using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swordland.EFDataAccess
{
    public class ChallengerRepository : BaseRepository<Challengers>, IChallengerRepository
    {
        public ChallengerRepository(SwordlandDbContext dbContext) : base(dbContext)
        {

        }

        public Challengers GetChallenge(int id)
        {
            return dbContext.Challengers.SingleOrDefault(s => s.ChallengeId == id);
        }
    }
}
