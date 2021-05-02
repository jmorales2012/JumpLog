using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;

namespace JumpLog.Services
{
    public class SoldierData : ISoldierData
    {
        public List<Soldier> SoldierList { get; set; }

        public SoldierData()
        {
            SoldierList = new List<Soldier>();

            SoldierList.Add(new Soldier()
            {
                LastName = "Williams",
                FirstName = "Alex",
                Rank = "SGT",
                DodId = "12345678",
                Ssn = "43256891",
                Company = "C",
                Platoon = "1",
                DateArrived = new DateTime(2018, 3, 21)
            });

            SoldierList.Add(new Soldier()
            {
                LastName = "Johnson",
                FirstName = "James",
                Rank = "SPC",
                DodId = "487594187",
                Ssn = "741859632",
                Company = "B",
                Platoon = "1",
                DateArrived = new DateTime(2019, 6, 18)
            });

            SoldierList.Add(new Soldier()
            {
                LastName = "Snuffy",
                FirstName = "Joe",
                Rank = "PVT",
                DodId = "987584712",
                Ssn = "987654321",
                Company = "A",
                Platoon = "1",
                DateArrived = new DateTime(2020, 2, 11)
            });
        }
    }
}
