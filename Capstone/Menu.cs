using System;
using System.Collections.Generic;
using System.IO;
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

            Purchase currentPurchase = new Purchase(0, DateTime.Now);
            //Creating main user interface


           

            

            while (true)
                {

                    Console.WriteLine("Welcome to the CuteCo Vendomatic800, where cuteness is our currency and you will leave with a new best friend! :)");
                Console.WriteLine();   
                Console.WriteLine("(1) To see what CrazyCuteCreatures we have in stock, select 1 for Display");
                    Console.WriteLine("(2) To bring your new bestie home, select 2 for Purchasing");
                    Console.WriteLine("(3) To leave all these sweeties behind and continue your drab existence alone, press 3 to Exit");

                    string userInputString = Console.ReadLine();


                    if (userInputString == "1") //Display selection
                    {

                        loadedVendingMachine.DisplayCurrentInventory(LoadedDictionary);
                    }
                    else if (userInputString == "2") // Purchase Flow
                    {

                        Console.WriteLine("Select 1 to add money");
                        Console.WriteLine("Select 2 to pick your pal");
                        Console.WriteLine("Select 3 to Finish transaction");
                        string userPurchaseSelection = Console.ReadLine();

                        if (userPurchaseSelection == "1") //FeedMoney function
                        {

                            Console.WriteLine("Money Money Money please. Cash rules everything around me, CREAM.");
                            Console.WriteLine("Please type how much money you are adding.");
                            string userMoneyInput = Console.ReadLine();
                            decimal userMoneyToAdd = decimal.Parse(userMoneyInput);
                            currentPurchase.UserMoney = userMoneyToAdd;
                            currentPurchase.FeedMoney(userMoneyToAdd);
                            Console.WriteLine($"Current Money Provided:{currentPurchase.CurrentBalance}");
                            Console.WriteLine();
                            currentPurchase.RecordFeedMoney(currentPurchase);

                           
                    }
                        else if (userPurchaseSelection == "2") //select product function
                        {
                            loadedVendingMachine.DisplayCurrentInventory(LoadedDictionary);

                            Console.WriteLine("Who are you taking home today?");//Insert SelectProduct function

                            string productSelectionInput = Console.ReadLine();

                            if (loadedVendingMachine.StuffedAnimalsDictionary.ContainsKey(productSelectionInput)) //checks that product exists
                            {
                                StuffedAnimals productSelected = loadedVendingMachine.StuffedAnimalsDictionary[productSelectionInput];
                                currentPurchase.ProductSelected = productSelected;
                                Console.WriteLine($"You have selected {productSelected.Name}");

                                if (productSelected.Price <= currentPurchase.CurrentBalance)
                                { 
                                loadedVendingMachine.DispenseProduct(productSelected, currentPurchase);
                                loadedVendingMachine.WriteMessage(productSelected);
                                Console.WriteLine(loadedVendingMachine.AnimalMessage);
                                currentPurchase.RecordTransaction(currentPurchase);
                           
                            }//dispense method, affects tock and current balance
                                else { Console.WriteLine("Please add more money to get selected product"); }
                            }
                            else
                            {
                                Console.WriteLine("You have entered an invalid product code");
                            }
                        }
                        else if (userPurchaseSelection == "3")
                    {
                        currentPurchase.ConvertChange(currentPurchase.CurrentBalance);




                    }

                            Console.WriteLine("Thank you for using CuteCo to brighten your day and bring meaning to your sad little life!");
                        // Insert FinishTransaction function

                    }

                    else if (userInputString == "3") // Exit button
                    { break; }
                    else { Console.WriteLine("Please enter a valid selection."); } // wrong input handling

                }















        }

    }
}


