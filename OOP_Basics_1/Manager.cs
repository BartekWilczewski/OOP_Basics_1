using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, int yearOfBirth, decimal salary) :
            base(firstName, lastName, yearOfBirth, salary)
        {
            
        }

        //public override decimal GetSalary()
        //{
        //    return Salary * 1.1m;
        //}
    }
}
