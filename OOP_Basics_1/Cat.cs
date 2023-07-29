using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Basics_1
{
    internal class Cat : Animal, ISoundMaker
    {
        public Cat(string name) : base(name)
        {
        }

        public int GetWeight()
        {
            return 0;
        }

        public void MakeSound()
        {
            Console.WriteLine($"Cat {Name} makes miau");
        }

        void X()
        {

        }
    }
}
