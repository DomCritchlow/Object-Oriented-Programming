using System;

namespace Banking2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string choice = null;
			double SaveInt = 0;

			int maxAcount = 3;

			Customer [] Cust = new Customer[maxAcount];
			for (int i = 0; i < maxAcount; i++)
			{
				Cust[i] = new Customer();
			}

			do
			{

				Console.Write("\n[C]reate Customer   [D]elete Customer   dis[P]lay   s[E]t Rate  [S]ervices   [Q]uite:  \n");
				choice = Console.ReadLine();
				choice = choice.ToUpper();
				string socialread ="";
				string Addr= "";
				string Tel ="";
				string Name =""; 

				switch (choice)
				{
				case "C":
					Console.Write("\nSocial Security Number: \n");
					socialread= Console.ReadLine();

					Console.Write("\nName: \n");
					Name= Console.ReadLine();

					Console.Write("\nAddress: \n");
					Addr= Console.ReadLine();

					Console.Write("\nTelephone Number: \n");
					Tel= Console.ReadLine();

					int CustomerAvail = maxAcount+1;
					for (int i= 0; i<maxAcount;i++)
					{
						if(Cust[i].getStatus()== false){
							CustomerAvail = i;
						}
					}
					if (CustomerAvail == maxAcount + 1)
					{
						Console.Write("\nNo more Accounts available\n");
						break;
					}

					Cust[CustomerAvail].create(Name,Addr,socialread,Tel);


					continue;
				case "D":

					Console.Write("\nEnter Social Security number of Account holder to close Account: \n");
					string Social = Console.ReadLine();

					int SocialVal = maxAcount+1;

					for (int i= 0; i<maxAcount;i++)
					{
						if(Cust[i].SSN == Social){
							SocialVal = i;
						}
					}
					if (SocialVal == maxAcount+1){
						Console.Write("\nThis is not your account\n");
						break;
					}
					Cust[SocialVal].delete();

					continue;

				case "P":

					Console.Write("\nActive Users:  \n");
					int j=0;
					for (int i= 0; i<maxAcount;i++)
					{
						if(Cust[i].getStatus()==true){
							Cust[i].show();
							j++;
						}
					}
					if(j==0){
						Console.Write("\nNo Accounts open!\n");
						continue;
					}
					Console.Write("Current Savings Account interest: {0} ", Cust[j].Sav.InterestRate );

					continue;

				case "E":
					Console.Write("Set Interest Rate for Saving Accounts: \n");
					SaveInt = double.Parse(Console.ReadLine());
					if (SaveInt > 1.0 || SaveInt < 0.0){
						Console.Write("Not a valid interest rate!");
						continue;
					}

					for (int i= 0; i<maxAcount;i++)
					{
						Cust[i].Sav.InterestRate = SaveInt;
					}

					continue;


				case "S":

					Console.Write("\nPlease enter social security number: \n");
					socialread = Console.ReadLine();
					int serviceval= maxAcount+1;
					for (int i= 0; i<maxAcount;i++)
					{
						if(Cust[i].SSN==socialread){
							serviceval =i;
						}
					}
					if (serviceval== maxAcount+1){
						Console.Write("\nSocial Does Not Match\n");
						break;
					}

					Custmenu(Cust[serviceval]);
					continue;

				default: break;

				}
			} while (choice != "Q");

			Console.Write("\nThank you for using this Bank, Goodbye!\n");

		}


		static void Custmenu(Customer Cust){
			int PIN;
			string choice2 = null;
			do{
				Console.Write("\n[C]hecking [S]avings s[E]t PIN s[H]ow Accounts [T]ransfer [R]eturn: \n");
				choice2 = Console.ReadLine();
				choice2 = choice2.ToUpper();

				switch (choice2)
				{


				case "C":

					if(Cust.Pin == 0){
						Console.Write("\nSet a pin first\n");
						break;
					}

					Console.Write("\nPlease Enter PIN: \n");
					PIN = int.Parse(Console.ReadLine());

					if (PIN != Cust.Pin){

						Console.Write("Pin does not match!");

						continue;
					}

					Checkmenu(Cust);

					continue;
				case "E":
					Console.Write("\nPlese enter a 4 digit pin: \n");
					PIN = int.Parse(Console.ReadLine());
					Cust.Pin = PIN;

					continue;

				case "H":
					if(Cust.Check.Status == false && Cust.Sav.Status == false){
						Console.Write("\nNo Accounts open\n");
						continue;
					}
					Cust.Check.show();
					Console.Write("\n");
					Cust.Sav.show();

					continue;

				case "S":
					

					Console.Write("\nPlease Enter PIN: \n");
					PIN = int.Parse(Console.ReadLine());
					if (PIN != Cust.Pin){

						Console.Write("Pin does not match!");

						continue;
					}

					Savemenu(Cust);


					continue;

				case "T":

					Console.Write("\nPlease Enter PIN: \n");
					PIN = int.Parse(Console.ReadLine());
					if (PIN != Cust.Pin){

						Console.Write("Pin does not match!");

						continue;
					}

					string choice4 = null;

					Console.Write("[S]avings to Checking  [C]hecking to Savings");
					choice4 = Console.ReadLine();
					choice4 = choice4.ToUpper();

					Console.Write("Enter amount: ");
					double amount = double.Parse(Console.ReadLine());

					Cust.transfer(amount, choice4);
				
					Console.Write("Transferring !!!");


					continue;

				}
			}while(choice2 !="R");



		}

	


		static void Checkmenu(Customer Cust){
			string choice3 = null;
			do{
				Console.Write("\n[O]pen [C]lose [I]nquire [D]eposit [W]ithdraw  WriteCh[K]  OrderC[H]k [R]return\n");

				 choice3 = Console.ReadLine();
				choice3 = choice3.ToUpper();

				switch (choice3){


				case "O":
					Console.Write("\nInitial Deposite: \n");
					double Balance = double.Parse(Console.ReadLine());

					Cust.Check.open(Balance);
					continue;

				case "C":
					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
					Cust.Check.close();

					continue;
				

				case "I":
					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
					Cust.Check.show();


					continue;

				case "D":
					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
					Console.Write("\nAccount: {0}\nEnter amount to deposite\n",Cust.Check.Accnumber);
					double deposite = double.Parse(Console.ReadLine());

					Cust.Check.deposit(deposite);


					continue;

				case "W":
					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
					Console.Write("\nAccount: {0}\nEnter amount to withdraw\n",Cust.Check.Accnumber);
					double withdraw = double.Parse(Console.ReadLine());

					Cust.Check.withdraw(withdraw);

					continue;



				case "K":

					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
					if(Cust.Check.NbrChecks <1){
						Console.Write("\nNot enough Checks. Order more Checks\n");
						break;
					}
					double CheckAmount;
					Console.Write("Write Check: ");
					CheckAmount = double.Parse(Console.ReadLine());
					Cust.Check.withdraw(CheckAmount);
					Cust.Check.NbrChecks = Cust.Check.NbrChecks - 1 ; 
					Console.Write("Balance: {0}\n Number of Checks left: {1}", Cust.Check.Balance,Cust.Check.NbrChecks);


					continue;

				case "H":
					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
						
					Console.Write("Enter number of checks you would like to order: \n");

					Cust.Check.NbrChecks = Cust.Check.NbrChecks + int.Parse(Console.ReadLine());



					continue;


				}

			}while(choice3 !="R");

		}




		static void Savemenu(Customer Cust){
			string choice3 = null;
			do{
				Console.Write("\n[O]pen [C]lose [I]nquire [R]return\n");

				choice3 = Console.ReadLine();
				choice3 = choice3.ToUpper();

				switch (choice3){


				case "O":
					Console.Write("\nInitial Deposite: \n");
					double Balance = double.Parse(Console.ReadLine());

					Cust.Sav.open(Balance);
					continue;

				case "C":
					if(Cust.Check.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}
					Cust.Sav.close();

					continue;


				case "I":
					if(Cust.Sav.Status == false){
						Console.Write("\nNo Accounts open\n");
						break;
					}

					Cust.Sav.show();

					continue;

				}

			}while(choice3 !="R");

		}




	}
}
