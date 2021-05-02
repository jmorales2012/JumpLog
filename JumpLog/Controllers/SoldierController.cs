using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;
using Microsoft.AspNetCore.Mvc;
using JumpLog.Services;

namespace JumpLog.Controllers
{
    public class SoldierController : Controller
    {
        private ISoldierData Battalion;

        public SoldierController(ISoldierData myService)
        {
            Battalion = myService;
        }

        public IActionResult Index()
        {
            return Content("No soldier selected");
        }

        public IActionResult Show(int id)
        {
            // using ViewData to set meta tag for page
            ViewData["Title"] = "Show Soldier";

            if (id < 0 || id >= Battalion.SoldierList.Count)
            {
                return NotFound();
            }
            else
            {
                //ViewBag.SoldierList = Battalion.SoldierList;
                ViewBag.Id = id;
                return View(Battalion.SoldierList[id]);
            }
        }

        public IActionResult All()
        {          
            return View(Battalion.SoldierList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // using ViewData to set meta tag for page
            ViewData["Title"] = "Add Soldier";
            return View();
        }

        [HttpPost]
        public IActionResult Add(Soldier soldier)
        {
            Battalion.SoldierList.Add(soldier);
            //return Content($"Added new soldier with last name {soldier.LastName}!");
            return View("All", Battalion.SoldierList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //validate the id
            if (id < 0 || id >= Battalion.SoldierList.Count)
                return Content("invalid id!");

            return View(Battalion.SoldierList[id]);
        }

        [HttpPost]
        public IActionResult Edit(int id, Soldier soldier)
        {
            Battalion.SoldierList[id].LastName = soldier.LastName;
            Battalion.SoldierList[id].FirstName = soldier.FirstName;
            Battalion.SoldierList[id].Rank = soldier.Rank;
            Battalion.SoldierList[id].DodId = soldier.DodId;
            Battalion.SoldierList[id].Ssn = soldier.Ssn;
            Battalion.SoldierList[id].Company = soldier.Company;
            Battalion.SoldierList[id].Platoon = soldier.Platoon;
            Battalion.SoldierList[id].DateArrived = soldier.DateArrived;

            return View("Show", Battalion.SoldierList[id]);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //validate the id
            if (id < 0 || id >= Battalion.SoldierList.Count)
                return Content("invalid id!");

            ViewBag.Id = id;
            return View(Battalion.SoldierList[id]);
        }


        [HttpPost]
        public IActionResult ActualDelete(int id)
        {
            Battalion.SoldierList.RemoveAt(id);
            return RedirectToAction("All", Battalion.SoldierList);
        }
    }
}
