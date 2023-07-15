using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee() 
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy Employee");
        }

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary) : base(firstName, lastName, yearOfBirth)
        {
            Salary = salary;
            Console.WriteLine("Wywołano konstruktor z parametrami Employee");
        }

        public string WhoAmIWithSalary()
        {
            return $"{WhoAmI()} Earning {Salary}";
        }

    }
}
