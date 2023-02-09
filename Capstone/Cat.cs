using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Capstone
{
    public class Cat : StuffedAnimals
    {
        public string message { get; set; } = "Meow, Meow, Meow";
    
    
        public Cat(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }

        public Cat Black = new Cat("C1", "Black Cat", 2.25M, "Cat");
        public Cat White = new Cat("C2", "White Cat", 2.50M, "Cat");
        public Cat Tabby = new Cat("C3", "Tabby Cat", 2.50M, "Cat");
        public Cat Calico = new Cat("C4", "Calico Cat", 3.55M, "Cat");
    }
}
