using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;

namespace JumpLog.Services
{
    public interface ISoldierData
    {
        List<Soldier> SoldierList { get; set; }
    }
}
