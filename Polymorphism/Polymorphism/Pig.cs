﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }
    }
}
