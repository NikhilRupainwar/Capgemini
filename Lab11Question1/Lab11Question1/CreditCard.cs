//class 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question1
{
     public delegate void CreditCardDelegate(string message);

    public class CreditCard
    {
        public event CreditCardDelegate CredEvent;

        public int Balance { get; set; }

        // parameterised constructor
        public CreditCard(int balance)
        {
            Balance = balance;
        }

        public int GetBalance(int balance)
        {
            Balance = balance;
            return balance;
        }

        public int CreditLimit { get; set; }

        public int GetCreditLimit(int creditlimit)
        {
            CreditLimit = creditlimit;
            return creditlimit;
        }

        public void MakePayment(int amount)
        {
            string message = "";
           
                if (Balance > amount)
                {
                    Balance = Balance - amount;
                    message = "After deducting payment " + amount + "remaining balance is " + Balance;
                }
                else
                {
                    message = "You are trying to pay greater amount than your balance";
                }
            
        }

        public void Notify(string message)
        {
            if (CredEvent != null)
                CredEvent(message);
        }
    }
}
