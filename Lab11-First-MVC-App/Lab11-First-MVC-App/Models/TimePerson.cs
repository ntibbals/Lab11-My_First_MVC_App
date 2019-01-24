using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Lab11_First_MVC_App.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        /// <summary>
        /// Method reads in CSV file and pushes into new instantiated list that contians Time Person objects
        /// </summary>
        /// <param name="yearOne">starting year input</param>
        /// <param name="yearTwo">ending year input</param>
        /// <returns></returns>
        public static List<TimePerson> GetPersons(int yearOne, int yearTwo)
        {
            string path = "../../../wwwroot/personOfTheYear.csv"; /// initial root path
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path); /// combines root paths to read file in
            string[] parsedResults = File.ReadAllLines(fullPath); /// reads file into an array
            
            List<TimePerson> parsedData = new List<TimePerson>(); ///newly instantiatd list to hold parsed csv data
            foreach (string item in parsedResults.Skip(1)) /// runs through for each, skipping initial title line in document
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] column = item.Split(","); ///splits array into comma delimited array
                    parsedData.Add(new TimePerson
                    {
                        Year =(column[0] == "") ? 0: Convert.ToInt32(column[0]), /// ternary operated to check if empty
                        Honor = column[1],
                        Name = column[2],
                        Country = column[3],
                        BirthYear = (column[4] == "") ? 0 : Convert.ToInt32(column[4]), /// ternary operated to check if empty
                        DeathYear = (column[5] == "") ? 0 : Convert.ToInt32(column[5]), /// ternary operated to check if empty
                        Title = column[6],
                        Category = column[7],
                        Context = column[8],
                    });
                }
            }
            var personOfYear = parsedData.Where(p => (p.Year >= yearOne) && (p.Year <= yearTwo)).ToList(); /// lambda expression to pull query based on user input for starting and ending year
            return personOfYear; /// return query
        }
    }
}
