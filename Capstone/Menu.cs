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


            //Creating main user interface

            while (true)
            {

                Console.WriteLine("Welcome to the CuteCo Vendomatic800, where cuteness is our currency and you will leave with a new best friend! :)");
                Console.WriteLine("To see what CrazyCuteCreatures we have in stock, select 1 for Display");
                Console.WriteLine("To bring your new bestie home, select 2 for Purchasing");
                Console.WriteLine("To leave all these sweeties behind and continue your drab existence alone, press 3 to Exit");

                string userInputString = Console.ReadLine();


                if (userInputString == "1") //Display selection
                {
                    foreach (KeyValuePair<string, StuffedAnimals> kvp in LoadedDictionary) 
                    {
                        Console.WriteLine(kvp.Key + ": " + kvp.Value.Name + " Price: " + kvp.Value.Price + " Current Stock: " + kvp.Value.CurrentStock);
                    }
                }
                else if (userInputString == "2") // Purchase Flow
                {
                    
                    Console.WriteLine("Select 1 to add money");
                    Console.WriteLine("Select 2 to pick your pal");
                    Console.WriteLine("Select 3 to Finish transaction");
                    string userPurchaseSelection = Console.ReadLine();

                    if (userPurchaseSelection == "1")
                    {
                        Console.WriteLine("Money Money Money please. Cash rules everything around me, CREAM.");
                        Console.WriteLine("Please type how much money you are adding.");
                        string userMoneyInput = Console.ReadLine();
                        int userMoneyToAdd = int.Parse(userMoneyInput);
                        Console.WriteLine("Current Money Provided:");
                         
                        
                        
                    }
                    else if (userPurchaseSelection == "2")
                    {
                        Console.WriteLine("Who are you taking home today?");
                        //Insert SelectProduct function
                        break;
                    }
                    else if (userPurchaseSelection == "3")
                    {
                        Console.WriteLine("Thank you for using CuteCo to brighten your day and bring meaning to your sad little life!");
                        // Insert FinishTransaction function

                    }
                }
                else if (userInputString == "3") // Exit button
                { break; }
                else { Console.WriteLine("Please enter a valid selection."); } // wrong input handling

            }















        }

    }
}


