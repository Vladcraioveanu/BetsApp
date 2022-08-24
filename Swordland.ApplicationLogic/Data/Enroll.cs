using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Swordland.ApplicationLogic.Data
{
    public class Enroll
    {
        public int EnrollId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StageName { get; set; }

        public string Email { get; set; }

        public string Sword { get; set; }

        public string Description { get; set; }
    }
}
