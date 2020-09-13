using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public class Savings : Account
    {
        public Savings (Customer customer, string accountNumber) : base (customer, accountNumber)
        {

        }
        public override bool withdraw(double amount)
        {
            if (amount > 10 || amount > Balance)
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
