using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Capstone
{
    class Menu
    {
        static void Main(string[] args)
        {
            Duck Yellow = new Duck("A1", "Yellow Duck", 0.90M, "Duck");
            Duck Cube = new Duck("A2", "Cube Duck", 2.50M, "Duck");
            Duck Beach = new Duck("A3", "Beach Duck", 1.50M, "Duck");
            Duck Bat = new Duck("A4", "Bat Duck", 2.00M, "Duck");

            Penguin Emperor = new Penguin("B1", "Emperor Penguin", 2.80M, "Penguin");
            Penguin Macaroni = new Penguin("B2", "Macaroni Penguin", 2.25M, "Penguin");
            Penguin Rockhopper = new Penguin("B3", "Rockhopper Penguin", 1.50M, "Penguin");
            Penguin Galapagos = new Penguin("B4", "Galapagos Penguin", 1.25M, "Penguin");

            Cat Black = new Cat("C1", "Black Cat", 2.25M, "Cat");
            Cat White = new Cat("C2", "White Cat", 2.50M, "Cat");
            Cat Tabby = new Cat("C3", "Tabby Cat", 2.50M, "Cat");
            Cat Calico = new Cat("C4", "Calico Cat", 3.55M, "Cat");

            Pony Unicorn = new Pony("D1", "Unicorn Pony", 1.95M, "Pony");

            Pony Pegasus = new Pony("D2", "Pegasus Pony", 1.85M, "Pony");

            Pony Horse = new Pony("D3", "Horse", 0.90M, "Pony");

            Pony Rainbow = new Pony("D4", "Rainbow Horse", 1.35M, "Pony");

            Dictionary<string, StuffedAnimals> stuffedAnimalsDictionary = new Dictionary<string, StuffedAnimals>();

            stuffedAnimalsDictionary["A1"] = Yellow;
            stuffedAnimalsDictionary["A2"] = Cube;
            stuffedAnimalsDictionary["A3"] = Beach;
            stuffedAnimalsDictionary["A4"] = Bat;

            stuffedAnimalsDictionary["B1"] = Emperor;
            stuffedAnimalsDictionary["B2"] = Macaroni;
            stuffedAnimalsDictionary["B3"] = Rockhopper;
            stuffedAnimalsDictionary["B4"] = Galapagos;

            stuffedAnimalsDictionary["C1"] = Black;
            stuffedAnimalsDictionary["C2"] = White;
            stuffedAnimalsDictionary["C3"] = Tabby;
            stuffedAnimalsDictionary["C4"] = Calico;

            stuffedAnimalsDictionary["D1"] = Unicorn;
            stuffedAnimalsDictionary["D2"] = Pegasus;
            stuffedAnimalsDictionary["D3"] = Horse;
            stuffedAnimalsDictionary["D4"] = Rainbow;




        }       
        }

}

