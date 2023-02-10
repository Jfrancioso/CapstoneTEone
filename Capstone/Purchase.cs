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
        public DateTime DateTime { get; set; }
        
        public StuffedAnimals ProductSelected { get; set; } //needs to indicate a position set by the user, and reference a stuffedAnimal(hypothetically through a dictionary?)

        public Purchase(decimal currentBalance, DateTime dateTime)
        {
            CurrentBalance = currentBalance;
            DateTime = dateTime;
        }

        public decimal FeedMoney(decimal moneyAdded) 
        { CurrentBalance += moneyAdded; return CurrentBalance; } //function for user to add money
       
        public decimal FinishTransaction() //part of the purchase flow, that dispenses change, sets balance to 0, sends user to beginning of process
        {
            decimal changeToDispense = CurrentBalance - ProductSelected.Price;
            CurrentBalance = 0;
            return changeToDispense;


        }


        //public StuffedAnimals SelectProduct(string userInput) //the function that needs to take user input and connect it to a reference of a stuffedanimal
        //{
        //    StuffedAnimals productSelected = CuteCoVendingMachine.StuffedAnimalsDictionary.Value[userInput];
        //    return productSelected ;
        //}


    }
}
