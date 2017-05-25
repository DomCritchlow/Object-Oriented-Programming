using System;

namespace Banking
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string choice = null;
			string choice2 = null;
			string choice3 = null;
			int maxAcount = 3;

			Customer [] Cust = new Customer[maxAcount];
			for (int i = 0; i < maxAcount; i++)
			{
				Cust[i] = new Customer();
			}

			do
			{

				Console.Write("\n[C]reate Customer [D]elete Customer dis[P]lay [S]ervices [Q]uite:  \n");
				choice = Console.ReadLine();
				choice = choice.ToUpper();
				string socialread ="";
				string Addr= "";
				string Tel ="";
				string Name =""; 
				int PIN;
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

					do{
						Console.Write("\n[C]hecking s[E]t PIN s[H]ow Accounts [R]eturn: \n");
						choice2 = Console.ReadLine();
						choice2 = choice2.ToUpper();

						switch (choice2)
						{


						case "C":

								if(Cust[serviceval].Pin == 0){
								Console.Write("\nSet a pin first\n");
									break;
								}

							Console.Write("\nPlease Enter PIN: \n");
								PIN = int.Parse(Console.ReadLine());
							
								do{
								Console.Write("\n[O]pen [C]lose [I]nquire [D]eposit [W]ithdraw [R]return\n");

								choice3 = Console.ReadLine();
								choice3 = choice3.ToUpper();

								switch (choice3){


								case "O":
									Console.Write("\nInitial Deposite: \n");
									double Balance = double.Parse(Console.ReadLine());

									Cust[serviceval].Check.open(Balance);
									continue;

								case "C":
									if(Cust[serviceval].Check.Status == false){
										Console.Write("\nNo Accounts open\n");
										break;
									}
									Cust[serviceval].Check.close();

									continue;
								case "I":
									if(Cust[serviceval].Check.Status == false){
										Console.Write("\nNo Accounts open\n");
										break;
									}

									Console.Write("\nAccount: {0}\nBalance:  {1}\n",Cust[serviceval].Check.Accnumber, Cust[serviceval].Check.Balance);


									continue;

								case "D":
									if(Cust[serviceval].Check.Status == false){
										Console.Write("\nNo Accounts open\n");
										break;
									}
									Console.Write("\nAccount: {0}\nEnter amount to deposite\n",Cust[serviceval].Check.Accnumber);
									double deposite = double.Parse(Console.ReadLine());

									Cust[serviceval].Check.deposit(deposite);
										 

									continue;

								case "W":
									if(Cust[serviceval].Check.Status == false){
										Console.Write("\nNo Accounts open\n");
										break;
									}
									Console.Write("\nAccount: {0}\nEnter amount to withdraw\n",Cust[serviceval].Check.Accnumber);
									double withdraw = double.Parse(Console.ReadLine());

									Cust[serviceval].Check.withdraw(withdraw);
									
									continue;
								}

							}while(choice3 !="R");
						
						
							continue;
						case "E":
							Console.Write("\nPlese enter a 4 digit pin: \n");
							PIN = int.Parse(Console.ReadLine());
							Cust[serviceval].Pin = PIN;

							continue;

						case "H":
							if(Cust[serviceval].Check.Status == false){
								Console.Write("\nNo Accounts open\n");
								continue;
							}
							Cust[serviceval].Check.show();

							continue;

						}
					}while(choice2 !="R");
					continue;

				default: break;

				}
			} while (choice != "Q");

			Console.Write("\nThank you for using this Bank, Goodbye!\n");

		}
	}
}
