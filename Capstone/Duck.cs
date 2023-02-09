using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Duck : StuffedAnimals
    {
        public string message { get; set; } = "Quack, Quack, Splash";


        public Duck(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }

        public Duck Yellow = new Duck("A1", "Yellow Duck", 0.90M, "Duck");
        public Duck Cube = new Duck("A2", "Cube Duck", 2.50M, "Duck");
        public Duck Beach = new Duck("A3", "Beach Duck", 1.50M, "Duck");
        public Duck Bat = new Duck("A4", "Bat Duck", 2.00M, "Duck");
    }
}
