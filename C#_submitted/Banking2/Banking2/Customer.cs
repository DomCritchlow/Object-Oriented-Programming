using System;

namespace Banking2
{
	public class Customer
	{
			private string address;
			private bool chkAcc;
			private bool chkSav;
			private string name;
			private int pin;
			private string ssn;
			private bool status;
			private string tel;

			public Checking Check = new Checking();
			public Savings Sav = new Savings();


			public Customer ()
			{
				address ="Unknown";
				chkAcc = false;
				name = "Unknown";
				pin = 0;
				ssn = "Unknown";
				status = false;
				tel= "(000)-000-0000";
			}
			public Customer (string Name, string Address, string Ssn, string Tel){
				name = Name;
				address = Address;
				ssn = Ssn;
				tel = Tel;
				status = true;
			}

			public string SSN
			{	get {return ssn;}
			}
			public string Address
			{	get {return address;}
				set{address = value;}
			}
			public string Name
			{	get {return name;}
				set{name = value;}
			}
			public int Pin
			{	get {return pin;}
				set{pin = value;}
			}
			public bool Status
			{	get {return status;}
				set{status = value;}
			}
			public string Tel
			{	get {return tel;}
				set{tel = value;}
			}
			public bool ChkAcc
			{	get {return chkAcc;}
				set { chkAcc = value;}
			}
			public bool ChkSav
			{	get {return chkSav;}
				set { chkSav = value;}
			}


			public void create(string Name, string Address, string Ssn, string Tel){
				name = Name;
				address = Address;
				ssn = Ssn;
				tel = Tel;
				status = true;
				Console.Write("\nRecord has been created for {0}\n", Name);

			}

			public void delete(){

				address ="Unknown";
				chkAcc = false;
				name = "Unknown"; 
				pin = 0000;
				ssn = "Unknown";
				status = false;
				tel= "(000)-000-0000";

				Check.close ();
				Sav.close ();


				Console.Write ("\nWe deleted your records and your accounts\n");
			}

			public bool hasChkAcc(){

				return Check.Status;
			}

			public bool hasSavAcc(){

				return Sav.Status;
			}

			public void transfer(double amount, string option){


			Console.Write ("Checking Balance: ${0} ------- Savings Balance: ${1}\n",Check.Balance,Sav.Balance);
			if (option == "S") {

				if (Sav.Balance > amount) {

					Check.Balance = Check.Balance + amount;
					Sav.Balance = Sav.Balance - amount; 
				} else {

					Console.Write ("Funds are not available");
					return;
				}
			
			} else if (option == "C") {

				if (Check.Balance > amount) {
					Check.Balance = Check.Balance - amount;
					Sav.Balance = Sav.Balance + amount;
				}else {

					Console.Write ("Funds are not available");
					return;
				}

			} else {

				Console.Write("Not an option!!!\n");
				return;
			}

			Console.Write ("\nChecking Balance: ${0} ------- Savings Balance: ${1}\n",Check.Balance,Sav.Balance);
			}

			public void show(){
				Console.Write("{0}\n",name);
			}
			public bool getStatus(){
				return status;
			}
	}
}
