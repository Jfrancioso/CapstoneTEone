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
        public StuffedAnimals productSelected { get; set; }


        public decimal FeedMoney(int moneyAdded) { CurrentBalance += moneyAdded; return CurrentBalance; }
       
        public decimal FinishTransaction()
        {
            decimal changeToDispense = CurrentBalance - productSelected.Price;
            CurrentBalance = 0;
            return changeToDispense;


        }

    

    }
}
