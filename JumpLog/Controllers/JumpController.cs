using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace JumpLog.Controllers
{
    public class JumpController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("No jump selected");
        }

        public IActionResult Show(int id)
        {
            // using dummy data for now (will be replaced with db eventually)
            Jump jump = new Jump();
            if (id == 1)
            {
                jump.Location = "Rogers DZ";
                jump.Date = "4/17/2021";
                jump.Aircraft = "C-130";
            }
            else
            {
                jump.Location = "Rogers DZ";
                jump.Date = "3/20/2021";
                jump.Aircraft = "C-17";
            }
            // using ViewData to set meta tag for page
            ViewData["Title"] = "Show Jump";

            return View(jump);
        }

        public IActionResult Add()
        {
            // shows the "Add Jump" page

            // using ViewData to set meta tag for page
            ViewData["Title"] = "Add Jump";

            return View();
        }
    }
}
