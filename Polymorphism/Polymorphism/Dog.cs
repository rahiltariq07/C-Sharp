using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says : Bow Wow");
        }
    }
}
