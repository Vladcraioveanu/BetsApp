using Swordland.ApplicationLogic.Abstractions;
using Swordland.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.ApplicationLogic
{
    public interface IUserRepository : IRepository<User>
    {
        void AddUser(string userId);
        bool CheckIfUserExists(string userId);
    }
}
