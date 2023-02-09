using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class StuffedAnimals
    {
        public string Species { get; private set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Position { get; set; }

        public int CurrentStock { get; } = 5;

        public StuffedAnimals(string species, string name, decimal price, string position)
        {
            Species = species;
            Name = name;
            Price = price;
            Position = position;
            
        }
    }

}
