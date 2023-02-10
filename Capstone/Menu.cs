using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Capstone
{
    class Menu
    {
        static void Main(string[] args)
        {

            //creating position/animal dictionary to reference for SelectProduct         
            Dictionary<string, StuffedAnimals> LoadedDictionary = new Dictionary<string, StuffedAnimals>();
            CuteCoVendingMachine loadedVendingMachine = new CuteCoVendingMachine(LoadedDictionary);

            LoadedDictionary = loadedVendingMachine.LoadInventory(loadedVendingMachine.StuffedAnimalsDictionary);

            foreach (KeyValuePair<string, StuffedAnimals> kvp in LoadedDictionary)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value.Name + " Price: " + kvp.Value.Price + " Current Stock: " + kvp.Value.CurrentStock);
            }

        }

    }
}

