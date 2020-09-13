using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public abstract class Account
    {
        Customer customer;
        string accountNumber;
        double balance;

        public Account(Customer customer, string accountNumber)
        {
            this.customer = customer;
            this.accountNumber = accountNumber;
            balance = 0;
        }

        public Customer Customer
        {
            get
            {
                return customer;
            }
        }
        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            protected set
            {
                balance = value;
            }
        }

        public void deposit(double amount)
        {
            balance += amount;
        }

        public abstract bool withdraw(double amount);
    }

}
