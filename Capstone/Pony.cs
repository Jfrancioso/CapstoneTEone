using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Pony : StuffedAnimals
    {
        public string message { get; set; } = "Neigh, Neigh, Yay";


        public Pony(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }

        public Pony Unicorn = new Pony("D1", "Unicorn Pony", 1.95M, "Pony");

        public Pony Pegasus = new Pony("D2", "Pegasus Pony", 1.85M, "Pony");

        public Pony Horse = new Pony("D3", "Horse", 0.90M, "Pony");

        public Pony Rainbow = new Pony("D4", "Rainbow Horse", 1.35M, "Pony");

        
    }
}
