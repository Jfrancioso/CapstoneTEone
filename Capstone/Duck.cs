using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Duck : StuffedAnimals
    {
        public string message { get; set; } = "Quack, Quack, Splash";


        public Duck(string species, string name, decimal price, string position) : base(species, name, price, position)
        {
            species = "Duck";

        }
    }
}
