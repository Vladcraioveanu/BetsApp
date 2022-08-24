using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Swordland.Models
{
    public class TicketsViewModel
    {
        public int TicketsId;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public int MatchNumber { get; set; }

        [Required]
        public int CardNumber { get; set; }

        public string UserId { get; set; }
    }
}

