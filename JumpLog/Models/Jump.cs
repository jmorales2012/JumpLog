using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Validators;

namespace JumpLog.Models
{
    public class Jump
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Aircraft { get; set; }
    }
}
