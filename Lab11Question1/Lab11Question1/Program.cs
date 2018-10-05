// console application
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Lab11Question1
{
   
class Program
    {
        static void Main(string[] args)
        {
            CreditCard c = new CreditCard(10000);
          
            Console.WriteLine("Please enter the amount for making payment :");
            int amount = Convert.ToInt32(Console.ReadLine());

            string message = "";
           
                if (c.Balance > amount)
                {
                    c.MakePayment(amount);
                    message = "After deducting : " + amount + ", remaining balance is : " + c.Balance;
                }
                else
                {
                    message = "You are trying to withdraw greater amount than your balance";
                }
            

            c.MakePayment(amount);
            c.Notify(message);
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
