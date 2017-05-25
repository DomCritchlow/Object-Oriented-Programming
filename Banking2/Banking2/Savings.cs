using System;

namespace Banking2
{


		public class Savings : Account
		{
			private double interestRate;
			private double maturebalance;


			public double InterestRate
			{	get {return interestRate;}
				set{ interestRate = value;}
			}
			public double MatureBalance
			{	get{return maturebalance;}
			}

			public Savings () 
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
			
			public override void open(double Balance){
				balance = Balance;
				Random rnd = new Random ();
				accnumber = rnd.Next (50000, 99999);

				Console.Write ("\nAccount {0} has been opened with ${1}\n", accnumber, balance);
				status = true;
			}
			public override void show(){
				maturebalance = balance + balance*interestRate;
				Console.Write("\n------------------------------" +
					"\nSavings Account Number:  {0}\nCurrent Balance:  ${1}" +
				"\n------------------------------\nMature Balance:  ${2}",accnumber,balance,maturebalance);

			}

	}
}

