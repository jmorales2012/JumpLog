using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace JumpLog.Controllers
{
    public class SoldierController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("No soldier selected");
        }

        public IActionResult Show(int id)
        {

            // creating dummy data for models (will be replaced with database eventually)
            Soldier soldier = new Soldier();
            if (id == 1)
            {
                soldier.FirstName = "Alex";
                soldier.LastName = "Williams";
                soldier.Rank = "SGT";
                soldier.DodId = "12345678";
                soldier.Ssn = "432568901";
                soldier.Company = "C";
                soldier.Platoon = "1";
                soldier.DateArrived = "3/21/2018";
            }
            else
            {
                soldier.FirstName = "James";
                soldier.LastName = "Johnson";
                soldier.Rank = "SPC";
                soldier.DodId = "487594187";
                soldier.Ssn = "741859632";
                soldier.Company = "A";
                soldier.Platoon = "1";
                soldier.DateArrived = "2/11/2020";
            }

            // using ViewData to set meta tag for page
            ViewData["Title"] = "Show Soldier";

            return View(soldier);
        }

        public IActionResult Add()
        {
            // shows the "Add Soldier" page

            // using ViewData to set meta tag for page
            ViewData["Title"] = "Add Soldier";

            return View();
        }
    }
}
