using System;

namespace Banking2
{
	public abstract class Account
	{



		protected double balance;
		protected int accnumber;
		protected bool status;


		public Account() 
		{
			balance = 0;
			accnumber = 000000;
			status = false;
		}


		public double Balance
		{	get {return balance;}
			set { balance = value; }
		}
		public int Accnumber
		{	get {return accnumber;}
		}
		public bool Status
		{	get {return status;}
			set { status = value;}
		}


		public abstract void close();
			

		public abstract void open(double Balance);
		virtual public void show(){
			Console.Write("\nAccounts: \n");

		}

	}
}

