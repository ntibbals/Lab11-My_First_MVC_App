using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Lab11_First_MVC_App.Models
{
    public class Person
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

        public static List<Person> GetPersons(int yearOne, int yearTwo)
        {
            string path = "../../../wwwroot/personOfTheYear.csv";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            string[] parsedResults = File.ReadAllLines(fullPath);
            var newObject = parsedResults;
            
            List<Person> parsedData = new List<Person>();
            foreach (string item in parsedResults.Skip(1))
            {
                if (!string.IsNullOrEmpty(item))
                {
                    string[] column = item.Split(",");
                    parsedData.Add(new Person
                    {
                        Year =(column[0] == "") ? 0: Convert.ToInt32(column[0]),
                        Honor = column[1],
                        Name = column[2],
                        Country = column[3],
                        BirthYear = (column[4] == "") ? 0 : Convert.ToInt32(column[4]),
                        DeathYear = (column[5] == "") ? 0 : Convert.ToInt32(column[5]),
                        Title = item.Split(',')[6],
                        Category = item.Split(',')[7],
                        Context = item.Split(',')[8],
                    });
                }
            }
            var personOfYear = parsedData.Where(p => (p.Year >= yearOne) && (p.Year <= yearTwo)).ToList();
            /// read in file
            /// file.read all lines
            /// iterate through that array and set values appropriately to a new Person object
            /// CSV is comma delimated
            /// cerate a full list of peopels from the csv file
            /// then do the linq query(with Lambe
            /// people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
            /// people.Where(yearTwo > begyear & parsedData.All Year less than end year.ToList();)
            return personOfYear;
        }
    }
}
