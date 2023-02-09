using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Penguin : StuffedAnimals
    {
        public string message { get; set; } = "Squawk, Squawk, Whee";


        public Penguin(string species, string name, decimal price, string position) : base(species, name, price, position)
        {
            species = "Penguin";

        }
    }
}
