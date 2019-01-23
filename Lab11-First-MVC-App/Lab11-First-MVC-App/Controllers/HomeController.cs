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

        [HttpGet]
        public IActionResult Index()
        {
            //List <Person> parsedData = new List<Person>();

            //try
            //{
            //    using (StreamReader readFile = new StreamReader(Path))
            //    {
            //        string line;
            //        string[] row;

            //        while ((line = readFile.ReadLine()) != null)
            //        {
            //            row = line.Split(',');
            //            parsedData.Add(row);
            //        }
            //    }
            //}
            //catch(Exception e)
            //{ 
            //    Console.Write(e.Message);
            //}
                return View();
        }

        [HttpPost]
        public IActionResult Index(int yearOne, int yearTwo)
        {
            return RedirectToAction("Results", new { yearOne, yearTwo });
        }

        public IActionResult Result(int yearOne, int yearTwo)
        {
            Person person = new Person();
            return View(Person.GetPersons(yearOne, yearTwo));
        }
    }
}
