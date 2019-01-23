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
            string path = "../personOfTheYear.csv";
            string[] parsedResults = File.ReadAllLines(path);

            List<Person> parsedData = new List<Person>();

            /// read in file
            /// file.read all lines
            /// iterate through that array and set values appropriately to a new Person object
            /// CSV is comma delimated
            /// cerate a full list of peopels from the csv file
            /// then do the linq query(with Lambe
            /// people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();
            ///people.Where(yearTwo > begyear & parsedData.All Year less than end year.ToList();)
            return parsedData;
        }
    }
}
