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
			int maxAcount = 3;
			string AccName="" ;
			double Balance = 0;
			Checking [] Check = new Checking [maxAcount];
			for (int i = 0; i < maxAcount; i++)
			{
				Check[i] = new Checking();
			}

			do
			{

				Console.Write("[O]pen Account [C]lose s[H]ow Accounts [S]ervices [Q]uit: \n");
				choice = Console.ReadLine();
				choice = choice.ToUpper();

				switch (choice)
				{
				case "O":
					bool pinUse=false;
					Console.Write("Account holder: \n");
					AccName= Console.ReadLine();
					Console.Write("Enter 4 digit Account code: \n");
					int Pin = int.Parse(Console.ReadLine());

				

					for (int i = 0; i < maxAcount; i++)
					{
						if (Check[i].getPin() == Pin)
						{
							Console.Write("Pin already in use\n");
							pinUse = true;
							break;
						}

					}
					if(pinUse == true)
					{
						continue;
					}
					Console.Write("Initial Deposite: \n");
					Balance = double.Parse(Console.ReadLine());
					Console.Write("Account for {0} with Balance {1}\n", AccName,Balance);
					int Checknumber= maxAcount+1  ;
					for (int i= 0; i<maxAcount;i++)
					{
						if(Check[i].getStatus()== false){
							Checknumber = i;
						}

					}
					if (Checknumber == maxAcount + 1)
					{
						Console.Write("No more Accounts available\n");
						break;
					}

					Check[Checknumber].open(AccName,Pin,Balance);

					continue;

				case "C":
					int closepin= maxAcount;
					Console.Write("Enter Pin: \n");
					int pin = int.Parse(Console.ReadLine());
					for (int i = 0; i < maxAcount; i++)
					{
						if (Check[i].getPin() == pin)
						{
							closepin = i;
						}

					}

					if (closepin == maxAcount)
					{
						Console.Write("Account not available to close\n");
						continue;
					}

					Check[closepin].close(pin);

					continue;

				case "H":

					Console.Write("Active Accounts: \n");
					for (int i = 0; i < maxAcount; i++)
					{
						Check[i].show();
					}

					continue;

				case "S":
					Console.Write("[I]nquire  [D]eposit  [W]ithdraw  [R]eturn\n");
					string choice2 = Console.ReadLine();
					choice2 = choice2.ToUpper();

					switch (choice2)
					{


					case "I":
						Console.Write("Enter Account Pin: \n");
						int pinInquire = int.Parse(Console.ReadLine());
						int loopInquire=0;
						for (; loopInquire < maxAcount; loopInquire++)
						{
							if (Check[loopInquire].getPin() == pinInquire)
							{
								break;
							}
						}
						Console.Write("Account: {0}\nBalance: {1}\n", Check[loopInquire].getName(), Check[loopInquire].getBalance());
						continue;

					case "D":

						Console.Write("Enter Pin: \n");
						int pinDeposite = int.Parse(Console.ReadLine());
						int loopDeposite=0;
						for (; loopDeposite < maxAcount; loopDeposite++)
						{
							if (Check[loopDeposite].getPin() == pinDeposite)
							{
								break;
							}
						}
						Console.Write("Account: {0}\n Deposite: \n", Check[loopDeposite].getName());
						Check[loopDeposite].deposit(double.Parse(Console.ReadLine()));
						Console.Write("Balance: {0}\n", Check[loopDeposite].getBalance());

						continue;

					case "W":

						Console.Write("Enter Pin: \n");

						int pinWithdraw = int.Parse(Console.ReadLine());
						int loopWithdraw=0;
						for (; loopWithdraw < maxAcount;  loopWithdraw++)
						{
							if (Check[loopWithdraw].getPin() == pinWithdraw)
							{
								break;
							}
						}
						if (loopWithdraw == maxAcount)
						{
							Console.Write("Not a valid Pin\n");
							continue;
						}
						Console.Write("Account: {0}\n Withdraw: \n", Check[loopWithdraw].getName());
						Check[loopWithdraw].withdraw(double.Parse(Console.ReadLine()));
						Console.Write("Balance: {0}\n", Check[loopWithdraw].getBalance());
						continue;
					}
					continue;

				default: break;
				}
			} while (choice != "Q");



		}
	}
	public class Checking
	{
		private string mAccName;
		private double mBalance;
		private int mPinNum;
		private bool mStatus;


		public Checking()
		{
			mAccName = "Unknown";
			mBalance = 0;
			mPinNum= 0000;
			mStatus = false;
		}


		public void open(string AccName, int Pin, double IBalance)
		{
			mAccName = AccName;
			mPinNum = Pin;
			mBalance = IBalance;
			mStatus = true;

		}
		public string getName()
		{
			return mAccName;
		}
		public double getBalance()
		{
			return mBalance;
		}
		public void deposit(double deposit)
		{
			mBalance = mBalance +deposit; 
		}
		public void withdraw(double withdraw)
		{
			if (mBalance - withdraw < 0)
			{
				Console.Write("You don't have that much money\n");
			}
			else
			{
				mBalance = mBalance - withdraw;
			}
		}
		public void close(int pin)
		{
			if (pin == mPinNum)
			{
				mStatus = false ;
				mPinNum = 0000  ;
				mAccName = "Unkown" ;
				mBalance = 0 ;
				Console.Write("Account has been closed.\n");
			}

		}
		public int getPin()
		{
			return mPinNum;
		}
		public bool getStatus()
		{
			return mStatus;
		}

		public void show(){
			if (mStatus == true)
			{
				Console.Write("Account: {0}\n", mAccName);  
			}

		}





	}
} 