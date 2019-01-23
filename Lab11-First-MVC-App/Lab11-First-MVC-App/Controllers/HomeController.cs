using Lab11_First_MVC_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_First_MVC_App.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int yearOne, int yearTwo)
        {
            return RedirectToAction("Result", new { yearOne, yearTwo });
        }

        public IActionResult Result(int yearOne, int yearTwo)
        {
            Person person = new Person(yearOne, yearTwo);
            return View(person);
        }
    }
}
