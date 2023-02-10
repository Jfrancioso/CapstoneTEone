using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Capstone
{
    class Menu
    {
        static void Main(string[] args)
        {
            Dictionary<string, StuffedAnimals> testDictionary = new Dictionary<string, StuffedAnimals>();
            CuteCoVendingMachine loadedVendingMachine = new CuteCoVendingMachine(testDictionary);

           testDictionary = loadedVendingMachine.LoadInventory(testDictionary);
            
            foreach (KeyValuePair<string, StuffedAnimals> kvp in loadedVendingMachine.StuffedAnimalsDictionary)
            {
                Console.WriteLine(kvp.Key+ ": " + kvp.Value.Name);
            }
           

            



        }       
        }

}

