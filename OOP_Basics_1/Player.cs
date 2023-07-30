using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Player
    {
        public int Points { get; set; }
        public string Name { get; set; }

        public void PrintName() 
        {
        Display.Print(Name);
        }

        
    }
}
