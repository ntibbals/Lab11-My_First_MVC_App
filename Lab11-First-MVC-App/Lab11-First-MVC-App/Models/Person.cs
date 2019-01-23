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
            string path = "~/personOfTheYear.csv";
            string parsedResults = File.ReadAllText(path);
            var newObject = parsedResults;
            
            List<Person> parsedData = new List<Person>();
            foreach (string item in parsedResults.Split('\n'))
            {
                if (!string.IsNullOrEmpty(item))
                {
                    parsedData.Add(new Person
                    {
                        Year = Convert.ToInt32(item.Split(',')[0]),
                        Honor = item.Split(',')[1],
                        Name = item.Split(',')[2],
                        Country = item.Split(',')[3],
                        BirthYear = Convert.ToInt32(item.Split(',')[4]),
                        DeathYear = Convert.ToInt32(item.Split(',')[5]),
                        Title = item.Split(',')[6],
                        Category = item.Split(',')[7],
                        Context = item.Split(',')[8],
                    });
                }
            }
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
