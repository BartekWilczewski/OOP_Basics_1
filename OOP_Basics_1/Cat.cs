using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Basics_1
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public int GetWeight()
        {
            return 0;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Cat {Name} age {Age} makes miau");
        }

        void X()
        {

        }
    }
}
