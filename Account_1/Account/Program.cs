using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
             string choice = null;

             string AccName="" ;
             double Balance = 0;
             Checking Check1 = new Checking();
            do
            {

                Console.Write("[O]pen Account [I]nquire [D]eposit [W]ithdraw [Q]uit: ");
                choice = Console.ReadLine();
                choice = choice.ToUpper();

               


                switch (choice)
                {
                    case "O":
                            
                            Console.Write("Account holder: ");
                            AccName= Console.ReadLine();
                            Console.Write("Initial Deposite: ");
                            Balance = double.Parse(Console.ReadLine());
                            Console.Write("Account for {0} with Balance {1}\n", AccName,Balance);
                            Check1.setName(AccName);
                            Check1.setBalance(Balance);
                            continue;

                    case "I":
                        
                            Console.Write("Account: {0}\nBalance: {1}\n",Check1.getName(),Check1.getBalance());
                            continue;

                    case "D":
                            
                            Console.Write("Account: {0}\n Deposite: ",Check1.getName());
                            double Deposit = double.Parse(Console.ReadLine()) ;
                            Balance = Balance + Deposit;
                            Console.Write("Balance: {0}\n", Balance);
                            Check1.setBalance(Balance);
                            continue;

                    case "W":
                            
                            Console.Write("Account: {0}\n Withdraw: ", AccName);
                            double Withdraw = double.Parse(Console.ReadLine());
                            Balance = Balance - Withdraw;
                            Console.Write("Balance: {0}\n", Balance);
                            Check1.setBalance(Balance);
                        continue;


                    default: break;
                }
            } while (choice != "Q");



        }
    }
   public class Checking
    {
        public string mAccName;
        public double mBalance;
        public Checking()
        {
            mAccName = "Unknown";
            mBalance = 0;
        }

        public void setName(string AccName)
        {
            mAccName = AccName;
        }
        public void setBalance(double Balance)
        {
            mBalance = Balance;
        }
        public string getName()
        {
            return mAccName;
        }
        public double getBalance()
        {
            return mBalance;
        }

    }
        } 