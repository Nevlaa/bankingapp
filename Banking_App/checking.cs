﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public class Checking : Account
    {
        public Checking (Customer customer, string accountNumber) : base (customer, accountNumber)
        {

        }
        public override bool withdraw(double amount)
        {
          
            if (amount > Balance)
            {
                return false;
            }
            else
            {
                Balance = Balance - amount;
                return true;
            }

        }
    }
}
