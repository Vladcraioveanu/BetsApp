using Swordland.ApplicationLogic;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swordland.EFDataAccess
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SwordlandDbContext dbContext) : base(dbContext)
        {

        }

        public void AddUser(string userId)
        {
            this.Add(new User() { UserId = userId });
        }

        public bool CheckIfUserExists(string userId)
        {
            if (dbContext.Users.FirstOrDefault(user => user.UserId == userId) != null)
            {
                return true;
            }
            return false;
        }
    }
}
