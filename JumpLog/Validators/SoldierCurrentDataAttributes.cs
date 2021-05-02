using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;

namespace JumpLog.Validators
{
    public class SoldierCurrentDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Soldier currentSoldier = (Soldier)validationContext.ObjectInstance;
            if (currentSoldier.DateArrived <= DateTime.Now.Date)
                return ValidationResult.Success;
            else
                return new ValidationResult("The date needs to in the past");
        }
    }
}
