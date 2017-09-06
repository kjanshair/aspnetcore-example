using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Home";            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact";

            return View();
        }
    }
}
