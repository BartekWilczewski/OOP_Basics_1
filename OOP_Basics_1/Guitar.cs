﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics_1
{
    internal class Guitar : ISoundMaker
    {
        public void MakeSound()
        {
            Console.WriteLine($"Guitar makes brzdęk brzdęk");
        }
    }
}
