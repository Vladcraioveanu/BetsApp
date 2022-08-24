using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swordland.EFDataAccess
{
    public class EnrollRepository : BaseRepository<Enroll>, IEnrollRepository
    {
        public EnrollRepository(SwordlandDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckUniqueEmail(string Email)
        {
            var dbEntry = dbContext.Enrolls.FirstOrDefault(x => x.Email == Email);

            if (dbEntry != null)
                return true;
            return false;
        }
    }
}
