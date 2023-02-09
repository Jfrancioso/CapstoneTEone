using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Cat : StuffedAnimals
    {
        public string message { get; set; } = "Meow, Meow, Meow";
    
    
        public Cat(string species, string name, decimal price, string position) :base(species, name, price, position)
        {
            species = "Cat";
        }
    }
}
