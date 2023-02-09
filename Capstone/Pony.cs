using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Pony : StuffedAnimals
    {
        public string message { get; set; } = "Neigh, Neigh, Yay";


        public Pony(string species, string name, decimal price, string position) : base(species, name, price, position)
        {
            species = "Pony";

        }
    }
}
