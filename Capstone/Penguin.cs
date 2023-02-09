using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Penguin : StuffedAnimals
    {
        public string message { get; set; } = "Squawk, Squawk, Whee";


        public Penguin(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }


        public Penguin Emperor = new Penguin("B1", "Emperor Penguin", 2.80M, "Penguin");         
        public Penguin Macaroni = new Penguin("B2", "Macaroni Penguin", 2.25M, "Penguin");
        public Penguin Rockhopper = new Penguin("B3", "Rockhopper Penguin", 1.50M, "Penguin");
        public Penguin Galapagos = new Penguin("B4", "Galapagos Penguin", 1.25M, "Penguin");

        
               
    }
    
   
}
