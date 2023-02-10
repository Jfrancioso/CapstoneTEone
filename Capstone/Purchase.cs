using Capstone;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Capstone
{
    public class Purchase
    {

        public decimal CurrentBalance { get; set; } 
        public string DateTime { get; set; }
        public StuffedAnimals productSelected { get; set; } //needs to indicate a position set by the user, and reference a stuffedAnimal(hypothetically through a dictionary?)


        public decimal FeedMoney(int moneyAdded) { CurrentBalance += moneyAdded; return CurrentBalance; } //function for user to add money
       
        public decimal FinishTransaction() //part of the purchase flow, that dispenses change, sets balance to 0, sends user to beginning of process
        {
            decimal changeToDispense = CurrentBalance - productSelected.Price;
            CurrentBalance = 0;
            return changeToDispense;


        }


       /* public StuffedAnimals SelectProduct(string userInput) //the function that needs to take user input and connect it to a reference of a stuffedanimal
        {
            return stuffedAnimalDictionary[userInput];
        }*/


    }
}
