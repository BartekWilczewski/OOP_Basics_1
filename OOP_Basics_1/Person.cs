using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Person
    {
        public string FirstName { get; init; } 
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public Direction Direction { get; set; }

        public virtual string WhoAmI()
        {
            return $"My name is {LastName}. {FirstName} {LastName}";
        }

        protected virtual bool IsAdult()
        {
            if(Direction == Direction.Left)
            {
                int dirAsInt = (int)Direction.Left;
            }
            return DateTime.Now.Year - YearOfBirth >= 18;
        }

        public Person() : this("Jan", "M", 1970)
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy Person");
        }

        protected Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Console.WriteLine("Wywołano konstruktor z parametrami Person");
        }

        public override string ToString()
        {
            return WhoAmI();
        }
    }
}
