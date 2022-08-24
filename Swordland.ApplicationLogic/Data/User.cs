using System;
using System.Collections.Generic;
using System.Text;

namespace Swordland.ApplicationLogic.Data
{
    public class User
    {
        public string UserId { get; set; }

    public ICollection<Tickets> Tickets { get; set; }
    }
}