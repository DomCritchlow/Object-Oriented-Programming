// Jiang Li
// CSCI 3005 Assignment 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class Program
    {
        public static void Main()
        {
            string name = null;
            double balance = 0.0;
            double money = 0.0;
            string choice = null;
            Checking chk = new Checking();
     
            do
            {
                Console.Write("[O]pen Account     [I]nquire     [D]eposit     [W]ithdraw     [Q]uit: ");
                choice = Console.ReadLine();
                choice = choice.ToUpper();

                switch (choice)
                {
                    case "O": // open an account
                        Console.Write("Account in name of: ");
                        name = Console.ReadLine();

                        Console.Write("Initial Deposit: ");
                        balance = double.Parse(Console.ReadLine());
                            
                        chk.Open(name, balance);

                        Console.WriteLine("The account has been opened for {0}, Balance: ${1}\n", name, balance);
                        break;

                    case "I": // inquire
                        Console.WriteLine("{0}'s Account", chk.GetName());
                        Console.WriteLine("Balance: ${0}", chk.GetBalance());
                        break;

                    case "D": // deposit
                        Console.WriteLine("{0}'s Account", chk.GetName());
                        Console.Write("Deposit: ");
                        money = double.Parse(Console.ReadLine());
                        chk.Deposit(money);
                        Console.WriteLine("Balance: ${0}", chk.GetBalance());
                        break;

                    case "W": // withdraw
                        Console.WriteLine("{0}'s Account", chk.GetName());
                        Console.Write("Withdraw: ");
                        money = double.Parse(Console.ReadLine());
                        if (money > chk.GetBalance())
                            Console.WriteLine("Error: ${0} exceeds balance: ${1}", money, balance);
                        else
                        {
                            chk.Withdraw(money);
                            Console.WriteLine("Balance: ${0}", chk.GetBalance());
                        }
                        break;

                    case "Q":
                        Console.Write("Thank you, bye!");
                        Console.ReadLine();
                        return;

                    default: break;
                }
            } while (choice != "Q");
        }

    }

    class Checking
    {
        private string name;
        private double balance;

        public Checking() 
        { 
            name = null;
            balance = 0.0;
        }
        
        public void Open(string aName, double dBalance)
        {
            name = aName;
            balance = dBalance;
        }

        public string GetName() { return name; }

        public double GetBalance() { return balance; }

        public void Deposit(double inMoney) { balance += inMoney; }

        public void Withdraw(double outMoney) { balance -= outMoney; }

    }
}
