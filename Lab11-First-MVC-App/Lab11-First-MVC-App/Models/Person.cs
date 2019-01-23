using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_First_MVC_App.Models
{
    public class Person
    {
        public int YearOne { get; set; }
        public int YearTwo { get; set; }

        public Person(int yearOne, int yearTwo)
        {
            YearOne = yearOne;
            YearTwo = yearTwo;
        }
    }
}
