using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;

namespace JumpLog.Services
{
    public interface IJumpData
    {
        List<Jump> JumpList { get; set; }
    }
}
