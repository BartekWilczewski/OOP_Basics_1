using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Dog : Animal, IWeightable
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public int GetWeight()
        {
            throw new NotImplementedException();
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Dog {Name} age {Age} makes woof woof");
        }
    }
}
