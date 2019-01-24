using Lab11_First_MVC_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Lab11_First_MVC_App.Controllers
{

    public class HomeController : Controller
    {
        public static string Path = "../personOfTheYear.csv";

        /// <summary>
        /// Calls initial index view
        /// </summary>
        /// <returns>index view</returns>
        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        /// <summary>
        /// Redirects Index view to Results view, passing in input arguments
        /// </summary>
        /// <param name="yearOne">starting year input</param>
        /// <param name="yearTwo">ending year input</param>
        /// <returns>results page with given inputs passed in</returns>
        [HttpPost]
        public IActionResult Index(int yearOne, int yearTwo)
        {
            return RedirectToAction("Results", new { yearOne, yearTwo });
        }

        /// <summary>
        /// Calls method into results page view
        /// </summary>
        /// <param name="yearOne">starting year input</param>
        /// <param name="yearTwo">ending year input</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Results(int yearOne, int yearTwo)
        {
            TimePerson person = new TimePerson();
            return View(TimePerson.GetPersons(yearOne, yearTwo));
        }
    }
}
