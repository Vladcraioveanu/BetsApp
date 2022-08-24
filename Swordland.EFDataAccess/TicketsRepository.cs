using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.EFDataAccess
{
    public class TicketsRepository : BaseRepository<Tickets>, ITicketsRepository
    {
        public TicketsRepository(SwordlandDbContext dbContext) : base(dbContext)
        {

        }

    }
}
    

