using System;
using System.Collections.Generic;
namespace JumpLog.Models
{
    public static class Soldiers
    {
        public static List<Soldier> SoldiersList;

        public static void addSoldier(Soldier tempSoldier)
        {
            //Soldier tempSoldier = new Soldier();

            tempSoldier.LastName = "Williams";
            tempSoldier.FirstName = "Alex";
            tempSoldier.Rank = "SGT";
            tempSoldier.DodId = "345678901";
            tempSoldier.Ssn = "123456789";
            tempSoldier.Company = "A";
            tempSoldier.Platoon = "1";
            tempSoldier.DateArrived = "1/1/2021";

            SoldiersList.Add(tempSoldier);
        }
    }

    public class Soldier
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Rank { get; set; }
        public string DodId { get; set; }
        public string Ssn { get; set; }
        public string Company { get; set; }
        public string Platoon { get; set; }
        public string DateArrived { get; set; }
    }
}
