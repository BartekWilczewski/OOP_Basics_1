using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Employee : Person
    {
        private decimal Salary { get; set; }

        public Employee() 
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy Employee");
        }

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary) : base(firstName, lastName, yearOfBirth)
        {
            Salary = salary;
            Console.WriteLine("Wywołano konstruktor z parametrami Employee");
        }

        //public override string WhoAmI()
        //{
        //    return $"{base.WhoAmI()}. Earning {Salary}";
        //}

        public override string ToString()
        {
            return $"{base.ToString()}. Earning {GetSalary()} {IsAdult}";
        }

        public virtual decimal GetSalary()
        { return Salary; }

        private override bool IsAdult()
        { return true; }

    }
}
