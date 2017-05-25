using System;
using System.Collections.Generic;

namespace CarProject
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			string choice = null;

			List<Sedan> sedanlist = new List<Sedan> ();

			do {

				Console.Write ("The AutoLot Console UI\n\nI: Insert a new Sedan.\nU: Update car pet name.\nD: Deletes an existing sedan.\nL: Lists current inventory.\nQ: Quits program.\n\n");
				Console.Write ("Please enter your choice: ");

				choice = Console.ReadLine();
				choice = choice.ToUpper();
				Console.Write("\n");


				switch (choice)
				{
				case "I":

					InsertNewCar(sedanlist);

					continue;

				case "U":
					int PetCarID;
					Console.Write("\nEnter Car ID:\n");
					PetCarID= int.Parse(Console.ReadLine());

					Console.Write("\nEnter Updated Pet Name:\n");
					string newpetname= Console.ReadLine();

					foreach(Sedan s in sedanlist){
						if( s.CarID == PetCarID){
							s.Petname = newpetname;
							Console.Write("Petname has been updated to {0}", s.Petname);
							break;
						}

					}

						


					continue;

				case "D":
					int deleteID;
					Console.Write("\nEnter Car ID:\n");
					deleteID= int.Parse(Console.ReadLine());


					sedanlist.RemoveAll( x => x.CarID == deleteID);


					continue;

				case "L":

					Console.Write("\n----------Inventory of Cars----------\n");


					foreach (Sedan asedan in sedanlist){
						Console.Write("\n----------Information about Car----------\n");
						Console.Write(" Car ID: {0}\n Color: {1}\n PetName: {2}\n Model: {3}\n Base Price: {4}\n",
							asedan.CarID,asedan.Color,asedan.Petname,asedan.Model,asedan.BasePrice);
						if ( asedan.pkg.status == true){
							Console.Write("--------Package Information------------\n Package Description: {0}\n Package Type: {1}\n Package Price: ${2}\nTotal Price: {3}\n",asedan.pkg.Description,asedan.pkg.Type,asedan.pkg.Price, asedan.BasePrice + asedan.pkg.Price);
						}
					}
					Console.ReadLine();

					continue;

				default: break;
				}


			} while (choice != "Q");

			Console.Write ("Thanks! Bye");

		}


		static void InsertNewCar(List<Sedan> newcar){

			int CarIDfun;
			string Makefun;
			string Colorfun;
			string Petnamefun;
			string Modelfun;
			double BasePricefun;
			double packageprice;
			string packagedescription;
			string packagetype; 



			Console.Write("Input Basic Car Information\n");

			Console.Write(" Car ID: ");
			CarIDfun = int.Parse(Console.ReadLine());

			Console.Write(" Make: ");
			Makefun = Console.ReadLine ();


			Console.Write(" Color: ");
			Colorfun = Console.ReadLine();

			Console.Write(" Petname: ");
			Petnamefun = Console.ReadLine();

			Console.Write(" Model: ");
			Modelfun = Console.ReadLine();

			Console.Write(" Base Price: ");
			BasePricefun = double.Parse(Console.ReadLine());

			newcar.Add (new Sedan () {Make= Makefun,CarID = CarIDfun,Color = Colorfun,
				Petname=Petnamefun,Model =Modelfun,BasePrice=BasePricefun, });
			
			int index = newcar.FindIndex (x => x.CarID == CarIDfun);


			Console.Write("Add a package <Y/N>? ");
			string pkg = Console.ReadLine();
			pkg = pkg.ToUpper();
			if(pkg == "Y"){
				Console.Write(" Type: ");
				packagetype = Console.ReadLine();

				Console.Write(" Description: ");
				packagedescription = Console.ReadLine();

				Console.Write(" Price: ");
				packageprice = double.Parse(Console.ReadLine());

				newcar [index].pkg.Description = packagedescription;
				newcar [index].pkg.Type = packagetype;
				newcar [index].pkg.Price = packageprice;

			}else if(pkg == "N"){
				
			}else{
				Console.Write("Not a valid input");
			}




		}

	}
}
