using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Dog : Animal, IWeightable, ISoundMaker
    {
        public Dog(string name) : base(name)
        {
        }

        public int GetWeight()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            Console.WriteLine($"Dog {Name} makes woof woof");
        }
    }
}
