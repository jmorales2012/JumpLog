using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Validators;


namespace JumpLog.Models
{
    public class Soldier
    {
        [Required(ErrorMessage = "You must enter a last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="You must enter a first name")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a rank")]
        [Display(Name = "Rank")]
        public string Rank { get; set; }

        [Required(ErrorMessage = "You must enter a DoD ID")]
        [StringLength(maximumLength:10, MinimumLength =10)]
        [Display(Name = "DoD ID")]
        public string DodId { get; set; }

        [Required(ErrorMessage = "You must enter a SSN")]
        [StringLength(maximumLength:9, MinimumLength =9)]
        [Display(Name = "SSN")]
        public string Ssn { get; set; }

        [Required(ErrorMessage = "You must enter a company")]
        [Display(Name = "Company")]
        public string Company { get; set; }

        [Required(ErrorMessage = "You must enter a platoon")]
        [Display(Name = "Platoon")]
        public string Platoon { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Arrived")]
        [SoldierCurrentDate]
        public DateTime DateArrived { get; set; }
    }
}
