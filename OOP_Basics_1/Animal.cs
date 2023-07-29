using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal abstract class Animal : SoundMaker
    {
        public readonly string Name;


        public Animal(string name)
        {
            Name = name;
        }
    }
}
