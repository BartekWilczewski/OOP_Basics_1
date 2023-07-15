﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public string WhoAmI()
        {
            return $"My name is {LastName}. {FirstName} {LastName}";
        }

        public bool IsAdult()
        {
            return DateTime.Now.Year - YearOfBirth >= 18;
        }

        public Person() : this("Jan", "M", 1970)
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy Person");
        }

        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Console.WriteLine("Wywołano konstruktor z parametrami Person");
        }
    }
}
