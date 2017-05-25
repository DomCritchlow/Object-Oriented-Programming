using System;

namespace Banking2
{
	public class Checking : Account
	{
		int nbrChecks = 0 ;


		public int NbrChecks
		{	get {return nbrChecks;}
			set{ nbrChecks = value;}
		}

		public Checking () 
		{
			balance = 0;
			accnumber = 000000;
			status = false;
		}


		public override void close(){
			accnumber = 0000000;
			status = false;
			Console.Write ("\nChecking account has been closed with amount: {0}\n",balance);
			balance = 0;
		}
		public void deposit(double money){
			balance += money;
			Console.Write ("\nDeposited ${0} to Account\nCurrent Balance = ${1}\n", money,balance);

		}
		public override void open(double Balance){
			balance = Balance;
			Random rnd = new Random ();
			accnumber = rnd.Next (10000, 49999);

			Console.Write ("\nAccount {0} has been opened with ${1}\n", accnumber, balance);
			status = true;
		}
		public override void show(){
			Console.Write("\n------------------------------" +
				"\nChecking Account Number:  {0}\nCurrent Balance:  ${1}" +
				"\n------------------------------\n",accnumber,balance);

		}
		public void withdraw(double money){
			if (balance >= money) {
				balance -= money;
				Console.Write ("\nWithdrew ${0} from Account\nCurrent Balance = ${1}\n", money,balance);
			} else {
				Console.Write ("\nYou don't have that kind of money\n");
			}

		}


	}
}

