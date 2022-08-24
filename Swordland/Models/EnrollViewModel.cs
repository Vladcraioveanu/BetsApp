using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Swordland.Models
{
    public class EnrollViewModel
    {
        public int EnrollId;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Stage name")]
        public string StageName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Sword type")]
        public string Sword { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Describe your figthing style and abilities")]
        public string Description { get; set; }
    }
}
