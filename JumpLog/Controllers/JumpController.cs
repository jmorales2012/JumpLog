using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;
using Microsoft.AspNetCore.Mvc;
using JumpLog.Services;

namespace JumpLog.Controllers
{
    public class JumpController : Controller
    {
        private IJumpData JumpRoster;

        public JumpController(IJumpData myService)
        {
            JumpRoster = myService;
        }

        public IActionResult Index()
        {
            return Content("No soldier selected");
        }

        public IActionResult Show(int id)
        {
            // using ViewData to set meta tag for page
            ViewData["Title"] = "Show Soldier";

            if (id < 0 || id >= JumpRoster.JumpList.Count)
            {
                return NotFound();
            }
            else
            {
                //ViewBag.JumpList = JumpRoster.JumpList;
                ViewBag.Id = id;
                return View(JumpRoster.JumpList[id]);
            }
        }

        public IActionResult All()
        {
            return View(JumpRoster.JumpList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            // using ViewData to set meta tag for page
            ViewData["Title"] = "Add Jump";
            return View();
        }

        [HttpPost]
        public IActionResult Add(Jump jump)
        {
            JumpRoster.JumpList.Add(jump);
            //return Content($"Added new soldier with last name {soldier.LastName}!");
            return View("All", JumpRoster.JumpList);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //validate the id
            if (id < 0 || id >= JumpRoster.JumpList.Count)
                return Content("invalid id!");

            return View(JumpRoster.JumpList[id]);
        }

        [HttpPost]
        public IActionResult Edit(int id, Jump jump)
        {
            JumpRoster.JumpList[id].Date = jump.Date;
            JumpRoster.JumpList[id].Location = jump.Location;
            JumpRoster.JumpList[id].Aircraft = jump.Aircraft;

            return View("Show", JumpRoster.JumpList[id]);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //validate the id
            if (id < 0 || id >= JumpRoster.JumpList.Count)
                return Content("invalid id!");

            ViewBag.Id = id;
            return View(JumpRoster.JumpList[id]);
        }


        [HttpPost]
        public IActionResult ActualDelete(int id)
        {
            JumpRoster.JumpList.RemoveAt(id);
            return RedirectToAction("All", JumpRoster.JumpList);
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using JumpLog.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace JumpLog.Controllers
//{
//    public class JumpController : Controller
//    {
//        // GET: /<controller>/
//        public IActionResult Index()
//        {
//            return Content("No jump selected");
//        }

//        public IActionResult Show(int id)
//        {
//            // using dummy data for now (will be replaced with db eventually)
//            Jump jump = new Jump();
//            if (id == 1)
//            {
//                jump.Location = "Rogers DZ";
//                jump.Date = "4/17/2021";
//                jump.Aircraft = "C-130";
//            }
//            else
//            {
//                jump.Location = "Rogers DZ";
//                jump.Date = "3/20/2021";
//                jump.Aircraft = "C-17";
//            }
//            // using ViewData to set meta tag for page
//            ViewData["Title"] = "Show Jump";

//            return View(jump);
//        }

//        public IActionResult Add()
//        {
//            // shows the "Add Jump" page

//            // using ViewData to set meta tag for page
//            ViewData["Title"] = "Add Jump";

//            return View();
//        }
//    }
//}
